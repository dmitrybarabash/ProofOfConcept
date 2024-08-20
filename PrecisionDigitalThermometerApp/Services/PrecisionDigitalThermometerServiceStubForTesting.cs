using PrecisionDigitalThermometerApp.Interfaces;

namespace PrecisionDigitalThermometerApp.Services;

public class PrecisionDigitalThermometerServiceStubForTesting : IPrecisionDigitalThermometerService
{
    private const int DelayInterval = 1000;

    private readonly Thread _thread;
    private readonly object _lockObject = new();

    public PrecisionDigitalThermometerServiceStubForTesting()
    {
        _thread = new Thread(ReadTemperature);
        _thread.Start();
    }

    public void SelfTest()
    {
    }

    public void ToggleBacklight(bool on)
    {
    }

    public void Beep()
    {
    }

    public double Temperature { get; private set; }

    private void ReadTemperature(object? obj)
    {
        while (true)
        {
            Thread.Sleep(DelayInterval);
            string message = (Random.Shared.NextDouble() * 100).ToString();
            Temperature = double.Parse(message);
        }
    }
}
