using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bloatynosy.Views
{
    public partial class SettingsView : UserControl
    {
        public SettingsView()
        {
            InitializeComponent();
            DarkModeManager.ApplyDarkMode(this);
            InitializeLocalizedStrings();

            string appVersion = Program.GetAppVersion();
            linkAppVer.Text = "Version:   " + appVersion + " | X64 | Realase | Build: DEV Noir";

            ShowRandomMessage();
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = Locales.Strings.ctl_linkSettings;
            btnDonate.Text = Locales.Strings.ctl_Donate;
            lblSecLanguage.Text = Locales.Strings.formSettings_ctl_lblSecLanguage;
            lblLanguage.Text = Locales.Strings.formSettings_ctl_lblSecLanguage;
            lblSecAboutApp.Text = Locales.Strings.formSettings_ctl_lblSecAboutApp;
        }

        public void ShowRandomDonationPrompt()
        {
            // Load donation prompts from Res file
            string allMessages = Locales.Strings.ctl_DonationPrompts;

            // Split the messages by semicolon
            string[] donationMessages = allMessages.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            // Donation prompts from Res file   |  Would you like to donate?
            string message = $"{donationMessages[new Random().Next(donationMessages.Length)]} {Locales.Strings.ctl_DonateAsk}";

            if (MessageBox.Show(message, "Support Bloatynosy", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://paypal.com/donate?hosted_button_id=MY7HX4QLYR4KG",
                    UseShellExecute = true
                });
            }
        }

        public void ShowRandomMessage()
        {
            string[] messages = new[]
            {
        "Windows 11 bloatware overload? Bloatynosy strips it clean, including Dev Home and Clipchamp!",
        "Clipchamp in Windows 11 slowing you down? Bloatynosy can get rid of that trash!",
        "Dev Home, Xbox Game Bar, and all that useless bloat in Windows 11? Bloatynosy removes them!",
        "Sick of Windows 11 23H2’s preinstalled junk like Dev Home? Bloatynosy clears it out!",
        "Windows 11 24H2 forcing unwanted apps like Clipchamp? Bloatynosy takes care of that!",
        "Want to ditch Windows 11’s clutter? Bloatynosy removes Dev Home, Xbox Game Bar, and more!",
        "Windows 11 24H2 bringing too many unwanted features? Bloatynosy cleans it up for you!",
        "Fed up with Windows 11’s default bloat like Clipchamp and the Xbox Game Bar? Bloatynosy fixes it!",
        "Windows 11’s latest bloat making your PC sluggish? Bloatynosy gets rid of it all, fast!",
        "Bloatynosy removes the unwanted Windows 11 apps like Clipchamp, Dev Home, and the Xbox Game Bar!",
        "Too much preinstalled junk in Windows 11 23H2? Bloatynosy cleans it all up for a smoother experience!",
        "Bloatware in Windows 11 got you frustrated? Bloatynosy removes Dev Home, Xbox Game Bar, and more!",
        "Windows 11 24H2’s new bloat killing your PC speed? Bloatynosy can fix that!",
        "Windows 11 forcing apps like Clipchamp? Bloatynosy makes it disappear!",
        "Hate those random preinstalled apps in Windows 11? Bloatynosy removes Dev Home and Clipchamp with ease!"
    };

            Random random = new Random();
            int randomIndex = random.Next(messages.Length);
            string randomMessage = messages[randomIndex];

            linkRandom.Text = randomMessage;
        }


        private void linkAppDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/builtbybel/Bloatynosy");
        }

        private void linkLang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/builtbybel/Bloatynosy/tree/main/languages/");
        }

        private void linkCreditsIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.flaticon.com/free-icon/fat-droplet_9962687");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            ShowRandomDonationPrompt();
        }

    }
}