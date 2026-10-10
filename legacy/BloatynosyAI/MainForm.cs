using Interop;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;
using Walks;

namespace BloatynosyAI
{
    public partial class MainForm : Form
    {
        private Point mouseDownLocation;
        private int selectedButtonIndex = -1; // Initialize clippyLogicHandler with an invalid index

        public WebView2 WebView => webView;
        private ClippyConversationHandler clippyConversationHandler;
        private ClippyLogicHandler clippyLogicHandler;
        private List<WalksBase> systemDashboard;
        public Control INavPage;

        public MainForm()
        {
            InitializeComponent();

            // Set default NavPage
            Views.SwitchView.INavPage = pnlForm.Controls[0];
            Views.SwitchView.mainForm = this;
        }

        private void SetUI()
        {
            panelTitlebar.BackColor = Color.FromArgb(243, 243, 243);
            // Segoe MDL2 Assets
            buttonBack.Text = "\uE72B";
            buttonClose.Text = "\uE8BB";
            buttonMinimize.Text = "\uE921";
            buttonSettings.Text = "\uE713";

            // Position
            int margin = 10; // Margin from Taskbar
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) - margin);
        }

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            // Position
            SetUI();

            await InitializeWebView();
        }

        private async Task InitializeWebView()
        {
            Panel pnlForm = new Panel
            {
                Dock = DockStyle.Fill,
                Parent = pnlMain,
            };

            webView = new WebView2
            {
                Dock = DockStyle.Fill,
                Parent = pnlForm,
            };

            await webView.EnsureCoreWebView2Async(null);

            webView.CoreWebView2.WebMessageReceived += (sender, e) =>
            {
                var message = e.TryGetWebMessageAsString();
                UpdateCheckboxState(message);
            };

            await LoadHtmlContent();

            // Attach event handler to open links in default system browser
            webView.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private async Task LoadHtmlContent()
        {
            try
            {
                // Construct the full file paths for HTML, CSS, JS files
                string htmlFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "frontend.html");
                string cssFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "ui.css");
                string jsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app", "backend.js");

                // Get all PNG files with "clippy" in their names
                string[] clippyImagePaths = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "app"), "*clippy*.png");

                // Check if any clippy images were found
                if (clippyImagePaths.Length == 0)
                {
                    Console.WriteLine("No clippy images found.");
                    return;
                }

                // Select a random clippy image
                Random random = new Random();
                string randomClippyImagePath = clippyImagePaths[random.Next(clippyImagePaths.Length)];

                async Task<string> ReadFileAsync(string filePath)
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        return await reader.ReadToEndAsync();
                    }
                }

                string htmlContent = await ReadFileAsync(htmlFilePath);
                string cssContent = await ReadFileAsync(cssFilePath);
                string jsContent = await ReadFileAsync(jsFilePath);

                // Read the image file as bytes
                byte[] imageBytes = File.ReadAllBytes(randomClippyImagePath);

                // Convert the image bytes to a base64 string
                string base64Image = Convert.ToBase64String(imageBytes);

                // Replace the placeholder with the image tag
                StringBuilder finalHtmlContentBuilder = new StringBuilder(htmlContent);
                finalHtmlContentBuilder.Replace("</head>", $"<style>{cssContent}</style><script>{jsContent}</script></head>");
                finalHtmlContentBuilder.Replace("<div id=\"clippy-container\">", $"<div id=\"clippy-container\"><img src=\"data:image/png;base64,{base64Image}\" alt=\"Microsoft Clippy\">");

                string finalHtmlContent = finalHtmlContentBuilder.ToString();

                // Subscribe to NavigationCompleted event before navigating
                webView.CoreWebView2.NavigationCompleted += WebView_NavigationCompleted;

                // Navigate to the modified HTML content
                webView.CoreWebView2.NavigateToString(finalHtmlContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading frontend: {ex.Message}");
            }
        }


        private async void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Unsubscribe from event to avoid handling it multiple times
            webView.CoreWebView2.NavigationCompleted -= WebView_NavigationCompleted;

            // Initialize global fields
            Logger logger = new Logger(webView);
            AppxPackages appxPackages = new AppxPackages(this, logger);
            clippyLogicHandler = new ClippyLogicHandler(this, logger);

            // Load Privacy and system dashboard
            InitializeDashboard();

            // Load installed appx packages
            await appxPackages.LoadInstalledAppPackages();

            // Load static AI Data
            await clippyLogicHandler.LoadAnswersFromJson();  // Initialize answers and actions
            await clippyLogicHandler.LoadButtonsFromJson();  // Random buttons
            await clippyLogicHandler.LoadChatboxQuestions(); // Chatbox autocomplete

            // Add static Clippy sayings
            clippyConversationHandler = new ClippyConversationHandler(this, new Logger(webView));
            clippyConversationHandler.ShowAISayings();

            // DEBUG: Open DevTools
            //webView.CoreWebView2.OpenDevToolsWindow();
        }

        // Open new window request in default system browser
        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Uri,
                UseShellExecute = true
            });

            // Cancel new window request within WebView2
            e.Handled = true;
        }

        // Privacy and system Dashboard
        private void InitializeDashboard()
        {
            var logger = new Logger(webView);
            systemDashboard = new List<WalksBase>
            {
                new Advertising(this,logger),
                new TipsAndSuggestions(this,logger),
                new FindMyDevice(this,logger),
                new DiagnosticData(this,logger),
                new Telemetry(this,logger),
                new LockScreen(this,logger),
                new VerboseMessages(this,logger),
                new PrivacyExperience(this,logger),
                new BingSearch(this,logger),
                new VisualFX(this,logger),
                new GameDVR(this,logger),
                new PowerThrottling(this,logger),
            };
        }

        private void UpdateCheckboxState(string message)
        {
            // Add static Clippy Tips
            clippyConversationHandler = new ClippyConversationHandler(this, new Logger(webView));
            clippyConversationHandler.Execute();

            try
            {
                // Log received message for debugging
                //Console.WriteLine($"Received message: {message}");

                // Check if message is a valid JSON format
                if (message.StartsWith("{") && message.EndsWith("}"))
                {
                    var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(message);

                    // Log deserialized data for debugging
                    // Console.WriteLine($"Deserialized data: {Newtonsoft.Json.JsonConvert.SerializeObject(data)}");

                    // Remove selected AppxPackages
                    if (data.ContainsKey("action") && data["action"].ToString() == "removeSelectedPackages")
                    {
                        AppxPackages appxPackages = new AppxPackages(this, new Logger(webView));
                        appxPackages.HandleRemoveSelectedPackages(message, appxPackages);
                    }

                    // Check if JSON data contains expected properties
                    if (data.ContainsKey("action") && data.ContainsKey("checkboxes"))
                    {
                        var action = data["action"].ToString();
                        var checkboxes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CheckboxInfo>>(data["checkboxes"].ToString());

                        // Log checkboxes for debugging
                        // Console.WriteLine($"Checkboxes: {Newtonsoft.Json.JsonConvert.SerializeObject(checkboxes)}");

                        // Handle button click events
                        // Privcy Dashboard
                        if (action == "search") // Button Check my Windows Setup
                        {
                            SearchAction();
                        }
                        else if (action == "enable") // Allow
                        {
                            EnableAction(checkboxes);
                        }
                        else if (action == "disable") // Deny
                        {
                            DisableAction(checkboxes);
                        }
                        if (action == "installSelectedApps")  // App Installer
                        {
                            InstallWingetAppsAction(checkboxes);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: Invalid JSON format. Missing required properties.");
                        Console.WriteLine($"Message content: {message}");
                    }
                }
                else
                {
                    // Handle non-JSON content (e.g. Walks classes for opening URI/Settings pages, checking updates etc.)
                    HandleNonJsonMessage(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
                Console.WriteLine($"Message content: {message}");
            }
        }

        // Avoid trying to deserialize non-JSON content: If message is not a valid JSON format, it will be treated as a non-JSON message
        // e.g.  the message content is just the string "openUpdateSettings", which is not a valid JSON format
        private async void HandleNonJsonMessage(string message)
        {
            Logger logger = new Logger(webView);

            // Instantiate Feature classes with logger
            InteropBase updateSettings = new UpdateSettings(this, logger);
            WalksBase appCustomCrapware = new CAppxPackages(this, logger);

            // Handle non-JSON content (e.g., interop classes)
            switch (message)
            {

                // Refresh button
                case "refreshWebView2":
                    await LoadHtmlContent();
                    break;

                // Some static buttons
                case "openUpdateSettings":
                    updateSettings.Execute();
                    break;

                // Appx Uninstaller
                case "searchCustomCrapware":
                    appCustomCrapware.Check();
                    break;

                case "removeCustomCrapware":
                    appCustomCrapware.Enable();
                    break;

                // How may I further assist you?
                // Assisted Buttons
                case var msg when msg.StartsWith("showAnswerForButtons:"):
                    if (int.TryParse(msg.Split(':')[1], out selectedButtonIndex))
                    {
                        // logger.Log($"Selected button index: {selectedButtonIndex}", Color.Green);
                        clippyLogicHandler.ShowAnswerForButtons(selectedButtonIndex);
                    }
                    else
                    {
                        logger.Log("Invalid dropdown index format.", Color.Red);
                    }
                    break;

                // Assited Chatbox which handle autocomplete-related messages
                case var msg when msg.StartsWith("showAnswerForChatbox:"):
                    string selectedQuestion = msg.Split(':')[1];
                    clippyLogicHandler.ShowAnswerForChatbox(selectedQuestion);
                    break;

                default:
                    MessageBox.Show($"Unhandled non-JSON message: {message}");
                    break;
            }
        }

        // App Installer
        private void InstallWingetAppsAction(List<CheckboxInfo> checkboxes)
        {
            Logger logger = new Logger(webView);

            foreach (var checkbox in checkboxes)
            {
                // Update IsChecked property based on Checked property
                checkbox.IsChecked = checkbox.Checked;

                // Check if the checkbox is selected using the IsChecked property
                if (checkbox.IsChecked)
                {
                    // Instantiate AppPackages class with logger and execute installation
                    InteropBase AppPackages = new AppPackages(this, logger, checkbox.Id, checkbox.WingetId);
                    AppPackages.Execute();
                }
            }
        }

        // Privacy Dashboard > Check
        private void SearchAction()
        {
            try
            {
                var searchResults = new List<CheckboxInfo>();

                foreach (var dashboardClass in systemDashboard)
                {
                    bool isInstalled = dashboardClass.Check();
                    searchResults.Add(new CheckboxInfo { Id = dashboardClass.ID(), Checked = isInstalled });
                    UpdateCheckboxStatus(dashboardClass.ID(), isInstalled);
                }

                // Convert searchResults to JSON and send it to JS
                var jsonResults = JsonConvert.SerializeObject(searchResults);
                webView.CoreWebView2.ExecuteScriptAsync($"searchResults({jsonResults});");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during SearchAction: " + ex.Message);
            }
        }

        // Privacy Dashboard > Apply
        private void EnableAction(List<CheckboxInfo> checkboxes)
        {
            foreach (var checkboxInfo in checkboxes)
            {
                var dashboardClass = systemDashboard.FirstOrDefault(tc => tc.ID() == checkboxInfo.Id);

                if (dashboardClass != null && checkboxInfo.Checked)
                {
                    dashboardClass.Enable();
                }
            }
        }

        // Privacy Dashboard > Deny
        private void DisableAction(List<CheckboxInfo> checkboxes)
        {
            foreach (var checkboxInfo in checkboxes)
            {
                var dashboardClass = systemDashboard.FirstOrDefault(tc => tc.ID() == checkboxInfo.Id);

                if (dashboardClass != null && checkboxInfo.Checked)
                {
                    dashboardClass.Disable();
                }
            }
        }

        // Privacy Dashboard > Helper method to update toogle switch status
        private void UpdateCheckboxStatus(string id, bool isChecked)
        {
            var script = $"document.getElementById('{id}').checked = {isChecked.ToString().ToLower()};";
            script += $"updateLog('{id}', {isChecked.ToString().ToLower()});";

            // Append the log directly to the logContainer in the WebView
            // script += $"document.getElementById('logContainer').innerHTML += '{(isChecked ? "Enabled" : "Disabled")} - Feature ID {id}<br>';";

            webView.CoreWebView2.ExecuteScriptAsync(script);
        }

        // Toggle Switch/Checkbox information
        private class CheckboxInfo
        {
            public string Id { get; set; }
            public bool Checked { get; set; }
            public string WingetId { get; set; }
            public bool IsChecked { get; set; }
            public string CrapId { get; set; }
        }

        private async void Back_Click(object sender, EventArgs e)
        {
            await LoadHtmlContent();
        }

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void panelTitlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseDownLocation.X;
                this.Top += e.Y - mouseDownLocation.Y;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void buttonBack_Click(object sender, EventArgs e)
        {
            Views.SwitchView.SetMainFormAsView();
            await LoadHtmlContent();

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Views.SwitchView.SetView(new SettingsPageView());
        }

        private void linkTitlebar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/builtbybel/BloatynosyAI");
        }
    }
}