using BloatynosyNue;
using System.Drawing;
using System.Windows.Forms;
using System;

public class FeaturePanel : Panel
{
    private FeatureBase feature;
    private Logger logger;
    private Label statusLabel;

    // Expose the description and checkbox text for searching
    public string DescriptionText => feature.Info().ToLower();  // Lowercase for case-insensitive search
    public string CheckBoxText => feature.ID().ToLower();

    public FeaturePanel(FeatureBase feature, Logger logger)
    {
        this.feature = feature;
        this.logger = logger;

        // Create a FlowLayoutPanel
        FlowLayoutPanel flowLayout = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            AutoScroll = true
        };

        // Add Components
        var descriptionLabel = CreateDescriptionLabel();
        var checkBox = CreateCheckBox();
        var linkLabel = CreateLinkLabel();
        statusLabel = CreateStatusLabel(); // Init status label

        // Event Handlers
        linkLabel.Click += LinkLabel_Click;
        checkBox.CheckedChanged += CheckBox_CheckedChanged;

        // Add Controls to FlowLayoutPanel
        flowLayout.Controls.Add(descriptionLabel);
        flowLayout.Controls.Add(checkBox);
        flowLayout.Controls.Add(linkLabel);
        flowLayout.Controls.Add(statusLabel);

        // Add FlowLayoutPanel to the main panel
        Controls.Add(flowLayout);
    }

    private Label CreateDescriptionLabel()
    {
        return new Label
        {
            Text = feature.Info(),
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Regular),
            ForeColor = Color.Black,
            Padding = new Padding(0, 0, 0, 5) // Padding for better spacing
        };
    }

    private CheckBox CreateCheckBox()
    {
        return new CheckBox
        {
            Text = feature.ID(),
            AutoSize = true,
            Checked = feature.CheckFeature(),
            Dock = DockStyle.Top,
            Font = new Font("Segoe UI", 10, FontStyle.Bold),
            ForeColor = Color.Black
        };
    }

    private LinkLabel CreateLinkLabel()
    {
        return new LinkLabel
        {
            Text = "More Infos",
            AutoSize = true,
            LinkColor = Color.MediumVioletRed,
            LinkBehavior = LinkBehavior.HoverUnderline,
            Font = new Font("Segoe UI", 10, FontStyle.Regular),
            Cursor = Cursors.Hand,
            Padding = new Padding(0, 0, 10, 0) // Adding some padding
        };
    }

    private Label CreateStatusLabel()
    {
        return new Label
        {                                       // Enabled       or          Disabled
            Text = feature.CheckFeature() ? BloatynosyNue.Locales.Strings.formExperience_status_Enabled : BloatynosyNue.Locales.Strings.formExperience_status_Disabled,
            AutoSize = true,
            Font = new Font("Segoe UI", 10, FontStyle.Italic),
            ForeColor = Color.Gray,
            TextAlign = ContentAlignment.MiddleRight,
            Padding = new Padding(10, 0, 0, 0)
        };
    }

    private void LinkLabel_Click(object sender, EventArgs e)
    {
        // Copy the registry key associated with the feature to the clipboard
        string registryKey = feature.GetRegistryKey();
        if (!string.IsNullOrEmpty(registryKey))
        {
            Clipboard.SetText(registryKey);
            MessageBox.Show($"Registry key '{registryKey}' copied to clipboard", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("No registry key available for this feature.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void CheckBox_CheckedChanged(object sender, EventArgs e)
    {
        var checkBox = sender as CheckBox;
        bool success = false;

        if (checkBox != null)
        {
            if (checkBox.Checked)
            {
                success = feature.DoFeature(); // Enable feature
                if (success)
                {
                    logger.Log($"{feature.ID()} " + BloatynosyNue.Locales.Strings.formExperience_status_Enabled, Color.Green);  // enabled


                    statusLabel.Text = BloatynosyNue.Locales.Strings.formExperience_status_Enabled;      // Enabled
                }
            }
            else
            {
                success = feature.UndoFeature(); // Disable feature
                if (success)
                {
                    logger.Log($"{feature.ID()} " + BloatynosyNue.Locales.Strings.formExperience_status_Disabled, Color.Red); // disabled
                    statusLabel.Text = BloatynosyNue.Locales.Strings.formExperience_status_Disabled;      // Disabled
                }
            }
        }

        if (!success)
        {
            // Failed to update feature status due to insufficient permissions.
            MessageBox.Show(BloatynosyNue.Locales.Strings.formExperience_statusPermissions, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
