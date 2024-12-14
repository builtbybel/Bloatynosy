using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace BloatynosyNue
{
    public partial class LoggerForm : Form
    {
        public RichTextBox rtbLog { get; private set; }

        public LoggerForm()
        {
            InitializeComponent();
            InitializeLocalizedStrings();

            rtbLog = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                DetectUrls = true ,// Enable URL detection
                BackColor = Color.FromArgb(233, 243, 249)
            };
            rtbLog.LinkClicked += RtbLog_LinkClicked; // Handle link click event
            Controls.Add(rtbLog);
        }


        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            this.Text = BloatynosyNue.Locales.Strings.tt_btnLogger;
        }

        // Log to the RichTextBox
        public void AddLog(string message, Color color)
        {
            rtbLog.Invoke(new Action(() =>
            {
                rtbLog.SelectionColor = color;
                rtbLog.AppendText(message + Environment.NewLine);
                rtbLog.ScrollToCaret();
            }));
        }

        // Event handler to open clicked links in the default browser
        private void RtbLog_LinkClicked(object sender, LinkClickedEventArgs e)
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
    }
}
