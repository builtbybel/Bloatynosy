namespace Bloatynosy;

//the entry point: sets up winforms, loads the language, and opens the one window
internal static class Program
{
    //starts the app and blocks until the window is closed
    [STAThread]
    private static void Main()
    {
        //visual styles come first, the dpi setup of winforms hangs on this call
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Loc.Init(null);
        Application.Run(new MainForm());
    }
}
