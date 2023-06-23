using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string brokerUrl = "mqtt://broker.example.com";
        string clientId = Guid.NewGuid().ToString();

        var mqttClient = new MqttClientWrapper(brokerUrl, clientId);

        try
        {
            await mqttClient.Connect();

            string topic = "mytopic";
            string message = "Hello, MQTT!";
            await mqttClient.SendMessage(topic, message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
