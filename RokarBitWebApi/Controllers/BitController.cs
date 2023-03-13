using Microsoft.AspNetCore.Mvc;
using RokarBitWebApi.Models;

namespace RokarBitWebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class BitController : ControllerBase
{
    private readonly ILogger<BitController> _logger;
    private readonly Settings _settings;

    public BitController(ILogger<BitController> logger, Settings settings)
    {
        _logger = logger;
        _settings = settings;
    }

    [HttpGet]
    public BitReplayDto Connect()
    {
        _logger.LogInformation("Connect requested");
        var result = new BitReplayDto
        {
            Success = true,
        };
        result.Data.Add("Go_NoGo", true);
        return result;
    }

    [HttpGet]
    public BitReplayDto Disconnect()
    {
        _logger.LogInformation("Disconnect requested");
        var result = new BitReplayDto
        {
            Success = true,
        };
        result.Data.Add("Go_NoGo", true);
        return result;
    }

    [HttpGet]
    public BitReplayDto PowerBit()
    {
        _logger.LogInformation("PowerBit requested");
        var result = new BitReplayDto
        {
            Success = true,
        };
        result.Data.Add("Go_NoGo", true);
        return result;
    }

    [HttpGet]
    public BitReplayDto ContinuousBit()
    {
        _logger.LogInformation("ContinuousBit requested");

        var result = new BitReplayDto
        {
            Success = false,
            ErrorMessage = "Could not connect to serial port."
        };

        return result;
    }
}