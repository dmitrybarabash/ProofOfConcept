namespace PrecisionDigitalThermometerApp.Interfaces;

public interface IPrecisionDigitalThermometerService
{
    void SelfTest();

    void ToggleBacklight(bool on);

    void Beep();

    double Temperature { get; }
}
