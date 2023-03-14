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
            var serialPort = _serialPort.Name;
            // logic to connect to serial port
            // 1. try to connect to serialPort
            // 2. wait 5 seconds for response
            // 3. if connect to serialPort fail
            // 3.1 get all serial ports
            // 3.2 loop all serial ports and try to connect with interval of 5 seconds
            // 3.3 if none of the ports connected successfully trow exception with error "Connect Fail"
            // 4. if connect success update _serialPort.Name with this serial port name
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