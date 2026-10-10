using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloatynosy.Views
{
    public partial class PluginsReview : UserControl
    {
        private NavigationManager navigationManager;
        private Dictionary<TreeNode, bool> pendingChanges;
        private PSPluginHandler PSPlugins;
        private Logger logger;

        public PluginsReview(NavigationManager navigationManager, Dictionary<TreeNode, bool> pendingChanges, Logger logger, PSPluginHandler PSPlugins)
        {
            InitializeComponent();
            DarkModeManager.ApplyDarkMode(this);
            InitializeLocalizedStrings();

            this.navigationManager = navigationManager;
            this.pendingChanges = pendingChanges;
            this.logger = logger;
            this.PSPlugins = PSPlugins;

            LoadSummary();
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = Bloatynosy.Locales.Strings.formPluginsReview_ctl_lblHeader;
            btnViewSc.Text = Bloatynosy.Locales.Strings.formPluginsReview_ctl_btnViewSc;
            btnRun.Text = Bloatynosy.Locales.Strings.formPluginsReview_ctl_btnRun;

            btnBack.Text = Bloatynosy.Locales.Strings.ctl_btnBack;
        }

        private void LoadSummary()
        {
            textSummary.Text = ""; // Clear current content

            if (pendingChanges.Count == 0)
            {
                // No plugins selected. Please select plugins to apply or revert.
                textSummary.Text = $"{Locales.Strings.formPluginsReview_status_Summary}\n";
                btnRun.Enabled = false;
            }
            else
            {
                // Otherwise, show the status of selected plugins
                int step = 1;
                foreach (var entry in pendingChanges)
                {
                    var node = entry.Key;
                    bool shouldApply = entry.Value;

                    // "To be Applied"           or             "To be Reverted"
                    string status = shouldApply ? Locales.Strings.formPluginsReview_status_tobeApplied : Locales.Strings.formPluginsReview_status_tobeReverted;
                    string descriptionText = string.Empty;

                    if (node.Tag is JsonPluginHandler plugin)
                    {
                        descriptionText = $"Native Plugin: {plugin.PlugID}\r\n{plugin.PlugInfo}";
                    }
                    else if (node.Tag is string psScriptPath)
                    {
                        descriptionText = $"PowerShell Script: {Path.GetFileName(psScriptPath)}\r\n{psScriptPath}";
                    }

                    // Process layout with indentations
                    textSummary.Text += $"Step {step++}:" + Environment.NewLine; ;
                    textSummary.Text += $"  - Plugin: {node.Text} ({status})" + Environment.NewLine;
                    textSummary.Text += $"    Description: {descriptionText}" + Environment.NewLine;
                    textSummary.Text += $"    Status: [{status}...]" + Environment.NewLine;
                    textSummary.Text += new string('-', 40) + Environment.NewLine; // Separator, 40 dashes for visual clarity
                }
            }
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;

            // Switch to the logger view
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.ToggleLoggerForm();
            }

            int step = 1;
            foreach (var entry in pendingChanges)
            {
                var node = entry.Key;
                bool shouldApply = entry.Value;

                // Update status to "In Progress"
                UpdateSummaryStatus(step, "In Progress");

                if (shouldApply)
                {
                    if (node.Tag is JsonPluginHandler plugin)
                    {
                        logger.Log($"Applying plugin: {plugin.PlugID}", Color.FromArgb(41, 53, 149));
                        await Task.Run(() => plugin.PlugDoFeature()); // Simulate work
                        node.BackColor = Color.LightGreen;
                        logger.Log($"Activated plugin: {plugin.PlugID}", Color.HotPink);
                    }
                    else if (node.Tag is string psScriptPath)
                    {
                        logger.Log($"Executing PowerShell script: {Path.GetFileName(psScriptPath)}", Color.FromArgb(41, 53, 149));
                        await PSPlugins.ExecutePlugin(psScriptPath, logger);
                        node.BackColor = Color.LightGreen;
                        logger.Log($"Executed PowerShell script: {Path.GetFileName(psScriptPath)}", Color.HotPink);
                    }
                }
                else
                {
                    if (node.Tag is JsonPluginHandler plugin)
                    {
                        logger.Log($"Undoing plugin: {plugin.PlugID}", Color.FromArgb(41, 53, 149));
                        await Task.Run(() => plugin.PlugUndoFeature()); // Simulate work
                        node.BackColor = Color.LightGray;
                        logger.Log($"Deactivated plugin: {plugin.PlugID}", Color.Crimson);
                    }
                    else if (node.Tag is string psScriptPath)
                    {
                        logger.Log($"PowerShell script cannot be undone: {Path.GetFileName(psScriptPath)}", Color.Crimson);
                        node.BackColor = Color.LightGray;
                    }
                }

                // Update status to "Completed" or "Reverted"
                UpdateSummaryStatus(step, shouldApply ? "Completed" : "Reverted");

                step++;
            }

            btnRun.Enabled = true;
            logger.Log("Execution completed.", Color.HotPink);
            pendingChanges.Clear();
        }

        // Helper method to update the status in the summary
        private void UpdateSummaryStatus(int step, string newStatus)
        {
            string[] lines = textSummary.Lines;
            string stepPrefix = $"Step {step}:";
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(stepPrefix))
                {
                    // Find the line starting with "Status:" under this step
                    for (int j = i + 1; j < lines.Length; j++)
                    {
                        if (lines[j].TrimStart().StartsWith("Status:"))
                        {
                            lines[j] = $"    Status: [{newStatus}]";
                            break;
                        }
                    }
                    break;
                }
            }
            textSummary.Lines = lines;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (navigationManager.CanGoBack())
            {
                navigationManager.GoBack();
            }
        }

        private void btnViewSc_Click(object sender, EventArgs e)
        {
            StringBuilder scriptDisplay = new StringBuilder();
            bool scriptFound = false;

            foreach (var entry in pendingChanges)
            {
                var node = entry.Key;
                bool shouldApply = entry.Value;

                // Check if the node is checked and contains a valid script path
                if (shouldApply && node.Tag is string scriptPath && File.Exists(scriptPath))
                {
                    scriptFound = true;
                    string scriptContent = File.ReadAllText(scriptPath);

                    // Append script content with a separator
                    scriptDisplay.AppendLine($"--- Content of {Path.GetFileName(scriptPath)} ---");
                    scriptDisplay.AppendLine(scriptContent);
                    scriptDisplay.AppendLine(new string('-', 50));
                }
            }

            if (scriptFound)
            {
                textSummary.Text = scriptDisplay.ToString();
            }
            else
            {
                MessageBox.Show("No checked scripts found to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}