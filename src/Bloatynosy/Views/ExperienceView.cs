using BloatynosyNue;
using Settings.Ads;
using Settings.Privacy;
using Settings.Personalization;
using Settings.Gaming;
using Settings.AI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Views
{
    public partial class ExperienceView : UserControl
    {
        private Logger logger;
        private List<FeatureBase> features;

        public ExperienceView()
        {
            InitializeComponent();
            InitializeLogger();
            InitializeLocalizedStrings();
            InitializeFeatures();
            InitializeCategory();
            LoadFeatures();
        }

        private void InitializeLogger()
        {
            logger = new Logger();
            logger.Log("ExperienceView initialized.", Color.Green);
        }

        private void InitializeLocalizedStrings()
        {
            // Set localized strings for UI elements
            lblHeader.Text = BloatynosyNue.Locales.Strings.formExperience_ctl_lblHeader;
            lblSubHeader.Text = BloatynosyNue.Locales.Strings.formExperience_ctl_lblSubHeader;
            textBoxSearch.Text = BloatynosyNue.Locales.Strings.formExperience_ctl_textBoxSearch;
            lblSort.Text = BloatynosyNue.Locales.Strings.formExperience_ctl_lblSort;
            btnApply.Text = BloatynosyNue.Locales.Strings.formExperience_ctl_btnApply;
            btnRevert.Text = BloatynosyNue.Locales.Strings.formExperience_ctl_btnRevert;
        }

        private void InitializeFeatures()
        {
            // Initialize the list of features
            features = new List<FeatureBase>
            {
                // Ads
                new FileExplorerAds(logger),
                new FinishSetupAds(logger),
                new LockScreenAds(logger),
                new PersonalizedAds(logger),
                new SettingsAds(logger),
                new StartmenuAds(logger),
                new TailoredExperiences(logger),
                new TipsAndSuggestions(logger),
                new WelcomeExperienceAds(logger),

                // Privacy
                new ActivityHistory(logger),
                new LocationTracking(logger),
                new PrivacyExperience(logger),
                new Telemetry(logger),

                // Personalization
                new SearchboxTaskbarMode(logger),
                new ShowOrHideMostUsedApps(logger),
                new ShowTaskViewButton(logger),
                new LockScreen(logger),
                new StartLayout(logger),
                new TaskbarAlignment(logger),
                new FullContextMenus(logger),

                // AI
                new CopilotTaskbar(logger),
                new RecallUser(logger),
                new RecallMachine(logger),

                // Gaming
                new GameDVR(logger),
                new PowerThrottling(logger),
                new VisualFX(logger),
            };
        }

        private void InitializeCategory()
        {
            // Extract unique categories from features
            var uniqueCategories = features.Select(f => f.GetCategory()).Distinct().ToList();
            uniqueCategories.Insert(0, "All"); // Add "All" as the first item

            foreach (var category in uniqueCategories)
            {
                categoryComboBox.Items.Add(category);
            }

            categoryComboBox.SelectedIndex = 0;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;

            Controls.Add(categoryComboBox);
        }

        private void LoadFeatures(string category = "All")
        {
            if (featurePanel == null)
            {
                MessageBox.Show("FeaturePanel is not initialized. Please check the designer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            featurePanel.Controls.Clear();

            var filteredFeatures = category == "All"
                ? features
                : features.Where(f => f.GetCategory().Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();

            foreach (var feature in filteredFeatures)
            {
                var featurePanelInstance = new FeaturePanel(feature, logger)
                {
                    Width = featurePanel.Width - 50,
                    Height = 160,
                    BorderStyle = BorderStyle.None,
                    BackColor = Color.FromArgb(240, 240, 240),
                    Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, featurePanel.Width, 160, 20, 20))
                };

                featurePanel.Controls.Add(featurePanelInstance);
            }
        }

        // Import rounded corners
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Get the selected category from the ComboBox
            string selectedCategory = categoryComboBox.SelectedItem.ToString();

            // Filter the features based on the selected category
            var featuresToApply = selectedCategory == "All"
                ? features
                : features.Where(f => f.GetCategory().Equals(selectedCategory, StringComparison.OrdinalIgnoreCase)).ToList();

            // Apply each feature in the filtered list
            foreach (var feature in featuresToApply)
            {
                if (!feature.CheckFeature()) // If feature is not enabled
                {
                    feature.DoFeature(); // Apply feature
                    logger.Log($"{feature.ID()} enabled.", Color.Green);
                }
            }

            LoadFeatures(selectedCategory); // Reload only the filtered features
            MessageBox.Show($"Features in category '{selectedCategory}' have been applied.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem.ToString();

            var featuresToRevert = selectedCategory == "All"
                ? features
                : features.Where(f => f.GetCategory().Equals(selectedCategory, StringComparison.OrdinalIgnoreCase)).ToList();

            // Revert each feature in the filtered list
            foreach (var feature in featuresToRevert)
            {
                if (feature.CheckFeature())
                {
                    feature.UndoFeature(); // Revert feature
                    logger.Log($"{feature.ID()} reverted.", Color.Red);
                }
            }

            LoadFeatures(selectedCategory); // Reload only the filtered features
            MessageBox.Show($"Features in category '{selectedCategory}' have been reverted.", "Revert Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBoxSearch.Text.ToLower(); // Get the search text in lowercase for case-insensitive search

            // Iterate through all controls in featurePanel
            foreach (Control control in featurePanel.Controls)
            {
                if (control is FeaturePanel featurePanelControl)
                {
                    bool matchFound = false;

                    // Check if any text in the description or checkbox of this feature matches the search query
                    if (featurePanelControl.DescriptionText.Contains(searchQuery) || featurePanelControl.CheckBoxText.Contains(searchQuery))
                    {
                        matchFound = true;
                    }

                    // Toggle visibility based on whether the feature matches the search query
                    featurePanelControl.Visible = matchFound;
                }
            }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = ""; // Clear the search box text when clicked
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            LoadFeatures(selectedCategory);
        }
    }
}