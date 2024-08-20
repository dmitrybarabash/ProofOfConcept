using PrecisionDigitalThermometerApp.Services;

namespace PrecisionDigitalThermometerApp;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Real life scenario
        //Application.Run(new MainForm(new PrecisionDigitalThermometerService()));

        // Testing scenario
        Application.Run(new MainForm(new PrecisionDigitalThermometerServiceStubForTesting()));
    }
}