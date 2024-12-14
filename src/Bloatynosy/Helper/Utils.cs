using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BloatynosyNue
{
    internal class Utils
    {
        // Check registry int equal
        public static bool IntEquals(string keyName, string valueName, int expectedValue)
        {
            try
            {
                var value = Registry.GetValue(keyName, valueName, null);
                return (value != null && (int)value == expectedValue);
            }
            catch (Exception ex)

            {
                MessageBox.Show(keyName, ex.Message, MessageBoxButtons.OK);
                return false;
            }
        }

        // Check registry strings equal
        public static bool StringEquals(string keyName, string valueName, string expectedValue)
        {
            try
            {
                var value = Registry.GetValue(keyName, valueName, null);

                return (value != null && (string)value == expectedValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(keyName, ex.Message, MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool KeyExists(string keyPath)
        {
            return Registry.GetValue(keyPath, null, null) != null;
        }

        public static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        // Launch Urls in richText control
        public static void LaunchUri(string url)
        {
            if (IsHttpURL(url)) Process.Start(url);
        }

        // Check Urls in in richText control
        public static bool IsHttpURL(string url)
        {
            return
                ((!string.IsNullOrWhiteSpace(url)) &&
                (url.ToLower().StartsWith("http")));
        }
    }
}