using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloatynosy.Views
{
    public partial class AppsView : UserControl
    {
        private Logger logger;

        private List<AppInfo> appxPackages = new List<AppInfo>();
        private List<AppInfo> displayedApps = new List<AppInfo>();
        private List<FilterDefinition> filters = new List<FilterDefinition>();

        public class FilterDefinition
        {
            public string Name { get; set; }
            public List<string> Criteria { get; set; }
        }

        public class FiltersContainer
        {
            public List<FilterDefinition> Filters { get; set; }
        }

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
            DarkModeManager.ApplyDarkMode(this);
            InitializeLogger();
            UpdateRemovalListPlaceholder();
            InitializeLocalizedStrings();
            LoadAppxPackages();
            InitializeFilterOptions();

            btnAdd.Text = "\uE710";
            btnRemove.Text = "\uE738";
            btnRefresh.Text = "\ue72c";
            btnClosePaneMirrored.Text = "\uEA49";
            btnFilter.Text = "\uE71C";
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            // Check if required dependencies are available
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", "AppMatrix.json");

            string newtonsoftJsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Newtonsoft.Json.dll");
            bool isJsonAvailable = File.Exists(newtonsoftJsonPath);
            bool isAppMatrixAvailable = File.Exists(jsonPath);

            if (!isJsonAvailable || !isAppMatrixAvailable)
            {
                string message =
                    "Some dependencies are missing, which disables the Community Bloatware filter feature:\n\n" +
                    $"{(isJsonAvailable ? "✔" : "✘")} Newtonsoft.Json (Part of Plugin Engine): Please install it by clicking the store link and enabling it.\n" +
                    $"{(isAppMatrixAvailable ? "✔" : "✘")} AppMatrix.json (Available for download in the Plugin Store): Intelligent Bloatware Filters, curated with the power of AI.\n\n" +
                    "All other features of the apps debloater module will still function.";

                MessageBox.Show(message,
                                "Missing Dependencies",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                return;
            }

            LoadFilters();
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
            textDetails.Text = Locales.Strings.formDumputer_ctl_lblDetails;
            textBoxSearch.Text = Locales.Strings.formDumputer_ctl_textBoxSearch;
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
                    lblStatus.Text = Locales.Strings.formDumputer_status_Loading;
                    logger.Log(Locales.Strings.formDumputer_status_Loading, Color.White);
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
                    lblStatus.Text = $"{Locales.Strings.formDumputer_status_countPackages} {appxPackages.Count}";
                    logger.Log($"{Locales.Strings.formDumputer_status_countPackages} {appxPackages.Count}", Color.Green);

                    // Apply the selected filter after loading the apps
                    if (comboBoxFilters.SelectedItem != null)
                    {
                        ApplyFilter(comboBoxFilters.SelectedItem.ToString());
                    }
                }));
            });
        }

        private void LoadFilters()
        {
            string filterFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins", "AppMatrix.json");

            if (File.Exists(filterFilePath))
            {
                try
                {
                    string jsonContent = File.ReadAllText(filterFilePath);

                    // Deserialize the JSON content into FiltersContainer to match the JSON structure
                    var filtersContainer = JsonConvert.DeserializeObject<FiltersContainer>(jsonContent);

                    if (filtersContainer != null)
                    {
                        filters = filtersContainer.Filters;
                    }
                    else
                    {
                        MessageBox.Show("No filters found in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading filters: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Filter definitions not found. Please ensure 'AppMatrix.json' exists in the application directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeFilterOptions()
        {
            comboBoxFilters.Items.Clear();

            // Add the "All apps" filter manually
            comboBoxFilters.Items.Add("All apps");

            // Add the filters from the loaded filter definitions
            foreach (var filter in filters)
            {
                comboBoxFilters.Items.Add(filter.Name);
            }

            // Set the default filter to "All apps"
            comboBoxFilters.SelectedIndex = 0;

            comboBoxFilters.SelectedIndexChanged += FilterChanged;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            if (comboBoxFilters.SelectedItem is string selectedFilterName)
            {
                ApplyFilter(selectedFilterName);
            }
        }

        private void ApplyFilter(string filterName)
        {
            // If the "All apps" filter is selected, display all apps
            if (filterName == "All apps")
            {
                displayedApps = new List<AppInfo>(appxPackages);  // Store all apps in displayedApps
            }
            else
            {
                var selectedFilter = filters.FirstOrDefault(f => f.Name == filterName);
                if (selectedFilter != null && selectedFilter.Criteria != null && selectedFilter.Criteria.Any())
                {
                    displayedApps = appxPackages.Where(app =>
                        selectedFilter.Criteria.Any(criteria =>
                            app.Name.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();  // Filter and store in displayedApps
                }
            }

            // Display the filtered apps
            DisplayApps(displayedApps);
        }

        private void DisplayApps(List<AppInfo> apps)
        {
            listBoxApps.Items.Clear();
            foreach (var app in apps)
            {
                listBoxApps.Items.Add(app);  // Add the AppInfo object and not the string
            }
        }

        // Uninstall a single app
        private async Task RemoveApp(AppInfo app)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    // Attempting to remove
                    lblStatus.Text = $"{Locales.Strings.formDumputer_status_Removing} {app.Name}...\r\n";
                    logger.Log($"{Locales.Strings.formDumputer_status_Removing} {app.Name}...", Color.White);
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
                            logger.Log(output, Color.White);
                        }));
                    }

                    string errorOutput = await process.StandardError.ReadToEndAsync();
                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        Invoke(new Action(() =>
                        {
                            // lblStatus.AppendText($"Error: {errorOutput}\r\n");
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
                        logger.Log($"{Locales.Strings.formDumputer_status_successRemove} {app.Name}", Color.Green);
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    // Error removing
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

            // Search within the displayed apps
            var searchResults = displayedApps.Where(app => app.Name.ToLower().Contains(searchText)).ToList();

            // Display the search results
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

        // Move selected apps from listBoxApps to listBoxRemoval
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedApps = listBoxApps.SelectedItems.Cast<AppInfo>().ToList();
            foreach (var app in selectedApps)
            {
                if (!listBoxRemoval.Items.Contains(app))
                {
                    listBoxRemoval.Items.Add(app); // Add the AppInfo object
                }
                listBoxApps.Items.Remove(app);  // Remove the AppInfo object
            }
            UpdateRemovalListPlaceholder();
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
            UpdateRemovalListPlaceholder();
        }

        // Refresh the list of Appx packages
        private void RefreshAppList()
        {
            Invoke(new Action(() =>
            {
                // Refreshing app list...
                lblStatus.Text = Locales.Strings.formDumputer_status_Refreshing;
            }));
            LoadAppxPackages();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshAppList();
        }

        private void btnClosePaneMirrored_Click(object sender, EventArgs e)
        {
            if (splitContainer.Panel2Collapsed)
            {
                splitContainer.Panel2Collapsed = false;
            }
            else
            {
                splitContainer.Panel2Collapsed = true;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilters.Visible = !comboBoxFilters.Visible;
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