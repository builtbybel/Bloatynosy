using BloatynosyNue.Helpers;
using BloatynosyNue.Views;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Views;

namespace BloatynosyNue
{
    public partial class MainForm : Form
    {
        private PluginsView pluginsView;
        private Control storeView; // Control for StoreView

        public MainForm()
        {
            InitializeComponent();
            InitializeApp();
        }

        private void InitializeApp()
        {
            this.Size = new Size(900, 700);
            InitializeLogger();
            InitializeLocalizedStrings();
            InitializeUI();
            SetButtonIcons();
        }

        private void InitializeLogger()
        {
            // Create the Logger and add logs
            Logger logger = new Logger();
            logger.Log($"Application started at: {DateTime.Now}", Color.Gray);
            string appVersion = Program.GetAppVersion();
            logger.Log($"Application version: {appVersion}", Color.Gray);
            logger.Log($"OS Version: {Environment.OSVersion}", Color.Gray);
            logger.Log($"Machine Name: {Environment.MachineName}", Color.Gray);
            logger.Log($"User: {Environment.UserName}", Color.Gray);

            bool pluginReady = PluginHelper.IsPluginEnvironmentReady();
            logger.Log(pluginReady ? "Plugin environment is ready." : "Plugin environment is not ready.", pluginReady ? Color.Green : Color.Red);

            // Add additional info
            logger.Log("Follow this app on GitHub: https://github.com/builtbybel/Bloatynosy", Color.Magenta);
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = Locales.Strings.ctl_lblHeader;
            lblSubHeader.Text = Locales.Strings.ctl_lblSubHeader;
            lblSteps.Text = Locales.Strings.ctl_lblSteps;
            btnExperience.Text = Locales.Strings.ctl_btnExperience;
            btnDumputer.Text = Locales.Strings.ctl_btnDumputer; 

            SetToolTips();
        }

        private void SetToolTips()
        {
            foreach (var btn in new[] { btnExperience, btnDumputer, btnPlugins, btnLogger, btnSettings })
                toolTip.SetToolTip(btn, Locales.Strings.ResourceManager.GetString("tt_" + btn.Name));
        }

        private void SetButtonIcons()
        {
            btnSettings.Text = "\uE713";
            btnLogger.Text = "\uEA8F";
            btnPlugins.Text = "\uEA86";
        }

        private void InitializeUI()
        {
            // Add the mainPanel to the panelContainer
            panelContainer.Controls.Add(mainPanel);

            // Add panelContainer to the form
            this.Controls.Add(panelContainer);

            // Initialize button event handlers for fixed buttons
            btnLogger.Click += (s, e) => OpenTab(Locales.Strings.tt_btnLogger);
            btnSettings.Click += (s, e) => OpenTab(Locales.Strings.tt_btnSettings);
            btnPlugins.Click += (s, e) => OpenTab(Locales.Strings.tt_btnPlugins);
            btnDumputer.Click += (s, e) => OpenTab(Locales.Strings.ctl_btnDumputer);
            btnExperience.Click += (s, e) => OpenTab(Locales.Strings.ctl_btnExperience);

            // Add "Start" button directly in the initialization
            Button startButton = CreateButton("Start");
            startButton.Click += (s, e) =>
            {
                // Show the main panel view inside the mainPanel
                ShowMainContent();
            };

            // Add the Start button to the button panel at the top
            buttonPanel.Controls.Add(startButton);
            startButton.Dock = DockStyle.Top;

            // Add the "Store" button to the button panel
            Button storeButton = CreateStoreButton("Store");
            storeButton.Click += async (s, e) =>
            {
                StoreButtonClick(s, e);
            };

            // Add the "Store" button next to the "Start" button
            buttonPanel.Controls.Add(storeButton);

            // Show the main content when the app starts
            ShowMainContent();
        }

        // Show the main content view inside the mainPanel
        private void ShowMainContent()
        {
            panelContainer.Controls.Clear();

            // Add the mainPanel to the panelContainer again
            panelContainer.Controls.Add(mainPanel);

            SetActiveTab("Start"); // Mark "Start" tab as active
        }

        // Set the active tab by changing the button color
        private void SetActiveTab(string activeTabText)
        {
            foreach (Button btn in buttonPanel.Controls.OfType<Button>())
            {    // active >  inactive
                btn.BackColor = btn.Text == activeTabText ? Color.FromArgb(250, 250, 250) : Color.FromArgb(244, 244, 244);
                btn.ForeColor = btn.Text == activeTabText ? Color.FromArgb(255, 12, 168) : Color.Black;
                btn.FlatAppearance.BorderSize = btn.Text == activeTabText ? 1 : 0;
                btn.FlatStyle = btn.Text == activeTabText ? FlatStyle.Standard : FlatStyle.Flat;
            }
        }

        private void OpenTab(string tabName)
        {
            // Create the view for the tab
            Control newView = CreateTabView(tabName);

            // Add a new button for the tab and show the view
            Button tabButton = AddViewButton(tabName, () => newView);

            // Activate the tab and set it as active
            tabButton.PerformClick();
        }

        // Create the corresponding view based on the tab name
        private Control CreateTabView(string tabName)
        {
            if (tabName == Locales.Strings.tt_btnSettings) // Settings tab
                return new SettingsView();

            if (tabName == Locales.Strings.tt_btnLogger) // Logger tab
                return CreateLoggerView();

            if (tabName == Locales.Strings.tt_btnPlugins) // Plugins tab
                return new PluginsView();

            if (tabName == Locales.Strings.ctl_btnDumputer) // Apps tab
                return new AppsView();

            if (tabName == Locales.Strings.ctl_btnExperience) // Experience tab
                return new ExperienceView();

            throw new ArgumentException($"Unknown tab: {tabName}"); // Unknown tab
        }

        // Adds a button for the given tab
        private Button AddViewButton(string text, Func<Control> viewFactory)
        {
            // Check if the button already exists and return it if it does
            Button existingButton = buttonPanel.Controls.OfType<Button>().FirstOrDefault(b => b.Text == text);
            if (existingButton != null)
            {
                // Make the button visible if it already exists
                existingButton.Visible = true;
                return existingButton;
            }

            // Create a new button if it doesn't exist
            Button button = CreateButton(text);
            button.Click += (s, e) =>
            {
                Control view = viewFactory();
                if (view != null)
                {
                    ShowView(view);     // Show the view when the button is clicked
                    SetActiveTab(text); // Mark the clicked button as active
                }
            };

            // Add the button to the FlowLayoutPanel
            buttonPanel.Controls.Add(button);

            // Add a Close button to the tab
            AddCloseButton(button);

            return button;
        }

        // Create the Close (X) button with a black X symbol
        private void AddCloseButton(Button button)
        {
            var closeButton = new Button
            {
                Text = "\uE711",
                Size = new Size(20, 25),
                Font = new Font("Segoe MDL2 Assets", 9),
                ForeColor = Color.Gray,
                FlatStyle = FlatStyle.Flat,
                AutoSize = true,
                Dock = DockStyle.Right
            };
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Click += (s, e) =>
            {
                buttonPanel.Controls.Remove(button);
                buttonPanel.Controls.Remove(closeButton);
                ShowMainContent();
            };

            buttonPanel.Controls.Add(closeButton);
        }

        private void ShowView(Control view)
        {
            // Clear previous views from the panelContainer
            panelContainer.Controls.Clear();

            // Add the new view to the panel
            panelContainer.Controls.Add(view);
            view.Dock = DockStyle.Fill;
            view.BringToFront();
        }

        // Creates a button for the FlowLayoutPanel
        private Button CreateButton(string text)
        {
            return new Button
            {
                Text = text,
                Size = new Size(150, 30),
                AutoSize = true,
                Padding = new Padding(0),
                Margin = new Padding(0),
                TabStop = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI Variable Small", 8.75f),
            };
        }

        // Plugin Store always visible with special formatting
        private Button CreateStoreButton(string text)
        {
            Button button = new Button
            {
                Text = "Store",
                Font = new Font("Segoe UI Variable Small", 8.0f, FontStyle.Bold),
                Size = new Size(50, 30),
                AutoSize = true,
                Padding = new Padding(0),
                Margin = new Padding(0),
                TabStop = false,
            };

            return button;
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

        // Plugin Store content
        public void ShowPluginStore()
        {
            if (storeView == null) storeView = new StoreView(new PluginsView());
            SetActiveTab("Store");
            ShowView(storeView);
        }

        private LoggerView CreateLoggerView()
        {
            var loggerView = new LoggerView();
            Logger.SetLoggerView(loggerView);
            return loggerView;
        }

        // Open the LoggerView if requested (here in PluginsReview to show Plugin Execution logs)
        public void OpenLoggerView()
        {
            string loggerTabName = Locales.Strings.tt_btnLogger;

            // Check if a button for the Logger tab already exists in the button panel
            var existingButton = buttonPanel.Controls.OfType<Button>().FirstOrDefault(b => b.Text == loggerTabName);

            // If the button doesn't exist, create it and add it to the panel
            if (existingButton == null)
            {
                AddViewButton(loggerTabName, () => CreateLoggerView()); // Add a new button for the Logger tab and associate the Logger view

                // Show LoggerView
               ShowView(CreateLoggerView());
               SetActiveTab(loggerTabName);
            }
            else
            {
                // If the button already exists, simply perform a click on it to show the view
                existingButton.PerformClick();
            }
        }
    }
}