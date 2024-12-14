using System.Windows.Forms;

namespace Views
{
    public static class SwitchView
    {
        public static Control PreviousView { get; private set; }
        public static Control DefaultView { get; set; } // Store the default view (panelMain)

        // Switch to a new view
        public static void SetView(Control newView, Panel targetPanel)
        {
            if (targetPanel.Controls.Count > 0)
            {
                if (PreviousView == null)
                {
                    PreviousView = targetPanel.Controls[0]; // Save the current view as PreviousView
                }
            }

            newView.Dock = DockStyle.Fill;
            targetPanel.Controls.Clear();
            targetPanel.Controls.Add(newView);
        }

        // Go back to the previous view
        public static void GoBack(Panel targetPanel)
        {
            if (PreviousView != null)
            {
                targetPanel.Controls.Clear();
                targetPanel.Controls.Add(PreviousView);
                PreviousView.Dock = DockStyle.Fill;
                PreviousView = null; // Reset PreviousView
            }
            else if (DefaultView != null)
            {
                targetPanel.Controls.Clear();
                targetPanel.Controls.Add(DefaultView);
                DefaultView.Dock = DockStyle.Fill;
            }
        }

        // NEW: Go back directly to PluginsView
        public static void BackToPluginsView(Control pluginsView, Panel targetPanel)
        {
            // Clear the current content of the panel
            targetPanel.Controls.Clear();

            // Add PluginsView back to the panel
            pluginsView.Dock = DockStyle.Fill;
            targetPanel.Controls.Add(pluginsView);
        }

    }
}
