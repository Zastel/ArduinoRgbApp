using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ArduinoRgbApp.WPF.Helpers.Communication;

namespace ArduinoRgbApp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialHelper _serial;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectButtonClick(object sender, RoutedEventArgs e)
        {
            _serial.Connect();
            ConnectSerialButton.Visibility = Visibility.Hidden;
            DisconnectSerialButton.Visibility = Visibility.Visible;
        }

        private void DisconnectButtonClick(object sender, RoutedEventArgs e)
        {
            _serial.Disconnect();
            ConnectSerialButton.Visibility = Visibility.Visible;
            DisconnectSerialButton.Visibility = Visibility.Hidden;
        }

        private void RefreshButtonClick(object sender, RoutedEventArgs e)
        {
            SerialComboBox.ItemsSource = SerialPort.GetPortNames();
        }

        private void ColorButtonClick(object sender, RoutedEventArgs e)
        {
            var red = (int)RedSlider.Value;
            var green = (int)GreenSlider.Value;
            var blue = (int)BlueSlider.Value;
            _serial.ApplyStaticColor(red,green,blue);
        }

        private void RainbowButtonClick(object sender, RoutedEventArgs e)
        {
            _serial.RainbowMode();
        }

        private void WrgbButtonClick(object sender, RoutedEventArgs e)
        {
            _serial.DefaultMode();
        }

        private void SliderRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RedValue.Content = (double)e.NewValue;
        }

        private void SliderGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GreenValue.Content = (double)e.NewValue;
        }

        private void SliderBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BlueValue.Content = (double)e.NewValue;
        }

        private void SerialComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _serial = new SerialHelper((string)SerialComboBox.SelectedItem);
        }


    }
}