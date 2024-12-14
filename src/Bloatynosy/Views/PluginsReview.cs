using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Views;

namespace BloatynosyNue.Views
{
    public partial class PluginsReview : UserControl
    {
        private Dictionary<TreeNode, bool> pendingChanges;
        private PSPluginHandler PSPlugins;
        private Logger logger;
        private PluginsView pluginsView;
        private Panel parentPanel;

        public PluginsReview(PluginsView pluginsView, Panel parentPanel, Dictionary<TreeNode, bool> pendingChanges, Logger logger, PSPluginHandler psPlugins)
        {
            InitializeComponent();
            InitializeLocalizedStrings();

            this.pluginsView = pluginsView;  // Save the reference to PluginsView
            this.parentPanel = parentPanel; // Save the reference to the parent panel
            this.pendingChanges = pendingChanges;
            this.logger = logger;
            this.PSPlugins = psPlugins;

            LoadSummary();
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = BloatynosyNue.Locales.Strings.formPlugins_ctl_lblHeader;
            btnViewSc.Text = BloatynosyNue.Locales.Strings.formPluginsReview_ctl_btnViewSc;
            btnRun.Text = BloatynosyNue.Locales.Strings.formPluginsReview_ctl_btnRun;

            btnBack.Text = BloatynosyNue.Locales.Strings.ctl_btnBack;
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
            Logger.OpenLoggerForm();

            foreach (var entry in pendingChanges)
            {
                var node = entry.Key;
                bool shouldApply = entry.Value;

                if (shouldApply)
                {
                    if (node.Tag is JsonPluginHandler plugin)
                    {
                        logger.Log($"Applying plugin: {plugin.PlugID}", Color.Blue);
                        plugin.PlugDoFeature();
                        node.BackColor = Color.LightGreen;
                        logger.Log($"Activated plugin: {plugin.PlugID}", Color.Black);
                    }
                    else if (node.Tag is string psScriptPath)
                    {
                        logger.Log($"Executing PowerShell script: {Path.GetFileName(psScriptPath)}", Color.Blue);
                        await PSPlugins.ExecutePlugin(psScriptPath, logger);
                        node.BackColor = Color.LightGreen;
                        logger.Log($"Executed PowerShell script: {Path.GetFileName(psScriptPath)}", Color.Black);
                    }
                }
                else
                {
                    if (node.Tag is JsonPluginHandler plugin)
                    {
                        logger.Log($"Undoing plugin: {plugin.PlugID}", Color.Blue);
                        plugin.PlugUndoFeature();
                        node.BackColor = Color.LightGray;
                        logger.Log($"Deactivated plugin: {plugin.PlugID}", Color.Crimson);
                    }
                    else if (node.Tag is string psScriptPath)
                    {
                        logger.Log($"PowerShell script cannot be undone: {Path.GetFileName(psScriptPath)}", Color.Crimson);
                        node.BackColor = Color.LightGray;
                    }
                }
            }

            btnRun.Enabled = true;
            logger.Log("Execution completed.", Color.Black);
            pendingChanges.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Use SwitchView to go back to PluginsView
            SwitchView.BackToPluginsView(pluginsView, parentPanel);
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