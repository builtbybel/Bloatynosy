using BloatynosyNue.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using Views;

namespace BloatynosyNue.Views
{
    public partial class PluginsView : UserControl
    {
        private Logger logger;
        private PSPluginHandler PSPlugins;
        private Dictionary<TreeNode, bool> pendingChanges = new Dictionary<TreeNode, bool>();
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string pluginsDirectory = Path.Combine(Application.StartupPath, "plugins");

        public PluginsView()
        {
            InitializeComponent();
            InitializeLogger();
            InitializeLocalizedStrings();

            btnPluginsDir.Text = "\uED25"; // Folder icon
            btnRefresh.Text = "\uE72C"; // Refresh icon
        }

        private void PluginsView_Load(object sender, EventArgs e)
        {
            LoadPlugins();
        }

        private void InitializeLogger()
        {
            logger = new Logger();
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = BloatynosyNue.Locales.Strings.formPlugins_ctl_lblHeader;
            lblSubHeader.Text = BloatynosyNue.Locales.Strings.formPlugins_ctl_lblSubHeader;
            btnPluginStore.Text = BloatynosyNue.Locales.Strings.formPlugins_ctl_btnPluginStore;
            btnNext.Text = BloatynosyNue.Locales.Strings.formPlugins_ctl_btnNext;
            lblInstalled.Text = BloatynosyNue.Locales.Strings.formPlugins_ctl_lblInstalled;
            btnDonate.Text = BloatynosyNue.Locales.Strings.ctl_Donate;
        }

        public async void LoadPlugins()
        {
            if (PluginHelper.IsPluginEnvironmentReady())
            {
                // Load native JSON plugins
                await JsonPluginHandler.LoadPlugins("plugins", treePlugins.Nodes, logger);
                logger.Log("Plugins [Native] initialized.", Color.Green);

                // Load PowerShell plugins
                PSPlugins = new PSPluginHandler();
                PSPlugins.LoadPowerShellPlugins(treePlugins);
                logger.Log("Plugins [PS] initialized.", Color.Green);

                // Expand all nodes
                ExpandAllNodes(treePlugins.Nodes);
            }
        }

        private void ExpandAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Expand();
                ExpandAllNodes(node.Nodes);
            }
        }

        private void treePlugins_AfterCheck(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
            bool shouldApply = node.Checked;

            pendingChanges[node] = shouldApply;
            node.BackColor = shouldApply ? Color.LightGreen : Color.LightGray;

            if (node.Tag is JsonPluginHandler jsonPlugin)
            {
                logger.Log($"{(shouldApply ? "Activated" : "Deactivated")} Plugin: {jsonPlugin.PlugID}", shouldApply ? Color.Black : Color.Crimson);
            }
            else if (node.Tag is string psScriptPath)
            {
                logger.Log($"{(shouldApply ? "Activated" : "Deactivated")} PowerShell script: {Path.GetFileName(psScriptPath)}", shouldApply ? Color.Black : Color.Crimson);
            }

            /* Synchronize the parent node state if it exists
            if (node.Parent != null)
            {
                node.Parent.Checked = node.Checked;
            } */
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var pluginsReview = new PluginsReview(this, this.Parent as Panel, pendingChanges, logger, PSPlugins);
            SwitchView.SetView(pluginsReview, this.Parent as Panel);
        }

        private async void btnPluginStore_Click(object sender, EventArgs e)
        {
            if (!PluginHelper.IsPluginEnvironmentReady())
            {
                if (MessageBox.Show(
                    Locales.Strings.formPlugins_status_notReady.Replace(@"\n", Environment.NewLine),
                    "Store",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Download the plugin components
                    await PluginHelper.DownloadPlugins();
                }
                else
                {
                    return;
                }
            }

            // Switch to the Plugin Store
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.ShowPluginStore();
        }

        public void ShowRandomDonationPrompt()
        {
            // Load donation prompts from Res file
            string allMessages = Locales.Strings.ctl_DonationPrompts;

            // Split the messages by semicolon
            string[] donationMessages = allMessages.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            // Donation prompts from Res file   |  Would you like to donate?
            string message = $"{donationMessages[new Random().Next(donationMessages.Length)]} {Locales.Strings.ctl_DonateAsk}";

            if (MessageBox.Show(message, "Support Bloatynosy Nue", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://paypal.com/donate?hosted_button_id=MY7HX4QLYR4KG",
                    UseShellExecute = true
                });
            }
        }

        // Refresh the tree view
        public void RefreshPlugins()
        {
            treePlugins.Nodes.Clear();

            // Reload
            LoadPlugins();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            ShowRandomDonationPrompt();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPlugins();
        }

        private void btnPluginsDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", pluginsDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open plugins directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}