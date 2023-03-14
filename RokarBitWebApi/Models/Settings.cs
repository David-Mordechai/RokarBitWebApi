namespace RokarBitWebApi.Models;

public class Settings
{
    public long HttpPort { get; set; }
    public string IcdPath { get; set; }
    public SerialPort SerialPort { get; set; } = new();
}