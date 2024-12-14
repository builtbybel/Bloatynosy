using BloatynosyNue.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatynosyNue
{
    public partial class StoreForm : Form
    {
        private const string PluginJsonUrl = "https://raw.githubusercontent.com/builtbybel/Bloatynosy/main/plugins/plugins_manifest.json";
        private const string PluginBaseUrl = "https://github.com/builtbybel/Bloatynosy/raw/main/plugins/";

        // Dictionary to store plugin filenames and descriptions
        private Dictionary<string, string> pluginDescriptions;

        private readonly string pluginsDirectory = Path.Combine(Application.StartupPath, "plugins");

        private PluginsView _pluginsView;

        public StoreForm(PluginsView pluginsView)
        {
            InitializeComponent();
            _pluginsView = pluginsView;

            LoadPlugins();
        }

        private async void LoadPlugins()
        {
            try
            {
                var json = await DownloadJsonAsync(PluginJsonUrl);
                pluginDescriptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                foreach (var pluginFileName in pluginDescriptions.Keys)
                {
                    // Add each plugin to the CheckedListBox
                    bool isInstalled = File.Exists(Path.Combine(pluginsDirectory, pluginFileName));
                    int index = checkedListBoxPlugins.Items.Add(pluginFileName);

                    // Check the item if the plugin is installed
                    checkedListBoxPlugins.SetItemChecked(index, isInstalled);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plugins: {ex.Message}");
            }
        }

        private async Task<string> DownloadJsonAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            var selectedPlugins = new List<string>();
            foreach (var plugin in checkedListBoxPlugins.CheckedItems)
            {
                selectedPlugins.Add(plugin.ToString());
            }

            if (selectedPlugins.Count > 0)
            {
                await DownloadPluginsAsync(selectedPlugins);
            }
            else
            {
                MessageBox.Show("Please select at least one plugin to download.");
            }
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            var pluginsToRemove = new List<string>();
            foreach (var plugin in checkedListBoxPlugins.CheckedItems)
            {
                pluginsToRemove.Add(plugin.ToString());
            }

            foreach (var pluginFileName in pluginsToRemove)
            {
                try
                {
                    var filePath = Path.Combine(pluginsDirectory, pluginFileName);
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                        checkedListBoxPlugins.Items.Remove(pluginFileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to uninstall {pluginFileName}: {ex.Message}");
                }
            }

            MessageBox.Show("Selected plugins have been uninstalled.");
            checkedListBoxPlugins.Items.Clear();
            LoadPlugins(); // Refresh the list of plugins
        }

        private void checkedListBoxPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPlugin = checkedListBoxPlugins.SelectedItem?.ToString();
            if (selectedPlugin != null && pluginDescriptions.ContainsKey(selectedPlugin))
            {
                textDescription.Text = pluginDescriptions[selectedPlugin];
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // Open the folder browser dialog to select the source directory
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceDirectory = folderBrowserDialog.SelectedPath;
                    string[] files = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                        .Where(file => file.EndsWith(".json") || file.EndsWith(".ps1")).ToArray();

                    List<string> importedPlugins = new List<string>(); // List to store imported plugin names

                    foreach (var file in files)
                    {
                        try
                        {
                            string fileName = Path.GetFileName(file);
                            string destinationPath = Path.Combine(pluginsDirectory, fileName);
                            File.Copy(file, destinationPath, true); // Overwrite if file exists
                            importedPlugins.Add(fileName); // Add to the imported plugins list
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to import {file}: {ex.Message}");
                        }
                    }

                    // Show message box with the names of the imported plugins
                    if (importedPlugins.Count > 0)
                    {
                        string message = "Imported Plugins:\n" + string.Join("\n", importedPlugins);
                        MessageBox.Show(message, "Import Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No plugins were imported.", "Import Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private async Task DownloadPluginsAsync(List<string> plugins)
        {
            progressBar.Value = 0;
            progressBar.Maximum = plugins.Count;

            using (HttpClient client = new HttpClient())
            {
                foreach (var pluginFileName in plugins)
                {
                    try
                    {
                        var pluginUrl = $"{PluginBaseUrl}{pluginFileName}";
                        var downloadPath = Path.Combine(pluginsDirectory, pluginFileName);

                        var data = await client.GetByteArrayAsync(pluginUrl);
                        await WriteAllBytesAsync(downloadPath, data);

                        progressBar.Value += 1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to download {pluginFileName}: {ex.Message}");
                    }
                }
            }

            MessageBox.Show("All selected plugins have been downloaded.");
        }

        private async Task WriteAllBytesAsync(string path, byte[] data)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                await fs.WriteAsync(data, 0, data.Length);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            _pluginsView.RefreshPlugins();
        }

        private void linkPluginsDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _pluginsView.RefreshPlugins();
        }
    }
}