namespace Bloatynosy;

//the footer strip: the one action button, the progress of a run, and the selected entry.
internal partial class MainForm
{
    private DetailWindow? _details;              // the detail window, null while none stands open

    // --- the footer ----------------------------------------------------------

    //sets the whole footer to match the page on screen: what is visible, the button and the hint
    private void Follow()
    {
        var page = _host.Current;
        var isResults = page is ResultView;
        //the window stands for one row of the list, so it goes when the list goes
        if (!isResults) _details?.Close();
        footerLine.Visible = footerPanel.Visible = page is CheckView or ResultView or ReportView;
        statusLabel.Visible = isResults;
        workBar.Visible = false;
        if (page is ResultView results)
        {
            results.SelectionChanged -= ResultSelectionChanged;
            results.SelectionChanged += ResultSelectionChanged;
            UpdateSelection();
        }
        else
        {
            actionButton.Text = Loc.Get("Main_Check");
            actionButton.Enabled = true;
            hintLabel.Text = Loc.Get(page is ReportView ? "Main_ReportHint" : "Main_CheckHint");
        }
    }

    //writes the progress text and moves the bar, as a marquee while the total is still unknown
    private void ShowProgress(WorkProgress progress)
    {
        if (!_busy) return;
        statusLabel.Text = progress.Text;
        workBar.Style = progress.Indeterminate ? ProgressBarStyle.Marquee : ProgressBarStyle.Continuous;
        if (progress.Indeterminate) return;
        workBar.Maximum = Math.Max(1, progress.Total);
        workBar.Value = Math.Min(workBar.Maximum, Math.Max(0, progress.Completed));
    }

    //takes button text, enabled state, status, hint and detail from what is ticked on the page
    private void UpdateSelection()
    {
        if (_host.Current is not ResultView results || _busy) return;
        actionButton.Enabled = results.ApplyCount + results.ResetCount + results.RemovalCount > 0;
        statusLabel.Text = Loc.Format("Main_Selection", results.ApplyCount, results.ResetCount, results.RemovalCount);
        actionButton.Text = Loc.Get(results.RemovalCount > 0 && results.ApplyCount + results.ResetCount == 0 ? "Apps_Uninstall"
            : results.ResetCount > 0 && results.ApplyCount + results.RemovalCount == 0 ? "Main_Reset" : "Main_Apply");
        hintLabel.Text = results.SummaryText;
        _details?.ShowEntry(results.SelectedEntry, results.DetailText);
    }

    private void ResultSelectionChanged(object? sender, EventArgs e) => UpdateSelection();

    //there is only ever one window: a second click brings the standing one forward and refills it
    private DetailWindow? OpenDetails()
    {
        if (_busy || _host.Current is not ResultView results) return null;
        if (_details == null)
        {
            _details = new DetailWindow();
            _details.FormClosed += (_, _) => _details = null;
            Shade.Show(this, _details);
        }
        else _details.Activate();
        _details.ShowEntry(results.SelectedEntry, results.DetailText);
        return _details;
    }
}
