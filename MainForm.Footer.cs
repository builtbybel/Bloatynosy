namespace Bloatynosy;

//the bottom card keeps the current step, progress and selected details visible.
internal partial class MainForm
{
    private bool _detailsOpen;

    // --- the bottom card -----------------------------------------------------

    //one place decides what the bottom card says about the page on top
    private void Follow()
    {
        var page = _host.Current;
        var step = page is CheckView ? 1 : page is ResultView ? 2 : page is ReportView ? 3 : 0;
        var isResults = page is ResultView;
        backChip.Visible = !_host.AtStart;
        settingsChip.Visible = page is not SettingsView;
        if (!isResults)
        {
            _detailsOpen = false;
            detailsLink.Text = Loc.Get("Main_ShowDetails");
        }
        bottomCard.Visible = step > 0;
        footerDetail.Visible = isResults && _detailsOpen;
        linksPanel.Visible = isResults;
        detailsLink.Visible = isResults;
        explainLink.Visible = page is ResultView selected && Explainer.CanExplain(selected.SelectedEntry);
        SizeFooterForLayout();
        if (step == 0) return; //a side trip gets the window and leaves the flow where it was
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
            statusLabel.Text = Loc.Get("Main_Step" + step);
            hintLabel.Text = Loc.Get(step == 1 ? "Main_CheckHint" : "Main_ReportHint");
        }
        workBar.Visible = false;
        stepStrip.Visible = true;
        ShowSteps(step == 3 ? 3 : step - 1);
    }

    //three native strips keep the setup steps crisp at any window width.
    private void ShowSteps(int done)
    {
        var active = Color.FromArgb(0, 95, 184);
        var pending = Color.FromArgb(210, 218, 230);
        stepOne.BackColor = done >= 1 ? active : pending;
        stepTwo.BackColor = done >= 2 ? active : pending;
        stepThree.BackColor = done >= 3 ? active : pending;
    }

    //the footer shows measured steps when possible and moves while windows is still counting apps
    private void ShowProgress(WorkProgress progress)
    {
        if (!_busy) return;
        statusLabel.Text = progress.Text;
        workBar.Style = progress.Indeterminate ? ProgressBarStyle.Marquee : ProgressBarStyle.Continuous;
        if (progress.Indeterminate) return;
        workBar.Maximum = Math.Max(1, progress.Total);
        workBar.Value = Math.Min(workBar.Maximum, Math.Max(0, progress.Completed));
    }

    //the same button says apply, reset, or uninstall according to what is selected
    private void UpdateSelection()
    {
        if (_host.Current is not ResultView results || _busy) return;
        actionButton.Enabled = results.ApplyCount + results.ResetCount + results.RemovalCount > 0;
        statusLabel.Text = Loc.Format("Main_Selection", results.ApplyCount, results.ResetCount, results.RemovalCount);
        actionButton.Text = Loc.Get(results.RemovalCount > 0 && results.ApplyCount + results.ResetCount == 0 ? "Apps_Uninstall"
            : results.ResetCount > 0 && results.ApplyCount + results.RemovalCount == 0 ? "Main_Reset" : "Main_Apply");
        footerDetail.Text = results.DetailText;
        hintLabel.Text = results.SummaryText;
        explainLink.Visible = Explainer.CanExplain(results.SelectedEntry);
    }

    private void ResultSelectionChanged(object? sender, EventArgs e) => UpdateSelection();

    //the local detail stays instant; the optional remote answer opens only on this click
    private void ExplainClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        if (_busy || _host.Current is not ResultView results
            || results.SelectedEntry is not object item || !Explainer.CanExplain(item)) return;
        using var dialog = new ExplainDialog(item);
        Shade.ShowDialog(this, dialog);
    }

    //the technical values stay one click away without taking tree space by default.
    private void DetailsLinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
    {
        if (_busy || _host.Current is not ResultView) return;
        _detailsOpen = !_detailsOpen;
        footerDetail.Visible = _detailsOpen;
        detailsLink.Text = Loc.Get(_detailsOpen ? "Main_HideDetails" : "Main_ShowDetails");
        SizeFooterForLayout();
    }

    //the hint sits above a row that is as tall as the taller of its two sides;
    //the button's own minimum carries the number so windows scales it with the dpi
    private void SizeFooterForLayout()
    {
        var row = Math.Max(statusLabel.Height + stepStrip.Height + (linksPanel.Visible ? linksPanel.Height : 0),
            actionButton.MinimumSize.Height + actionButton.Margin.Vertical);
        var height = _host.Current is CheckView or ResultView or ReportView
            ? bottomCard.Margin.Bottom + bottomCard.Padding.Vertical + hintLabel.Height + row
                + (_host.Current is ResultView && _detailsOpen ? footerDetail.Height : 0)
            : 0;
        if (rootTable.RowStyles[2].Height != height)
            rootTable.RowStyles[2].Height = height;
    }

    protected override void OnDpiChanged(DpiChangedEventArgs e)
    {
        base.OnDpiChanged(e);
        SizeFooterForLayout();
    }
}
