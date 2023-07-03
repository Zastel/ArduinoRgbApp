namespace ArduinoRgbApp.Core.Abstractions.Interfaces;

public interface ISerialHelper
{
    /// <summary>
    /// Connects the serial interface.
    /// </summary>
    public void Connect();

    /// <summary>
    /// Disconnects the serial interface.
    /// </summary>
    public void Disconnect();

    /// <summary>
    /// Sends the Rainbow mode message to the arduino.
    /// </summary>
    public void RainbowMode();

    /// <summary>
    /// Sends the Default mode message to the arduino.
    /// </summary>
    public void DefaultMode();

    /// <summary>
    /// Sends the static RGB color mode message with the color values to the arduino.
    /// </summary>
    /// <param name="red">0-255 value for the red color.</param>
    /// <param name="green">0-255 value for the green color.</param>
    /// <param name="blue">0-255 value for the blue color.</param>
    public void ApplyStaticColor(int red, int green, int blue);
}