namespace Bloatynosy;

//the one window: the navigation on the left names every destination, the card in the middle
//shows the chosen one, and the bottom card carries what the user can do with it.
internal partial class MainForm : Form
{
    private readonly ViewHost _host = null!;     // the middle card, one page at a time
    private List<Finding>? _findings;            // the last check, the navigation pages through it
    private AppScan? _apps;                      // the installed apps of that same check
    private string _key = "overview";            // the row the column stands on, for an ended search
    private bool _busy;                          // a check or a write runs, the window holds still

    public MainForm()
    {
        InitializeComponent();
        //the designer builds this form as well, and it must not go scanning a developer's pc
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        Restore();                                                   // the size and the place of the last session
        _host = new ViewHost(hostPanel);                            // from here on the middle card belongs to him
        Names();                                                    // the words of the footer, in the saved language

        //the rest is wiring
        _host.Changed += (_, _) => Follow();                        // another page, so the footer follows it
        navView.Picked += (_, key) => Navigate(key);               // a row of the column was clicked
        searchField.Changed += Searched;                           // a word was typed, or taken back again
        Loc.Changed += LanguageChanged;                            // the settings page switched the language
        Disposed += (_, _) => Loc.Changed -= LanguageChanged;      // loc outlives the form, so let go
        //a check or a write has to end before the window may close
        FormClosing += (_, e) => { if (_busy) e.Cancel = true; else Leaving(); };
        //the search box is the first control, so it would open with the caret in it; ctrl+f still gets it
        Shown += (_, _) => ActiveControl = null;

        _host.Show(new CheckView());             // the page the app opens on
    }

    // --- pages ---------------------------------------------------------------

    //opens the page behind a column row; the first row that needs check data runs the check
    private async void Navigate(string key)
    {
        if (_busy) return;
        Leaving();
        _key = key;
        if (key == "settings") { _host.Show(new SettingsView()); return; }
        if (key == "overview") { _host.Show(new CheckView()); return; }
        if (_findings == null && !await CheckAsync()) { navView.Choose("overview"); return; }
        Open(key);
    }

    //searches the whole catalogue while the box has text, and returns to the chosen row when empty
    private async void Searched(object? sender, EventArgs e)
    {
        if (_busy) return;
        if (searchField.Text.Trim().Length == 0) { Navigate(_key); return; }
        Leaving();
        if (_findings == null && !await CheckAsync()) return;
        Open("all");
    }

    //builds a fresh result page for one category, applies the search text and updates the counts
    private void Open(string key)
    {
        var page = new ResultView(_findings!, _apps);
        page.ShowCategory(key, searchField.Text.Trim());
        page.CountsChanged += (_, _) => navView.ShowCounts(page.Counts());
        //the detail window needs an owner, so the page only says that a row wants it
        page.DetailsWanted += (_, _) => OpenDetails();
        page.ExplainWanted += (_, _) => OpenDetails()?.Ask();
        navView.ShowCounts(page.Counts());
        navView.Choose(key);
        _host.Show(page);
    }

    //ctrl+f puts the caret in the search box, escape empties it, from anywhere in the window
    protected override bool ProcessCmdKey(ref Message message, Keys key)
    {
        if (_busy) return base.ProcessCmdKey(ref message, key);
        if (key == (Keys.Control | Keys.F)) { searchField.Pick(); return true; }
        if (key == Keys.Escape && searchField.Text.Length > 0) { searchField.Wipe(); return true; }
        return base.ProcessCmdKey(ref message, key);
    }

    // --- work ----------------------------------------------------------------

    //the footer button: applies the selection on a result page, runs the check on any other
    private async void Action(object? sender, EventArgs e)
    {
        if (_busy) return;
        if (_host.Current is ResultView results) { await ApplyAsync(results); return; }
        if (await CheckAsync()) { _key = "open"; Open("open"); }
    }

    //reads the registry and the installed apps in the background, false if either one threw
    private async Task<bool> CheckAsync()
    {
        SetBusy(true);
        try
        {
            var progress = new Progress<WorkProgress>(ShowProgress);
            ShowProgress(new WorkProgress(0, 0, Loc.Get("Apps_Scanning"), indeterminate: true));
            await Task.Yield(); //let the footer paint before background work begins
            _findings = await Task.Run(() => Scanner.Scan(progress));
            _apps = await PackageService.ScanAsync(progress);
            return true;
        }
        catch (Exception ex) { Failed(ex); return false; }
        finally { SetBusy(false); Follow(); }
    }

    //writes the selection, discards the now stale check and shows the report; removals ask first
    private async Task ApplyAsync(ResultView results)
    {
        if (results.RemovalCount > 0)
        {
            using var confirmation = new AppRemovalDialog(results.SelectedApps);
            if (Shade.ShowDialog(this, confirmation) != DialogResult.OK) return;
        }
        SetBusy(true);
        try
        {
            var progress = new Progress<WorkProgress>(ShowProgress);
            ShowProgress(new WorkProgress(0, 0, Loc.Get("Main_Working"), indeterminate: true));
            await Task.Yield();
            var report = await results.ApplySelectionAsync(progress);
            //what was just written makes the check stale, so the next destination asks the pc again
            _findings = null;
            _apps = null;
            navView.ShowCounts(new Dictionary<string, int>());
            _host.Show(new ReportView(report));
        }
        catch (Exception ex) { Failed(ex); }
        finally { SetBusy(false); Follow(); }
    }

    //shows the message of a failed check or write in a dialog, nothing is swallowed
    private void Failed(Exception error) =>
        MessageBox.Show(this, error.Message, Loc.Get("Main_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

    //saves the settings page before the window leaves it, since it has no save button
    private void Leaving()
    {
        if (_host.Current is SettingsView settings) settings.Save();
    }

    //locks the page, the column and the button while work runs, and shows the progress bar
    private void SetBusy(bool busy)
    {
        _busy = busy;
        hostPanel.Enabled = navView.Enabled = actionButton.Enabled = !busy;
        if (!busy) return;
        footerLine.Visible = footerPanel.Visible = statusLabel.Visible = workBar.Visible = true;
        workBar.Style = ProgressBarStyle.Marquee;
    }

    // --- language ------------------------------------------------------------

    //fills every footer text and accessible name from the language that is loaded
    private void Names()
    {
        searchField.RefreshLanguage();
        workBar.AccessibleName = Loc.Get("Progress_Label");
    }

    //re-translates the footer, the column and the page on screen when the language was switched
    private void LanguageChanged(object? sender, EventArgs e)
    {
        Names();
        navView.RefreshLanguage();
        (_host.Current as ITranslated)?.RefreshLanguage();
        Follow();
    }

    // --- the window ----------------------------------------------------------

    //restores size and position from the settings, the position only if a screen still holds it
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

    //stores size and position in the settings, so the next start opens in the same spot
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
