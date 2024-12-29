using BloatynosyNue;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class PSPluginHandler
{
    public void LoadPowerShellPlugins(TreeView treeView)
    {
        var scriptDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins");

        if (!Directory.Exists(scriptDirectory))
        {
            MessageBox.Show("plugins directory does not exist.");
            return;
        }

        // Create a Dependencies category in the TreeView
        TreeNode dependencyCategory = new TreeNode("Plugins");
        treeView.Nodes.Add(dependencyCategory);

        var scriptFiles = Directory.GetFiles(scriptDirectory, "*.ps1");

        foreach (var file in scriptFiles)
        {
            var scriptName = Path.GetFileNameWithoutExtension(file);

            // Create a TreeNode for each ps script
            var scriptNode = new TreeNode
            {
                ToolTipText = file,
                Text = $"{scriptName} [PS]",
                Tag = file // Store the file path as the Tag
            };

            // Add the script node to the Dependecy category
            dependencyCategory.Nodes.Add(scriptNode);
        }
    }

    // Execute the selected PowerShell script
    public async Task ExecutePlugin(string pluginPath, Logger logger)
    {
        try
        {
            using (var process = new Process())
            {
                process.StartInfo.FileName = "powershell.exe";
                process.StartInfo.Arguments = $"-NoProfile -ExecutionPolicy Bypass -File \"{pluginPath}\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                var outputBuilder = new StringBuilder();
                var errorBuilder = new StringBuilder();

                // Handle output from PowerShell script
                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        outputBuilder.AppendLine(e.Data);
                        logger.Log($"PowerShell script output: {e.Data}", System.Drawing.Color.Black);
                    }
                };

                // Handle error from PowerShell script
                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        errorBuilder.AppendLine(e.Data);
                        logger.Log($"PowerShell script error: {e.Data}", System.Drawing.Color.Crimson);
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await Task.Run(() =>
                {
                    process.WaitForExit();
                });

                logger.Log($"PowerShell script executed successfully: {pluginPath}", System.Drawing.Color.Green);
            }
        }
        catch (Exception ex)
        {
            logger.Log($"Error executing PowerShell script: {pluginPath}. Exception: {ex.Message}", System.Drawing.Color.Crimson);
        }
    }
}