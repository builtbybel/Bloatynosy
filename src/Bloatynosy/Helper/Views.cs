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
    }
}