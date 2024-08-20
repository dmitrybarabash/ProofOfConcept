using System.Text;
using PrecisionDigitalThermometerApp.Interfaces;

namespace PrecisionDigitalThermometerApp;

public partial class MainForm : Form
{
    private readonly IPrecisionDigitalThermometerService _thermometerService;
    private readonly Thread _thread;

    public MainForm(IPrecisionDigitalThermometerService precisionDigitalThermometerService)
    {
        InitializeComponent();

        _thermometerService = precisionDigitalThermometerService;
        _thread = new(GetTemperatureTreadProc) { IsBackground = true };
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        _thread.Start();
    }

    private void checkBoxBacklight_CheckedChanged(object sender, EventArgs e)
    {
        _thermometerService.ToggleBacklight(checkBoxBacklight.Checked);
    }

    private void buttonBeep_Click(object sender, EventArgs e)
    {
        _thermometerService.Beep();
    }

    private void GetTemperatureTreadProc(object? obj)
    {
        while (true)
        {
            Thread.Sleep(1000);
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => labelTemperature.Text =
                    GetAnnotatedTemperature(_thermometerService.Temperature, checkBoxAsInteger.Checked)));
            }
            else
            {
                labelTemperature.Text = GetAnnotatedTemperature(_thermometerService.Temperature, checkBoxAsInteger.Checked);
            }
        }
    }

    private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Environment.Exit(0);
    }

    private string GetAnnotatedTemperature(double temperature, bool asInteger)
    {
        temperature = Math.Round(temperature, 1);

        int integerPart = (int)temperature;

        var resultBuilder = new StringBuilder();

        resultBuilder.Append(asInteger ? integerPart.ToString() : temperature.ToString());

        if (integerPart % 7 == 0 && integerPart % 3 != 0)
        {
            resultBuilder.Append("<-");
        }
        else if (integerPart % 7 != 0 && integerPart % 3 == 0)
        {
            resultBuilder.Append("->");
        }
        else if (integerPart % 7 == 0 && integerPart % 3 == 0)
        {
            resultBuilder.Append("<->");
        }

        return resultBuilder.ToString();
    }
}
