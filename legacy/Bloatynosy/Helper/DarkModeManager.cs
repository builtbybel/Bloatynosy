using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public static class DarkModeManager
{
    // Constants for immersive dark mode and optional Mica effect
    private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
    private const int DWMWA_MICA_EFFECT = 1029;

    // P/Invoke declaration for setting window attributes related to dark mode
    [DllImport("dwmapi.dll")]
    private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

    [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
    private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);


    public static void ApplyDarkMode(Control parent = null)
    {

        // Action that applies dark mode to each control by changing its theme and attributes
        Action<Control> applyTheme = control =>
        {
            int enableDarkMode = 1; // Enabling dark mode
            SetWindowTheme(control.Handle, "DarkMode_Explorer", null);  // Apply the Dark Mode Explorer theme to buttons, title bars, scroll bars, etc.
            DwmSetWindowAttribute(control.Handle, DWMWA_USE_IMMERSIVE_DARK_MODE, ref enableDarkMode, sizeof(int));  // Enable immersive dark mode
            DwmSetWindowAttribute(control.Handle, DWMWA_MICA_EFFECT, ref enableDarkMode, sizeof(int));  // Enable Mica effect
        };

        // Apply the dark mode theme to the parent control (here form or container)
        applyTheme(parent);

        // Apply dark mode recursively to all child controls of the parent
        foreach (Control control in parent.Controls)
        {
            applyTheme(control);  // Apply dark mode to the control
            if (control.Controls.Count > 0)
                ApplyDarkMode(control);  // Recursively apply dark mode to child controls
        }
    }
}
