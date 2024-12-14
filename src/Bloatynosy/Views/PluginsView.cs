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
        private PluginsReview pluginsView;
        private Panel parentPanel;

        private Dictionary<TreeNode, bool> pendingChanges = new Dictionary<TreeNode, bool>();
        private static readonly HttpClient httpClient = new HttpClient();

        public PluginsView(Panel parentPanel)
        {
            InitializeComponent();
            InitializeLogger();
            InitializeLocalizedStrings();
            this.parentPanel = parentPanel;
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

            btnBack.Text = BloatynosyNue.Locales.Strings.ctl_btnBack;
        }

        // Refresh the tree view
        public void RefreshPlugins()
        {
            treePlugins.Nodes.Clear();

            // Reload
            LoadPlugins();
        }

        private bool IsPluginEnvironmentReady() =>
         Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins")) &&
         File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Newtonsoft.Json.dll"));

        public async void LoadPlugins()
        {
            if (IsPluginEnvironmentReady())
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
            if (IsPluginEnvironmentReady())
            {
                // Navigate to PluginsReview
                var pluginsReview = new PluginsReview(this, parentPanel, pendingChanges, logger, PSPlugins);
                SwitchView.SetView(pluginsReview, parentPanel);
            }
            else
            {
                MessageBox.Show("The plugin environment is not ready. Please check your setup.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SwitchView.GoBack(this.Parent as Panel);
        }

        private async void btnPluginStore_Click(object sender, EventArgs e)
        {
            if (!IsPluginEnvironmentReady())
            {
                if (MessageBox.Show(
                 Locales.Strings.formPlugins_status_notReady.Replace(@"\n", Environment.NewLine),
                    "Store",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string pluginFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins");
                    string downloadUrl = "https://github.com/builtbybel/Bloatynosy/raw/main/plugins/Newtonsoft.Json.dll";
                    string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Newtonsoft.Json.dll");

                    try
                    {
                        // Create Plugin directory if it doesn't exist
                        if (!Directory.Exists(pluginFolderPath))
                        {
                            Directory.CreateDirectory(pluginFolderPath);
                        }

                        using (HttpClient client = new HttpClient())
                        {
                            var response = await client.GetAsync(downloadUrl);
                            response.EnsureSuccessStatusCode();

                            using (var fileStream = new FileStream(dllPath, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                await response.Content.CopyToAsync(fileStream);
                            }
                        }

                        MessageBox.Show(Locales.Strings.formPlugins_status_Ready.Replace(@"\n", Environment.NewLine), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}\nPlease try again later.", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                 //   MessageBox.Show("No worries, maybe next time!", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Open the store if the environment is ready
            StoreForm storeForm = new StoreForm(this);
            storeForm.ShowDialog();
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

        private void btnDonate_Click(object sender, EventArgs e)
        {
            ShowRandomDonationPrompt();
        }
    }
}