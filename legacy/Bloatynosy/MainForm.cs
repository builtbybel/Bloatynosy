using Bloatynosy.Helpers;
using Bloatynosy.Views;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Views;

namespace Bloatynosy
{
    public partial class MainForm : Form
    {
        private LoggerForm loggerForm;
        private Control storeView;
        private NavigationManager navigationManager;

        public MainForm()
        {
            InitializeComponent();
            navigationManager = new NavigationManager(panelContainer);
            FAQManager.InitializeFAQ(panelFAQ);
            DarkModeManager.ApplyDarkMode(this);

            InitializeUI();
            InitializeLogger();
            InitializeLocalizedStrings();
            InitializeDropdown();
        }

        private void InitializeUI()
        {
            // Set Unicode icons from Segoe MDL2 Assets
            btnHome.Text = "\uE80F";             // Home icon
            btnBack.Text = "\uE72B";             // Back icon
            btnCloseFAQ.Text = "\uE8BB";         // Close icon
            assetChevronDown.Text = "\uE70D";    // Dropdown icon
            assetChevronRight1.Text =
            assetChevronRight2.Text =
            assetChevronRight3.Text =
            assetChevronRight4.Text = "\uE76C";  // Chevron icon
            assetInfo.Text = "\uF167";           // Info icon

            // Attach button click events for switching views
            btnHome.Click += (s, e) => { navigationManager.GoToMain(); };
            btnExperience.Click += (s, e) => { navigationManager.SwitchView(new ExperienceView()); };
            btnDumputer.Click += (s, e) => { navigationManager.SwitchView(new AppsView()); };
            btnPlugins.Click += (s, e) => { navigationManager.SwitchView(new PluginsView(navigationManager)); };
            btnSettings.Click += (s, e) => { navigationManager.SwitchView(new SettingsView()); };
            btnLogger.Click += (s, e) => ToggleLoggerForm();         // Notification view
            btnStore.Click += StoreButtonClick;                      // Open the plugin store
            btnHomeStore.Click += StoreButtonClick;                  // Open the plugin store
        }

        private void InitializeLogger()
        {
            Logger logger = new Logger();
            logger.Log($"Application started at: {DateTime.Now}", Color.Gray);
            logger.Log($"Application version: {Program.GetAppVersion()}", Color.Gray);
            logger.Log($"Machine Name: {Environment.MachineName}", Color.Gray);
            logger.Log($"User: {Environment.UserName}", Color.Gray);

            bool pluginReady = PluginHelper.IsPluginEnvironmentReady();
            logger.Log(pluginReady ? "Plugin environment is ready." : "Plugin environment is not ready.",
                       pluginReady ? Color.Green : Color.Red);

            logger.Log("Follow this app on GitHub: https://github.com/builtbybel/Bloatynosy", Color.Magenta);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (navigationManager.CanGoBack()) // Check if there is a view to go back to
            {
                navigationManager.GoBack();
            }
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = Locales.Strings.ctl_lblHeader;
            lblSubHeader.Text = Locales.Strings.ctl_lblSubHeader;
            btnDropdown.Text = Locales.Strings.ctl_btnDropdown;
            btnExperience.Text = Locales.Strings.ctl_btnExperience;
            btnPlugins.Text = Locales.Strings.ctl_btnPlugins;
            btnDumputer.Text = Locales.Strings.ctl_btnDumputer;
            btnStore.Text = Locales.Strings.ctl_btnStore;
            btnSettings.Text = Locales.Strings.ctl_linkSettings;
            btnLogger.Text = Locales.Strings.tt_btnLogger;
            btnHomeStore.Text = Locales.Strings.formPlugins_ctl_btnPluginStore; // Browse Store

            // Set tooltips and localized text
            toolTip.SetToolTip(btnExperience, Locales.Strings.tt_btnExperience);
            toolTip.SetToolTip(btnDumputer, Locales.Strings.tt_btnDumputer);
            toolTip.SetToolTip(btnPlugins, Locales.Strings.tt_btnPlugins);
            toolTip.SetToolTip(btnStore, Locales.Strings.ctl_btnStore);
            toolTip.SetToolTip(btnLogger, Locales.Strings.tt_btnLogger);
            toolTip.SetToolTip(btnSettings, Locales.Strings.ctl_linkSettings);
        }

        private async void StoreButtonClick(object sender, EventArgs e)
        {
            if (!PluginHelper.IsPluginEnvironmentReady() && MessageBox.Show(
                    Locales.Strings.formPlugins_status_notReady.Replace(@"\n", Environment.NewLine),
                    "Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await PluginHelper.DownloadPlugins();
            }
            if (PluginHelper.IsPluginEnvironmentReady()) ShowPluginStore();
        }

        // Switch to Plugin Store view from any view
        public void ShowPluginStore()
        {
            if (storeView == null) storeView = new StoreView();
            navigationManager.SwitchView(storeView);
        }

        private LoggerForm CreateLoggerForm()
        {
            if (loggerForm == null)
            {
                loggerForm = new LoggerForm();
                Logger.SetLoggerForm(loggerForm); // Set the LoggerForm instance for logging

                // Subscribe to the Deactivate event
                loggerForm.Deactivate += (s, e) =>
                {
                    // Hide the LoggerForm when it loses focus
                    loggerForm.Hide();
                    this.Opacity = 1; // Reset the opacity of the MainForm
                };
            }
            return loggerForm;
        }

        // Toggle the visibility of the LoggerForm
        public void ToggleLoggerForm()
        {
            if (loggerForm == null)
            {
                // Create the LoggerForm if it does not already exist
                loggerForm = CreateLoggerForm();
            }

            if (loggerForm.Visible)
            {
                // Hide the LoggerForm if it is currently visible
                loggerForm.Hide();
            }
            else
            {
                // Set the LoggerForm's position and show it if it is not visible
                loggerForm.Location = new Point(this.Right - 400, this.Top + 70); // Position relative to the MainForm
                loggerForm.Size = new Size(400, 600);
                loggerForm.Show();
                this.Opacity = 0.9; // Set the opacity of the MainForm when the LoggerForm is visible
            }
        }

        // Reposition panels when hiding the FAQ panel
        private void RepositionPanels(Control hiddenPanel)
        {
            int startY = hiddenPanel.Top; // The top position of the hidden panel

            foreach (Control panel in panelMain.Controls)
            {
                // Ignore the hidden panel and any panel above it
                if (panel.Top <= startY || !panel.Visible) continue;

                // Move the panel up by the height of the hidden panel
                panel.Top -= hiddenPanel.Height + 30;
            }
        }

        // Toggle the visibility of the dropdown options panel
        private void InitializeDropdown()
        {
            EventHandler toggleDropdown = (s, e) =>
            {
                panelOptions.Visible = !panelOptions.Visible;
            };

            btnDropdown.Click += toggleDropdown;
            assetChevronDown.Click += toggleDropdown;

            SetupOptionButton(btnOption1, Locales.Strings.tt_btnExperience, btnExperience);
            SetupOptionButton(btnOption2, Locales.Strings.tt_btnDumputer, btnDumputer);
            SetupOptionButton(btnOption3, Locales.Strings.tt_btnPlugins, btnPlugins);
            SetupOptionButton(btnOption4, "Use AI-powered Bloatware Filter (requires AppMatrix Plugin)", btnStore);
        }

        private void SetupOptionButton(Button optionButton, string displayText, Button associatedButton)
        {
            optionButton.Text = displayText;
            optionButton.Click += (s, e) =>
            {
                btnDropdown.Text = displayText; // Update the dropdown button's text to match the selected option
                panelOptions.Visible = false;
                associatedButton.PerformClick();
            };
        }

        private void btnCloseFAQ_Click(object sender, EventArgs e)
        {
            panelFAQ.Hide();
            RepositionPanels(panelFAQ);
        }

        private void linkAppDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/builtbybel/Bloatynosy");
        }

        private void linkShare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string tweetUrl = "https://x.com/intent/tweet?text=Bloatynosy%20is%20back%20and%20better%20than%20ever!%20Check%20it%20out%20on%20GitHub:%20https%3A%2F%2Fgithub.com%2Fbuiltbybel%2FBloatynosy%20%23Bloatynosy%20%23Windows11%20%23Microsoft%20%23Debloat";
            Process.Start(new ProcessStartInfo
            {
                FileName = tweetUrl,
                UseShellExecute = true
            });
        }
    }
}