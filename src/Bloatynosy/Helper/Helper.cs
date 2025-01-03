using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloatynosyNue.Helpers
{
    public static class PluginHelper
    {
        // Check if the plugin environment is ready
        public static bool IsPluginEnvironmentReady()
        {
            return Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins")) &&
                   File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Newtonsoft.Json.dll"));
        }

        // Download required plugin files
        public static async Task DownloadPlugins()
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

                MessageBox.Show(Locales.Strings.formPlugins_status_Ready.Replace(@"\n", Environment.NewLine), "Plugin Setup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nPlease try again later.", "Download Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}