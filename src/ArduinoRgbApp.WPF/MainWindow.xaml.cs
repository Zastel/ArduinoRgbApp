using System.IO.Ports;
using System.Windows;
using System.Windows.Controls;
using ArduinoRgbApp.WPF.Helpers.Communication;

namespace ArduinoRgbApp.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialHelper? _serial;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConnectButtonClick(object sender, RoutedEventArgs e)
        {
            if (_serial != null)
            {
                _serial.Connect();
                ConnectSerialButton.Visibility = Visibility.Hidden;
                DisconnectSerialButton.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("No serial port connected. Please connect one and try again.");
            }
        }

        private void DisconnectButtonClick(object sender, RoutedEventArgs e)
        {
            if (_serial != null)
            {
                _serial.Disconnect();
                ConnectSerialButton.Visibility = Visibility.Visible;
                DisconnectSerialButton.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("No serial port connected. Please connect one and try again.");
            }
        }

        private void RefreshButtonClick(object sender, RoutedEventArgs e)
        {
            SerialComboBox.ItemsSource = SerialPort.GetPortNames();
        }

        private void ColorButtonClick(object sender, RoutedEventArgs e)
        {
            if (_serial != null)
            {
                var red = (int)RedSlider.Value;
                var green = (int)GreenSlider.Value;
                var blue = (int)BlueSlider.Value;
                _serial.ApplyStaticColor(red,green,blue);
            }
            else
            {
                MessageBox.Show("No serial port connected. Please connect one and try again.");
            }
        }

        private void RainbowButtonClick(object sender, RoutedEventArgs e)
        {
            if (_serial != null)
            {
                _serial.RainbowMode();
            }
            else
            {
                MessageBox.Show("No serial port connected. Please connect one and try again.");
            }
        }

        private void WrgbButtonClick(object sender, RoutedEventArgs e)
        {
            if (_serial != null)
            {
                _serial.DefaultMode();
            }
            else
            {
                MessageBox.Show("No serial port connected. Please connect one and try again.");
            }
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