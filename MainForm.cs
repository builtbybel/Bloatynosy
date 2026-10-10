namespace Bloatynosy;

//the one window holds the cards and the button that carries the flow:
//first it looks at the pc, then it changes what the user left ticked.
//each step has its own page, including the report after the work is done.
internal partial class MainForm : Form
{
    private readonly ViewHost _host = null!;
    private bool _busy;

    public MainForm()
    {
        InitializeComponent();
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        Restore();
        _host = new ViewHost(hostPanel);
        _host.Changed += (_, _) => Follow();
        Loc.Changed += LanguageChanged;
        Disposed += (_, _) => Loc.Changed -= LanguageChanged;
        rootTable.Layout += (_, _) => SizeFooterForLayout();
        //the arrow is the designer's; the word is only there for a screen reader
        backChip.AccessibleName = Loc.Get("Main_Back");
        settingsChip.AccessibleName = Loc.Get("Main_Settings");
        workBar.AccessibleName = Loc.Get("Progress_Label");
        footerDetail.AccessibleName = Loc.Get("Result_Details");
        detailsLink.Text = Loc.Get("Main_ShowDetails");
        explainLink.Text = Loc.Get("Explain_Action");
        FormClosing += (_, e) =>
        {
            if (_busy) e.Cancel = true;
            else if (_host.Current is SettingsView settings) settings.Save();
        };
        _host.Show(new CheckView());
    }

    //the settings page changes the language in place, including pages kept for the back arrow
    private void LanguageChanged(object? sender, EventArgs e)
    {
        backChip.AccessibleName = Loc.Get("Main_Back");
        settingsChip.AccessibleName = Loc.Get("Main_Settings");
        workBar.AccessibleName = Loc.Get("Progress_Label");
        footerDetail.AccessibleName = Loc.Get("Result_Details");
        detailsLink.Text = Loc.Get(_detailsOpen ? "Main_HideDetails" : "Main_ShowDetails");
        explainLink.Text = Loc.Get("Explain_Action");
        foreach (var page in _host.Pages)
            switch (page)
            {
                case CheckView check: check.RefreshLanguage(); break;
                case ResultView result: result.RefreshLanguage(); break;
                case ReportView report: report.RefreshLanguage(); break;
                case SettingsView settings: settings.RefreshLanguage(); break;
            }
        Follow();
    }

    // --- pages ---------------------------------------------------------------

    //the button starts the scan or applies the selected changes; removing apps asks once more
    //because uninstalling an app is a different decision from changing a registry value
    private async void Action(object? sender, EventArgs e)
    {
        if (_busy) return;
        if (_host.Current is ResultView selection && selection.RemovalCount > 0)
        {
            using var confirmation = new AppRemovalDialog(selection.SelectedApps);
            if (Shade.ShowDialog(this, confirmation) != DialogResult.OK) return;
        }
        SetBusy(true);
        try
        {
            var progress = new Progress<WorkProgress>(ShowProgress);
            await Task.Yield(); //let the footer paint before background work begins
            if (_host.Current is ResultView results)
            {
                ShowProgress(new WorkProgress(0, 0, Loc.Get("Main_Working"), indeterminate: true));
                _host.Show(new ReportView(await results.ApplySelectionAsync(progress)));
            }
            else
            {
                ShowProgress(new WorkProgress(0, 0, Loc.Get("Apps_Scanning"), indeterminate: true));
                var findings = await Task.Run(() => Scanner.Scan(progress));
                var apps = await PackageService.ScanAsync(progress);
                _host.Show(new ResultView(findings, apps));
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, Loc.Get("Main_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally { SetBusy(false); Follow(); }
    }

    private void SetBusy(bool busy)
    {
        _busy = busy;
        hostPanel.Enabled = backChip.Enabled = settingsChip.Enabled = actionButton.Enabled = !busy;
        if (busy)
        {
            stepStrip.Visible = false;
            workBar.Style = ProgressBarStyle.Marquee;
            workBar.Visible = true;
        }
    }

    private void Settings(object? sender, EventArgs e)
    { if (!_busy) _host.Show(new SettingsView()); }
    private void Back(object? sender, EventArgs e)
    {
        if (_busy) return;
        if (_host.Current is SettingsView settings) settings.Save();
        _host.Back();
    }

    //where the window was last time, or the designer size on a first start
    private void Restore()
    {
        var saved = AppSettings.Current;
        if (saved.WindowWidth > 0 && saved.WindowHeight > 0)
            ClientSize = new Size(saved.WindowWidth, saved.WindowHeight);
        if (Screen.AllScreens.Any(screen => screen.WorkingArea.Contains(saved.WindowX, saved.WindowY)))
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(saved.WindowX, saved.WindowY);
        }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        var saved = AppSettings.Current;
        saved.WindowX = Location.X;
        saved.WindowY = Location.Y;
        saved.WindowWidth = ClientSize.Width;
        saved.WindowHeight = ClientSize.Height;
        saved.Save();
        base.OnFormClosed(e);
    }
}
