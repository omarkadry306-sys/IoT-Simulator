# Azure IoT Hub Simulator

A simple C# application that simulates an IoT device connecting to Azure IoT Hub and sending telemetry data.

## Features

- Connects to Azure IoT Hub using MQTT protocol
- Sends temperature and humidity telemetry data every 5 seconds
- JSON formatted messages
- Simple and lightweight implementation

## Prerequisites

- .NET 6.0 or higher
- Azure IoT Hub instance
- Device connection string from Azure IoT Hub

## Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/omarkadry306-sys/IoT-Simulator.git
   cd IoT-Simulator
   ```

2. **Update connection string:**
   Edit `Program.cs` and replace:
   ```csharp
   string deviceConnectionString = "HostName=YOUR_HUB.azure-devices.net;DeviceId=YOUR_DEVICE;SharedAccessKey=YOUR_KEY";
   ```
   With your actual Azure IoT Hub connection string.

3. **Build and run:**
   ```bash
   dotnet restore
   dotnet run
   ```

## Usage

Once running, the simulator will:
- Connect to Azure IoT Hub
- Send telemetry messages with random temperature (15-35°C) and humidity (30-90%) values
- Log each message to the console
- Continue sending data every 5 seconds

## Project Structure

- `Program.cs` - Main application code
- `IoT-Simulator.csproj` - Project configuration and dependencies

## Dependencies

- Microsoft.Azure.Devices.Client v1.42.0

## License

MIT
