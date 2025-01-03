using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BloatynosyNue.Views
{
    public partial class SettingsView : UserControl
    {
        private readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public SettingsView()
        {
            InitializeComponent();
            InitializeLocalizedStrings();

            string appVersion = Program.GetAppVersion();
            linkAppVer.Text = "Version:   " + appVersion + " | X64 | RELEASE";

            PopulateLanguageComboBox();
            ShowRandomMessage();
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements

            lblHeader.Text = Locales.Strings.tt_btnSettings;
            linkDonate.Text = Locales.Strings.ctl_Donate;
        }

        private void PopulateLanguageComboBox()
        {
            // Search for folders with names consisting of 2-3 characters
            var languageFolders = Directory.GetDirectories(baseDirectory)
                .Select(Path.GetFileName) // Get only folder names
                .Where(name => name.Length >= 2 && name.Length <= 3) // Filter names with 2-3 characters
                .OrderBy(name => name) // Sort alphabetically
                .ToList();

            // If no language folders are found, add "English" as the default
            if (languageFolders.Count == 0)
            {
                comboBoxLanguages.Items.Add("English");
                comboBoxLanguages.SelectedItem = "English";
            }
            else
            {
                // Add detected language folders to the ComboBox
                foreach (string folder in languageFolders)
                {
                    comboBoxLanguages.Items.Add(folder);
                }

                // Select 'en' (English) if available; otherwise, select the first language
                comboBoxLanguages.SelectedItem = languageFolders.Contains("en") ? "en" : languageFolders.First();
            }
        }

        public void ShowRandomDonationPrompt()
        {
            // Load donation prompts from Res file
            string allMessages = Locales.Strings.ctl_DonationPrompts;

            // Split the messages by semicolon
            string[] donationMessages = allMessages.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            // Donation prompts from Res file   |  Would you like to donate?
            string message = $"{donationMessages[new Random().Next(donationMessages.Length)]} {Locales.Strings.ctl_DonateAsk}";

            if (MessageBox.Show(message, "Support Bloatynosy Nue", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

        private void linkDonate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowRandomDonationPrompt();
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
            Process.Start("https://www.flaticon.com/free-icon/curious_725039");
        }
    }
}