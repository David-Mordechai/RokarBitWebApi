namespace RokarBitWebApi.Models;

public class BitReplayDto
{
    public bool Success { get; set; }
    public string ErrorMessage { get; set; } = string.Empty;
    public Dictionary<string, bool> Data { get; set; } = new();
}