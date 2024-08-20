using System.IO.Ports;
using PrecisionDigitalThermometerApp.Interfaces;

namespace PrecisionDigitalThermometerApp.Services;

public class PrecisionDigitalThermometerService : IPrecisionDigitalThermometerService
{
    private const int DelayInterval = 1000;

    private readonly SerialPort _serialPort;
    private readonly Thread _thread;
    private readonly object _lockObject = new();

    public PrecisionDigitalThermometerService()
    {
        // Serial port initialisation.
        // I've never worked with serial port but it's just a proof of concept,
        // so let's assume that we initialise serial port properly here.
        _serialPort = new()
        {
            ReadTimeout = 500,
            WriteTimeout = 500
            // ... and so on
        };

        _thread = new Thread(ReadTemperature) { IsBackground = true };
        _thread.Start();
    }

    public void SelfTest()
    {
        lock (_lockObject)
        {
            // Let's assume that such command is enough for self-test
            _serialPort.WriteLine("*TST");
        }
    }

    public void ToggleBacklight(bool on)
    {
        lock (_lockObject)
        {
            string mode = on ? "ON" : "OFF";

            // Let's assume that such command is enough for turn on/off the backlight
            _serialPort.WriteLine($"DISPIay:BACKIight {mode}");
        }
    }

    public void Beep()
    {
        lock (_lockObject)
        {
            // Let's assume that such command is enough for beep
            _serialPort.WriteLine("SYSTem:BEEPer");
        }
    }

    public double Temperature { get; private set; }

    private void ReadTemperature(object? obj)
    {
        while (true)
        {
            try
            {
                Thread.Sleep(DelayInterval);
                lock (_lockObject)
                {
                    // Let's assume that such commands are enough for reading the temperature
                    _serialPort.WriteLine("READ?");
                    string message = _serialPort.ReadLine();
                    Temperature = double.Parse(message);
                }
            }
            catch (TimeoutException)
            {
            }
        }
    }
}
