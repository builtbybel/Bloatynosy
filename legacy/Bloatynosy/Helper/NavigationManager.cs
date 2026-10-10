using System.Collections.Generic;
using System.Windows.Forms;

public class NavigationManager
{
    private Stack<Control> navigationHistory = new Stack<Control>(); // Holds previous views
    private Panel panelContainer; // Reference to the panel container where views are switched
    private Control mainPanel; // Reference to the main panel (start page)

    public NavigationManager(Panel panel)
    {
        this.panelContainer = panel;
        this.mainPanel = panel.Controls.Count > 0 ? panel.Controls[0] : null;
    }

    /// <summary>
    /// Checks if there are views in the navigation history to go back to.
    /// </summary>
    public bool CanGoBack()
    {
        return navigationHistory.Count > 0;
    }

    /// <summary>
    /// Adds the current control to the navigation history.
    /// </summary>
    private void AddToHistory()
    {
        if (panelContainer.Controls.Count > 0)
        {
            // Add the currently visible control to the history stack
            navigationHistory.Push(panelContainer.Controls[0]);
        }
    }

    /// <summary>
    /// Switches to a new view and adds the current view to the navigation history.
    /// </summary>
    /// <param name="newView">The new view to display.</param>
    public void SwitchView(Control newView)
    {
        AddToHistory(); // Save the current view before switching

        // Clear the container and display the new view
        panelContainer.Controls.Clear();
        panelContainer.Controls.Add(newView);
        newView.Dock = DockStyle.Fill;
        newView.BringToFront();
    }

    /// <summary>
    /// Navigates back to the previous view in the history, if available.
    /// </summary>
    public void GoBack()
    {
        if (CanGoBack())
        {
            // Pop the last view from the history stack and display it
            Control previousView = navigationHistory.Pop();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(previousView);
            previousView.Dock = DockStyle.Fill;
            previousView.BringToFront();
        }
    }

    /// <summary>
    /// Clears the navigation history.
    /// </summary>
    public void ClearHistory()
    {
        navigationHistory.Clear();
    }

    /// <summary>
    /// Switches directly to the main panel, clearing the navigation history.
    /// </summary>
    public void GoToMain()
    {
        if (mainPanel != null)
        {
            navigationHistory.Clear(); // Clear the navigation history
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(mainPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.BringToFront();
        }
    }
}