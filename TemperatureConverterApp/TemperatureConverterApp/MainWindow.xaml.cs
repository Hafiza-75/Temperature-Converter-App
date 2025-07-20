using System;
using System.Windows;

namespace TemperatureConverterApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = FahrenheitInput.Text;

            if (double.TryParse(inputText, out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                ResultLabel.Content = $"Result: {celsius:F2} °C";
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric temperature.",
                                "Invalid Input",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
    }
}
