using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using System;
using System.Text;
using System.Threading.Tasks;

public class MqttClientWrapper
{
    private IManagedMqttClient _mqttClient;
    private readonly string _brokerUrl;
    private readonly string _clientId;

    public MqttClientWrapper(string brokerUrl, string clientId)
    {
        _brokerUrl = brokerUrl;
        _clientId = clientId;
    }

    public async Task Connect()
    {
        var options = new MqttClientOptionsBuilder()
            .WithTcpServer(_brokerUrl)
            .WithClientId(_clientId)
            .Build();

        var managedOptions = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
            .WithClientOptions(options)
            .Build();

        _mqttClient = new MqttFactory().CreateManagedMqttClient();

        await _mqttClient.StartAsync(managedOptions);
    }

    public async Task SendMessage(string topic, string message)
    {
        var mqttMessage = new MqttApplicationMessageBuilder()
            .WithTopic(topic)
            .WithPayload(message)
            .WithRetainFlag(false)
            .Build();

    }

    private void HandleIncomingMessage(MqttApplicationMessageReceivedEventArgs e)
    {
        var topic = e.ApplicationMessage.Topic;
        var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);

        Console.WriteLine($"Received message: Topic = {topic}, Payload = {payload}");
    }
}
