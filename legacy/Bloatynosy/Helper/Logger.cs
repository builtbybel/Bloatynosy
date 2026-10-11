using Bloatynosy.Views;
using System.Collections.Generic;
using System.Drawing;
using System;
using Bloatynosy;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

public class Logger
{
    private static LoggerForm loggerFormInstance;
    private static readonly List<(string Message, Color Color)> logBuffer = new List<(string, Color)>();

    // Set the LoggerView instance dynamically
    public static void SetLoggerForm(LoggerForm loggerForm)
    {
        if (loggerForm == null)
        {
            throw new ArgumentNullException(nameof(loggerForm), "LoggerForm cannot be null.");
        }

        loggerFormInstance = loggerForm;

        // If there were logs buffered before the view was set, flush them now
        foreach (var log in logBuffer)
        {
            loggerFormInstance.AddLog(log.Message, log.Color);
        }

        // Clear the buffer after flushing
        logBuffer.Clear();
    }

    // Log a message with color and timestamp
    public void Log(string message, Color color)
    {
        string timestampedMessage = $"{DateTime.Now:HH:mm:ss} - {message}";

        // Log to the LoggerForm if it's open
        if (loggerFormInstance != null)
        {
            loggerFormInstance.AddLog(timestampedMessage, color);
        }
        else
        {
            // If LoggerView isn't open, buffer the log for future display
            logBuffer.Add((timestampedMessage, color));
        }
    }

    // Check for app updates
    public bool CheckForAppUpdates()
    {
        if (!IsInternetAvailable())
        {
            Log("No internet connection. Update check failed.", Color.Red);
            MessageBox.Show("No internet connection. Update check failed.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        try
        {
            string versionInfoUrl = "https://raw.githubusercontent.com/builtbybel/Bloatynosy/main/src/Bloatynosy/Properties/AssemblyInfo.cs";
            string assemblyInfo = new WebClient().DownloadString(versionInfoUrl);

            string latestVersion = assemblyInfo
                .Split('\n')
                .FirstOrDefault(line => line.Contains("[assembly: AssemblyFileVersion"))?
                .Split('"')[1]; // Extract version string

            if (latestVersion == Program.GetAppVersion())
            {
                Log("No new updates available. You are up-to-date.", Color.Green);
               // MessageBox.Show("No new updates available.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                string downloadUrl = "https://github.com/builtbybel/Bloatynosy/releases";
                Log($"Update available: Version {latestVersion} is ready for download.", Color.HotPink);
                Log($"Download here: {downloadUrl}", Color.HotPink);

                if (MessageBox.Show($"App version {latestVersion} is available.\nOpen the download page?",
                                    "App Update Available",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Process.Start(downloadUrl);
                }
                return true;
            }
        }
        catch (Exception ex)
        {
            Log($"Error checking for updates: {ex.Message}", Color.Red);
            MessageBox.Show("Failed to check for updates. See log for details.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // Check Internet connectivity
    private static bool IsInternetAvailable()
    {
        try
        {
            using (var client = new WebClient())
            using (client.OpenRead("http://clients3.google.com/generate_204"))
            {
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
}
