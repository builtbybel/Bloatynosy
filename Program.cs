namespace Bloatynosy;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Loc.Init(null);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}
