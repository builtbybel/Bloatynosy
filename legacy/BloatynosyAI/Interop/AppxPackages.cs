using BloatynosyAI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace Interop
{
    public class AppxPackages : InteropBase
    {
        private MainForm form;

        public AppxPackages(MainForm form, Logger logger) : base(form, logger)
        {
            this.form = form;
        }

        public override void Execute()
        {
            // Just abstraction
        }

        public async Task LoadInstalledAppPackages()
        {
            // Get list of installed app packages asynchronously
            List<string> installedPackages = await GetInstalledAppPackages();

            // Log number of installed packages for verification
            //Logger.Log($"Number of Installed Packages: {installedPackages.Count}", Color.Green);

            // Update the count in the WebView2 control
            await form.WebView.CoreWebView2.ExecuteScriptAsync($"document.getElementById('installedPackagesCount').innerText = ' ({installedPackages.Count})';");

            // Build HTML content for toggle switches
            string htmlContent = BuildToggleSwitchesHtml(installedPackages);

            // Inject HTML content into WebView2 control and update it
            await form.WebView.CoreWebView2.ExecuteScriptAsync($"document.getElementById('appPackagesContainer').innerHTML = `{htmlContent}`;");
        }

        public async Task<string> GetPinnedAppPackages()
        {
            // Load installed app packages asynchronously
            await LoadInstalledAppPackages();

            // Get list of installed app packages
            List<string> installedAppPackages = await GetInstalledAppPackages();

            // Keywords for Microsoft apps
            string[] microsoftKeywords = { "News", "ZuneVideo", "Music", "Office", "Skype", "OneNote",
                                   "PowerPoint", "Excel", "Word", "Outlook", "Teams", "OneDrive", "Maps",
                                   "Weather", "Alarms", "Feedback", "Messaging", "Solitaire", "StickyNotes",
                                   "Wallet", "YourPhone", "3DViewer", "Bing", "GetHelp", "LinkedIn", "Paint", "DevHome",
                                   "MixedReality", "Print3D", "Clipchamp",  };

            // Keywords for non-Microsoft apps
            string[] nonMicrosoftKeywords = { "Netflix", "Instagram", "Spotify", "Twitter", "WhatsApp",
                                      "HP", "TikTok", "Adobe", "Asana", "Google", "Facebook", "Messenger",
                                      "Candy", "Disney", "Dolby", "Duolingo", "Eclipse", "Fitbit", "Flipboard", "Fresh",
                                      "Gameloft", "Gears", "Hulu", "Google", "iHeartRadio", "iTunes", "Khan", "King",
                                      "Lenovo", "Minecraft", "Netflix", "NordVPN", "Norton", "Opera", "Pandora",
                                      "PayPal", "Plex", "Pulse", "Razer", "Samsung", "Shazam", "Snapchat",
                                      "Spotify", "Tidal", "Twitch", "Uber", "Viber", "VLC", "Waze", "Wikipedia",
                                      "Wish", "Wix", "Wordpress", "Yelp", "Zoom", "Zynga", "Amazon",
                                      "Apple",  "Corel",  "Luminar", "Photoshop", "Illustrator", "Premiere",
                                      "After", "Effects", "Lightroom", "InDesign", "Acrobat", "Soda", "Friends",
                                      "Farm", "Heroes", "Puzzle", "Quest", "Bubble", "CamoStudio", "Zoosk",
                                      "eHarmony", "Elite", "Singles", "Christian", "Grammarly",};

            // Filter the installed app packages based on substring matches with the filter
            var microsoftApps = installedAppPackages.Where(package =>
                microsoftKeywords.Any(keyword => package.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();

            var nonMicrosoftApps = installedAppPackages.Where(package =>
                nonMicrosoftKeywords.Any(keyword => package.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();

            // Combine both Microsoft and non-Microsoft apps
            var allApps = microsoftApps.Concat(nonMicrosoftApps).ToList();

            // Select up to three random app packages
            Random random = new Random();
            var randomApps = allApps.OrderBy(x => random.Next()).Take(3).ToList();

            // Build HTML buttons for the selected app packages
            var buttonsHtml = new StringBuilder();
            foreach (string package in randomApps)
            {
                buttonsHtml.AppendLine($"<div>");
                if (microsoftApps.Contains(package))
                {
                    buttonsHtml.AppendLine($"<button onclick='removeApp(\"{package}\")' style='position:relative;'>{package}<span style='position:absolute;top:0;right:0;font-size:10px;color:magenta;'>Microsoft's Preinstall Sh*t &#10060;</span></button>");
                }
                else
                {
                    buttonsHtml.AppendLine($"<button onclick='removeApp(\"{package}\")' style='position:relative;'>{package}<span style='position:absolute;top:0;right:0;font-size:10px;color:magenta;'>&#10060;</span></button>");
                }
                buttonsHtml.AppendLine($"</div>");
            }

            return buttonsHtml.ToString();
        }

        public async Task<List<string>> GetInstalledAppPackages()
        {
            try
            {
                // Use just the norma PS command to get installed app packages
                string powershellCommand = "Get-AppxPackage | Select-Object Name";

                // Execute PowerShell command asynchronously
                Collection<PSObject> PSOutput = await ExecutePowerShellCommand(powershellCommand);

                // Create a list of strings
                List<string> installedPackages = PSOutput
                    .Select(psObject => psObject.Properties["Name"]?.Value?.ToString())
                    .Where(name => !string.IsNullOrEmpty(name))
                    .ToList();

                return installedPackages;
            }
            catch (Exception ex)
            {
                Logger.Log($"Error getting installed app packages: {ex.Message}", Color.Red);
                return new List<string>();
            }
        }

        public void HandleRemoveSelectedPackages(string message, AppxPackages appCrapware)
        {
            try
            {
                // Attempt to parse the message as JSON
                if (JsonConvert.DeserializeObject(message) is JObject parsedMessage)
                {
                    // Check if JSON data contains expected properties
                    if (parsedMessage.TryGetValue("action", out var action) && parsedMessage.TryGetValue("selectedPackages", out var selectedPackagesToken))
                    {
                        // Log action and selectedPackages for debugging
                        //Console.WriteLine($"Action: {action}, SelectedPackages: {selectedPackagesToken}");

                        // Deserialize the selectedPackages directly (it should be an array)
                        List<string> selectedPackages = JsonConvert.DeserializeObject<List<string>>(selectedPackagesToken.ToString());

                        // Log to verify that the message is received and the list of packages
                        //Console.WriteLine($"Received removeSelectedPackages message with packages: {string.Join(", ", selectedPackages)}");

                        // Check if AppCrapware instance is properly initialized and not null
                        if (appCrapware != null)
                        {
                            // Implement the logic to remove or load packages
                            if (action.ToString() == "removeSelectedPackages")
                            {
                                RemoveSelectedPackages(selectedPackages);
                            }
                            /*  if (action.ToString() == "loadInstalledPackages")
                              {
                                  logger.Log("dfdf", Color.Red);
                                  LoadInstalledAppPackages();
                              } */

                            // Log success message
                            // Console.WriteLine($"Selected packages removed or loaded successfully.");
                        }
                        else
                        {
                            //Console.WriteLine("Error: AppCrapware instance is null.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
            }
        }

        private string BuildToggleSwitchesHtml(List<string> packages)
        {
            // Build HTML content for toggle switches
            var htmlBuilder = new StringBuilder();

            // Add container for app packages
            htmlBuilder.AppendLine("<div id=\"appPackagesContainer\">");

            // Add button for removing selected packages
            // htmlBuilder.AppendLine("<button onclick=\"removeSelectedPackages()\">Remove Selected</button>");

            // Add button for loading installed packages
            // htmlBuilder.AppendLine("<button onclick=\"loadInstalledPackages()\">LoadPackages</button>");

            // Add toggle switches for each app package
            foreach (var package in packages)
            {
                htmlBuilder.AppendLine("<div class=\"toggle-switch\">");
                htmlBuilder.AppendLine($"<input type=\"checkbox\" id=\"{package}\" onchange=\"updateSelectedPackages('{package}')\">");
                htmlBuilder.AppendLine($"<label for=\"{package}\">{package}</label>");
                htmlBuilder.AppendLine("</div>");
            }

            htmlBuilder.AppendLine("</div>");

            // Add CSS for toggle switches
            htmlBuilder.AppendLine("<style>");
            htmlBuilder.AppendLine(".toggle-switch {");
            htmlBuilder.AppendLine("  display: flex;");
            htmlBuilder.AppendLine("  align-items: center;");
            htmlBuilder.AppendLine("  width: 100%;");
            htmlBuilder.AppendLine("}");

            htmlBuilder.AppendLine(".toggle-switch input {");
            htmlBuilder.AppendLine("  display: none;");
            htmlBuilder.AppendLine("}");

            htmlBuilder.AppendLine(".toggle-switch label {");
            htmlBuilder.AppendLine("  cursor: pointer;");

            htmlBuilder.AppendLine("  background-color: #ccc;");
            htmlBuilder.AppendLine("  border-radius: 15px;");
            htmlBuilder.AppendLine("}");

            htmlBuilder.AppendLine(".toggle-switch input:checked + label {");
            htmlBuilder.AppendLine("  background-color: #4CAF50;");
            htmlBuilder.AppendLine("  color: #fff;");
            htmlBuilder.AppendLine("}");
            htmlBuilder.AppendLine("</style>");

            // Add JavaScript functions for updating selected packages and removing them
            htmlBuilder.AppendLine("<script>");
            htmlBuilder.AppendLine("var selectedPackages = [];");
            htmlBuilder.AppendLine("function updateSelectedPackages(packageFamilyName) {");
            htmlBuilder.AppendLine("var index = selectedPackages.indexOf(packageFamilyName);");
            htmlBuilder.AppendLine("if (index === -1) {");
            htmlBuilder.AppendLine("selectedPackages.push(packageFamilyName);");
            htmlBuilder.AppendLine("} else {");
            htmlBuilder.AppendLine("selectedPackages.splice(index, 1);");
            htmlBuilder.AppendLine("}");
            htmlBuilder.AppendLine("}");
            htmlBuilder.AppendLine("function removeSelectedPackages() {");
            // Maybe changing the following line to use window.chrome.webview.postMessage directly
            htmlBuilder.AppendLine("window.chrome.webview.postMessage(JSON.stringify({ action: 'removeSelectedPackages', selectedPackages: selectedPackages }));");
            // htmlBuilder.AppendLine("selectedPackages = [];");  // Clear selected packages after sending the message
            htmlBuilder.AppendLine("}");
            htmlBuilder.AppendLine("</script>");

            return htmlBuilder.ToString();
        }

        public async void RemoveSelectedPackages(List<string> selectedPackages)
        {
            Logger.Log("Attempting to remove selected packages:", Color.Magenta);

            try
            {
                foreach (string package in selectedPackages)
                {
                    string powershellCommand = $"Get-AppxPackage {package} | Remove-AppxPackage";

                    Logger.Log($"Removing package: {package}", Color.DarkGreen);
                    await ExecutePowerShellCommand(powershellCommand);

                    Logger.Log($"Package removed successfully: {package}", Color.Green);
                }

                await LoadInstalledAppPackages(); // Global refresh

                // Refresh our three app buttons in Pinned apps section after removal
                string refreshedHtml = await GetPinnedAppPackages();
                await form.WebView.CoreWebView2.ExecuteScriptAsync($"document.getElementById('buttonsAppx-container').innerHTML = `{refreshedHtml}`;");
            }
            catch (Exception ex)
            {
                Logger.Log($"Error removing selected packages: {ex.Message}", Color.Red);
            }
        }

        public async Task<Collection<PSObject>> ExecutePowerShellCommand(string command)
        {
            try
            {
                using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                    // Add PowerShell script to pipeline
                    PowerShellInstance.AddScript(command);

                    // Invoke execution on pipeline asynchronously
                    return await Task.Run(() => PowerShellInstance.Invoke());
                }
            }
            catch (Exception ex)
            {
                Logger.Log($"Error executing PowerShell command: {ex.Message}", Color.Red);
                return null;
            }
        }
    }
}