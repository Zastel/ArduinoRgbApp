using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows;
using ArduinoRgbApp.Core.Abstractions.Interfaces;

namespace ArduinoRgbApp.WPF.Helpers.Communication;

public class SerialHelper : ISerialHelper
{
    /// <summary>
    /// Indicates if the serial port is connected or not.
    /// </summary>
    public bool IsSerialConnected = false;
    
    private readonly SerialPort _serialPort;

    /// <summary>
    /// Initializes the SerialHelper object.
    /// </summary>
    /// <param name="port">The name of the port to connect to.</param>
    public SerialHelper(string port)
    {
        _serialPort = new SerialPort(port, 115200);
    }
    
    /// <inheritdoc/>
    public void Connect()
    {
        try
        {
            _serialPort.Open();
            IsSerialConnected = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            MessageBox.Show("Please give a valid port number or check your connection.");
        }
    }
    
    /// <inheritdoc/>
    public void Disconnect()
    {
        try
        {
            _serialPort.Close();
            IsSerialConnected = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            MessageBox.Show("An error occured while disconnecting the serial port.");
        }
    }

    /// <inheritdoc/>
    public void RainbowMode()
    {
        SendMessage("rainbow");
    }

    /// <inheritdoc/>
    public void DefaultMode()
    {
        SendMessage("default");
    }

    /// <inheritdoc/>
    public void ApplyStaticColor(int red, int green, int blue)
    {
        Debug.WriteLine($"RGB|{red:000}|{green:000}|{blue:000}");
        SendMessage($"RGB|{red:000}|{green:000}|{blue:000}");
    }

    /// <summary>
    /// Sends a message via the connected serial port.
    /// </summary>
    /// <param name="message"></param>
    private void SendMessage(string message)
    {
        try
        {
            _serialPort.Write(message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            
        }
    }
}