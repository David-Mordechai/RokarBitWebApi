namespace RokarBitWebApi.Models;

public class BitReplayMessageDto : ReplayMessageDto
{
    
    public Dictionary<string, bool> Data { get; set; } = new();
}