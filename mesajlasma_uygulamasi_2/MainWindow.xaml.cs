using System;
using System.Collections.Generic;
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


namespace mesajlasma_uygulamasi_2
{
    public partial class MainWindow : Window
    {
        private MqttClientWrapper _mqttClient;

        public MainWindow()
        {
            InitializeComponent();

            string brokerUrl = "mqtt://broker.example.com";
            string clientId = Guid.NewGuid().ToString();

            _mqttClient = new MqttClientWrapper(brokerUrl, clientId);
        }

        private async void ConnectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await _mqttClient.Connect();
                MessageBox.Show("Connected to MQTT broker successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string topic = TopicTextBox.Text;
            string message = MessageTextBox.Text;

            try
            {
                await _mqttClient.SendMessage(topic, message);
                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}