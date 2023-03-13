using RokarBitWebApi.Models;

namespace RokarBitWebApi.Services;

public class BitService : IBitService
{
    private readonly ILogger<BitService> _logger;
    private readonly SerialPort _serialPort;

    public BitService(ILogger<BitService> logger, Settings settings)
    {
        _logger = logger;
        _serialPort = settings.SerialPort;
    }

    public void Connect()
    {
        try
        {
            if (string.IsNullOrEmpty(_serialPort.Name))
            {
                // at first request to connect the serial port name will be empty
                // perform here the logic of finding the serial port
                // if serial port was found then set the settings.SerialPort.Name with this port for the next usage.
                // note that this setting will be available as long as this application running
                // foreach request until service will go down,
                _serialPort.Name = "com0";
            }
            // logic to connect to serial port
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Fail to connect, error: {ErrorMessage}", e.Message);
            throw new Exception("Reason why connect failed");
        }
    }

    public void Disconnect()
    {
        try
        {
            // logic to disconnect to serial port
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Fail to disconnect, error: {ErrorMessage}", e.Message);
            throw new Exception("Reason why disconnect failed");
        }
    }

    public Dictionary<string, bool> GetPowerBit()
    {
        try
        {
            // logic to get power bit data
            return new Dictionary<string, bool>
            {
                {"Go-NoGo", true}
            };
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Fail to get power bit, error: {ErrorMessage}", e.Message);
            throw new Exception("Reason why get power bit failed");
        }
    }

    public Dictionary<string, bool> GetContinuousBit()
    {
        try
        {
            // logic to get continuous bit data
            return new Dictionary<string, bool>
            {
                {"Go-NoGo", true}
            };
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Fail to get continuous bit, error: {ErrorMessage}", e.Message);
            throw new Exception("Reason why get continuous bit failed");
        }
    }
}