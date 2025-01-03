using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views;

namespace BloatynosyNue.Views
{
    public partial class AppsView : UserControl
    {
        private List<AppInfo> appxPackages = new List<AppInfo>();
        private List<AppInfo> filteredApps = new List<AppInfo>();
        private Logger logger;

        public class AppInfo
        {
            public string PackageFullName { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name ?? PackageFullName;
            }
        }

        public AppsView()
        {
            InitializeComponent();
            InitializeLogger();
            UpdateRemovalListPlaceholder();
            InitializeLocalizedStrings();

            btnAdd.Text = "\uE710";
            btnRemove.Text = "\uE738";
            btnRefresh.Text = "\ue72c";
            btnCollapse.Text = "\uEA5B";
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            LoadAppxPackages();
            InitializeFilterOptions();
        }

        private void InitializeLogger()
        {
            logger = new Logger();
            logger.Log("AppsView initialized.", Color.Green);
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = Locales.Strings.formDumputer_ctl_lblHeader;
            lblSubHeader.Text = Locales.Strings.formDumputer_ctl_lblSubHeader;
            textDetails.Text = Locales.Strings.formDumputer_ctl_lblDetails;
            textBoxSearch.Text = Locales.Strings.formDumputer_ctl_textBoxSearch;
            lblSort.Text = Locales.Strings.formDumputer_ctl_lblSort;
            btnUninstall.Text = Locales.Strings.formDumputer_ctl_btnUninstall;

            toolTip.SetToolTip(btnAdd, Locales.Strings.formDumputer_tt_btnAdd);
            toolTip.SetToolTip(btnRemove, Locales.Strings.formDumputer_tt_btnRemove);
            toolTip.SetToolTip(btnRefresh, Locales.Strings.formDumputer_tt_btnRefresh);

        }

        // Load all installed Appx packages
        private void LoadAppxPackages()
        {
            Task.Run(() =>
            {       // Clear any previous data
                appxPackages.Clear();

                Invoke(new Action(() =>
                {
                    // Loading appx packages...
                    textStatus.AppendText(Locales.Strings.formDumputer_status_Loading);
                    logger.Log(Locales.Strings.formDumputer_status_Loading, Color.Black);
                }));

                // PowerShell command to fetch app names only
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = "Get-AppxPackage | Select-Object -Property Name | Format-Table -HideTableHeaders",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    string output;
                    while ((output = process.StandardOutput.ReadLine()) != null)
                    {                   // Only split based on spaces and take the first part (the app name)
                        var parts = output.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length >= 1)
                        {
                            var appInfo = new AppInfo
                            {
                                Name = parts[0]
                            };

                            appxPackages.Add(appInfo);
                        }
                    }
                    process.WaitForExit();
                }

                // After loading is done, update the status and apply the selected filter
                Invoke(new Action(() =>
                {
                    // App packages loaded:
                    textStatus.Text = $"{Locales.Strings.formDumputer_status_countPackages} {appxPackages.Count}";
                    logger.Log($"{Locales.Strings.formDumputer_status_countPackages} {appxPackages.Count}", Color.Green);

                    // Apply the selected filter after loading the apps
                    if (comboBoxFilters.SelectedItem != null)
                    {
                        ApplyFilter(comboBoxFilters.SelectedItem.ToString());
                    }
                }));
            });
        }

        // Initialize the filter options in dropdown
        private void InitializeFilterOptions()
        {
            // Populate filter options
            comboBoxFilters.Items.AddRange(new string[]
            {
                "All Apps",
                "Most Annoying Bloatware",
                "Microsoft Apps",
                "Social Media Apps",
                "Games",
                "Video Streaming Apps",
                "Productivity Tools",
                "News and Media Apps",
                "Shopping Apps"
            });

            // Set default filter to All Apps
            comboBoxFilters.SelectedIndex = 0;
            comboBoxFilters.SelectedIndexChanged += FilterChanged;
        }

        // Handle filter changes when a user selects a different category
        private void FilterChanged(object sender, EventArgs e)
        {
            ApplyFilter(comboBoxFilters.SelectedItem.ToString());
        }

        // Display the list of apps in the left ListBox
        private void DisplayApps(List<AppInfo> apps)
        {
            listBoxApps.Items.Clear();
            foreach (var app in apps)
            {
                listBoxApps.Items.Add(app);
            }
        }

        // Apply the selected filter to show only relevant apps
        private void ApplyFilter(string filter)
        {
            filteredApps.Clear();
            switch (filter)
            {
                case "All Apps":
                    filteredApps.AddRange(appxPackages);
                    break;

                case "Most Annoying Bloatware":
                    filteredApps.AddRange(appxPackages.Where(app =>
                        app.Name.IndexOf("Copilot", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Candy", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Instagram", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Twitter", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("TikTok", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Xbox", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Spotify", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("YourPhone", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("BubbleWitch", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Solitaire", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Minecraft", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("FeedbackHub", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Skype", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("News", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("OneNote", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Tips", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("3DViewer", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Paint3D", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("MixedReality", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Maps", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Weather", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Groove", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Movies", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Cortana", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Teams", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("People", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Xbox Live", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("GetHelp", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Mail", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Calendar", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("News", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("ContactSupport", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("GamePass", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("ToDo", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Hulu", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Picsart", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Adobe", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("Clipchamp", StringComparison.OrdinalIgnoreCase) >= 0 ||
                        app.Name.IndexOf("DevHome", StringComparison.OrdinalIgnoreCase) >= 0));

                    break;

                case "Microsoft Apps":
                    filteredApps.AddRange(appxPackages.Where(app => app.Name.StartsWith("Microsoft", StringComparison.OrdinalIgnoreCase) ||
                                                                    app.Name.IndexOf("OneDrive", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Edge", StringComparison.OrdinalIgnoreCase) >= 0));
                    break;

                case "Social Media Apps":
                    filteredApps.AddRange(appxPackages.Where(app => app.Name.IndexOf("Facebook", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Instagram", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Twitter", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Snapchat", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("TikTok", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("LinkedIn", StringComparison.OrdinalIgnoreCase) >= 0));
                    break;

                case "Games":
                    filteredApps.AddRange(appxPackages.Where(app => app.Name.IndexOf("Solitaire", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Minecraft", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Roblox", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Forza", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("SeaOfThieves", StringComparison.OrdinalIgnoreCase) >= 0));
                    break;

                case "Video Streaming Apps":
                    filteredApps.AddRange(appxPackages.Where(app => app.Name.IndexOf("Netflix", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Hulu", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("PrimeVideo", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Disney", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("YouTube", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("AppleTV", StringComparison.OrdinalIgnoreCase) >= 0));
                    break;

                case "Productivity Tools":
                    filteredApps.AddRange(appxPackages.Where(app => app.Name.IndexOf("Office", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Teams", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Evernote", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Trello", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("OneNote", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Notion", StringComparison.OrdinalIgnoreCase) >= 0));
                    break;

                case "News and Media Apps":
                    filteredApps.AddRange(appxPackages.Where(app => app.Name.IndexOf("News", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("CNN", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("BBC", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Fox", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("NYTimes", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Reddit", StringComparison.OrdinalIgnoreCase) >= 0));
                    break;

                case "Shopping Apps":
                    filteredApps.AddRange(appxPackages.Where(app => app.Name.IndexOf("Amazon", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("eBay", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Walmart", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("AliExpress", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Wish", StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                                    app.Name.IndexOf("Etsy", StringComparison.OrdinalIgnoreCase) >= 0));
                    break;
            }

            // Display the filtered apps
            DisplayApps(filteredApps);
        }

        // Uninstall a single app
        private async Task RemoveApp(AppInfo app)
        {
            try
            {
                Invoke(new Action(() =>
                {

                    // Attempting to remove
                    textStatus.AppendText($"{Locales.Strings.formDumputer_status_Removing} {app.Name}...\r\n");
                    logger.Log($"{Locales.Strings.formDumputer_status_Removing} {app.Name}...", Color.Black);
                }));

                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"Get-AppxPackage -Name {app.Name} | Remove-AppxPackage",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();

                    string output = await process.StandardOutput.ReadToEndAsync();
                    if (!string.IsNullOrEmpty(output))
                    {
                        Invoke(new Action(() =>
                        {
                            textStatus.AppendText($"Output: {output}\r\n");
                            logger.Log(output, Color.Black);
                        }));
                    }

                    string errorOutput = await process.StandardError.ReadToEndAsync();
                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        Invoke(new Action(() =>
                        {
                            textStatus.AppendText($"Error: {errorOutput}\r\n");
                            logger.Log(errorOutput, Color.Red);

                            MessageBox.Show(
                                $"The app \"{app.Name}\" could not be removed. Check the notifications center for details.",
                                "App Removal Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }));

                        return;
                    }

                    await process.WaitForExitAsync();

                    Invoke(new Action(() =>
                    {
                        // Successfully removed
                        textStatus.AppendText($"{Locales.Strings.formDumputer_status_successRemove} {app.Name}\r\n");
                        logger.Log($"{Locales.Strings.formDumputer_status_successRemove} {app.Name}", Color.Green);
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    // Error removing 
                    textStatus.AppendText($"{Locales.Strings.formDumputer_status_failedRemove} {app.Name}: {ex.Message}\r\n");
                    logger.Log($"{Locales.Strings.formDumputer_status_failedRemove} {app.Name}: {ex.Message}", Color.Red);

                    MessageBox.Show(
                        $"An error occurred while removing \"{app.Name}\". Check the notifications center for details.",
                        "Unexpected Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }));
            }
        }

        // Uninstall all apps in listBoxRemoval
        private async void btnUninstall_Click(object sender, EventArgs e)
        {
            // Try to convert all items in listBoxRemoval to AppInfo objects and check the type
            var appsToRemove = listBoxRemoval.Items.Cast<object>()
                                                  .Where(item => item is AppInfo)
                                                  .Cast<AppInfo>()
                                                  .ToList();

            if (!appsToRemove.Any())
            {
                MessageBox.Show("No valid apps selected for uninstallation.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // If there are apps in the list, proceed with uninstallation
            foreach (var app in appsToRemove)
            {
                await RemoveApp(app);
                listBoxRemoval.Items.Remove(app);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();
            var searchResults = filteredApps.Where(app => app.Name.ToLower().Contains(searchText)).ToList();
            DisplayApps(searchResults);
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void listBoxApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxApps.SelectedItem is AppInfo selectedApp)
            {
                Task.Run(() =>
                {
                    var processStartInfo = new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = $"Get-AppxPackage -Name {selectedApp.Name} | Select-Object -Property *",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (var process = new Process { StartInfo = processStartInfo })
                    {
                        process.Start();
                        string details = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();

                        // Show app details
                        Invoke(new Action(() =>
                        {
                            if (!string.IsNullOrWhiteSpace(details))
                            {
                                textDetails.Text = details;
                            }
                            else
                            {
                                textDetails.Text = $"No additional information found for {selectedApp.Name}.";
                            }
                        }));
                    }
                });
            }
        }

        private void UpdateRemovalListPlaceholder()
        {
            if (listBoxRemoval.Items.Count == 0)
            {
                // No items in the trash yet
                listBoxRemoval.Items.Add(Locales.Strings.formDumputer_status_noItems);
            }
            else if (listBoxRemoval.Items.Contains(Locales.Strings.formDumputer_status_noItems))
            {
                listBoxRemoval.Items.Remove(Locales.Strings.formDumputer_status_noItems);
            }
        }

        // Move selected apps back from listBoxRemoval to listBoxApps
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedApps = listBoxRemoval.SelectedItems.Cast<AppInfo>().ToList();
            foreach (var app in selectedApps)
            {
                if (!listBoxApps.Items.Contains(app))
                {
                    listBoxApps.Items.Add(app);
                }
                listBoxRemoval.Items.Remove(app);
            }

            // Update placeholder
            UpdateRemovalListPlaceholder();
        }

        // Move selected apps from listBoxApps to listBoxRemoval
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedApps = listBoxApps.SelectedItems.Cast<AppInfo>().ToList();
            foreach (var app in selectedApps)
            {
                if (!listBoxRemoval.Items.Contains(app))
                {
                    listBoxRemoval.Items.Add(app);
                }
                listBoxApps.Items.Remove(app);
            }

            // Update placeholder
            UpdateRemovalListPlaceholder();
        }

        // Refresh the list of Appx packages
        private void RefreshAppList()
        {
            Invoke(new Action(() =>
            {
                // Refreshing app list...
                textStatus.Text = Locales.Strings.formDumputer_status_Refreshing;
            }));
            LoadAppxPackages();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAppList();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer.Panel2Collapsed)
            {
                // Panel2 einblenden
                splitContainer.Panel2Collapsed = false;
            }
            else
            {
                // Panel2 ausblenden
                splitContainer.Panel2Collapsed = true;
            }
        }
    }
}

public static class ProcessExtensions
{
    public static async Task WaitForExitAsync(this Process process)
    {
        var tcs = new TaskCompletionSource<bool>();
        process.EnableRaisingEvents = true;
        process.Exited += (sender, args) => tcs.TrySetResult(true);
        await tcs.Task;
    }
}