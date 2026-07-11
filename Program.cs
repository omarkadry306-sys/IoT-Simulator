using Microsoft.Azure.Devices.Client;
using System;
using System.Text;
using System.Threading.Tasks;

class IoTSimulator
{
    static string deviceConnectionString = "HostName=YOUR_HUB.azure-devices.net;DeviceId=YOUR_DEVICE;SharedAccessKey=YOUR_KEY";
    static DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(deviceConnectionString, TransportType.Mqtt);

    static async Task Main()
    {
        Console.WriteLine("Azure IoT Hub Simulator Started...");
        while (true)
        {
            await SendMessage();
            await Task.Delay(5000);
        }
    }

    static async Task SendMessage()
    {
        var data = new { temperature = new Random().Next(15, 35), humidity = new Random().Next(30, 90) };
        var message = new Message(Encoding.ASCII.GetBytes(System.Text.Json.JsonSerializer.Serialize(data)));
        await deviceClient.SendEventAsync(message);
        Console.WriteLine($"Message sent: {data}");
    }
}
