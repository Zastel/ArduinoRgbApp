using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Windows;
using ArduinoRgbApp.Core.Abstractions.Interfaces;

namespace ArduinoRgbApp.WPF.Helpers.Communication;

public class SerialHelper : ISerialHelper
{
    private readonly SerialPort _serialPort;

    public SerialHelper(string port)
    {
        _serialPort = new SerialPort(port, 115200);
    }
    
    public void Connect()
    {
        try
        {
            _serialPort.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            MessageBox.Show("Please give a valid port number or check your connection");
        }
    }

    public void Disconnect()
    {
        _serialPort.Close();
    }

    public void RainbowMode()
    {
        SendMessage("rainbow");
    }

    public void DefaultMode()
    {
        SendMessage("default");
    }

    public void ApplyStaticColor(int red, int green, int blue)
    {
        Debug.WriteLine($"RGB|{red.ToString("000")}|{green.ToString("000")}|{blue.ToString("000")}");
        SendMessage($"RGB|{red.ToString("000")}|{green.ToString("000")}|{blue.ToString("000")}");
    }

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