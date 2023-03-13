using Microsoft.AspNetCore.Mvc;
using RokarBitWebApi.Models;
using RokarBitWebApi.Services;

namespace RokarBitWebApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class BitController : ControllerBase
{
    private readonly IBitService _bitService;

    public BitController(IBitService bitService)
    {
        _bitService = bitService;
    }

    [HttpGet]
    public ReplayMessageDto Connect()
    {
        try
        {
            _bitService.Connect();
            return new ReplayMessageDto { Success = true };
        }
        catch (Exception e)
        {
            return new ReplayMessageDto
            {
                Success = false,
                ErrorMessage = e.Message
            };
        }
    }

    [HttpGet]
    public ReplayMessageDto Disconnect()
    {
        try
        {
            _bitService.Disconnect();
            return new ReplayMessageDto { Success = true };
        }
        catch (Exception e)
        {
            return new ReplayMessageDto
            {
                Success = false,
                ErrorMessage = e.Message
            };
        }
    }

    [HttpGet]
    public BitReplayMessageDto GetPowerBit()
    {
        try
        {
            var data = _bitService.GetPowerBit();
            return new BitReplayMessageDto { Success = true, Data = data };
        }
        catch (Exception e)
        {
            return new BitReplayMessageDto
            {
                Success = false,
                ErrorMessage = e.Message
            };
        }
    }

    [HttpGet]
    public BitReplayMessageDto GetContinuousBit()
    {
        try
        {
            var data = _bitService.GetContinuousBit();
            return new BitReplayMessageDto { Success = true, Data = data };
        }
        catch (Exception e)
        {
            return new BitReplayMessageDto
            {
                Success = false,
                ErrorMessage = e.Message
            };
        }
    }
}