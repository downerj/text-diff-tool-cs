namespace TextDiffTool
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
      ApplicationConfiguration.Initialize();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      Application.Run(new MainForm());
    }
  }
}