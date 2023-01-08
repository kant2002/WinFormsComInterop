using System.Runtime.InteropServices;

namespace HostedWindowsForms;

internal static class LibraryFunctions
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [UnmanagedCallersOnly(EntryPoint = nameof(ShowMessageBox))]
    public static void ShowMessageBox()
    {
        // Application configuration does not work in library project.
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}