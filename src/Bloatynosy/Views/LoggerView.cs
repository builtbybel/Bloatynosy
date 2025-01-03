using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BloatynosyNue.Views
{
    public partial class LoggerView : UserControl
    {
        public LoggerView()
        {
            InitializeComponent();
            InitializeLocalizedStrings();
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            this.Text  =
            lblHeader.Text = BloatynosyNue.Locales.Strings.tt_btnLogger;
        }


        // Log to the RichTextBox
        public void AddLog(string message, Color color)
        {
            if (rtbLog.InvokeRequired)
            {
                // Invoke on the UI thread
                rtbLog.Invoke(new Action(() => AddLog(message, color)));
            }
            else
            {
                // Perform changes directly on the UI thread
                rtbLog.SelectionColor = color;
                rtbLog.AppendText(message + Environment.NewLine);
                rtbLog.ScrollToCaret();
            }
        }


        private void HighlightSearchResults(string searchText)
        {
            rtbLog.SelectAll();
            rtbLog.SelectionBackColor = Color.White; // Reset highlighting

            string logText = rtbLog.Text;
            int startIndex = 0;

            while ((startIndex = logText.IndexOf(searchText, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                rtbLog.Select(startIndex, searchText.Length);
                rtbLog.SelectionBackColor = Color.Black; // Highlighting
                rtbLog.SelectionColor = Color.Yellow;
                startIndex += searchText.Length;
            }

            rtbLog.DeselectAll();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // MessageBox.Show("Enter search term", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            HighlightSearchResults(searchText);
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";

            // Reset highlighting
            rtbLog.SelectAll();
            rtbLog.SelectionBackColor = Color.FromArgb(243, 243, 243);
            rtbLog.SelectionColor = Color.Black;
            rtbLog.DeselectAll();
        }

        // Event handler to open clicked links in the default browser
        private void rtbLog_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = e.LinkText,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAppDev_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/builtbybel/Bloatynosy");
        }
    }
}