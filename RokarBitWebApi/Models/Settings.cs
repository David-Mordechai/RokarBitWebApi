namespace RokarBitWebApi.Models;

public class Settings
{
    public long HttpPort { get; set; }
    public string IcdPath { get; set; }
    public SerialPort SerialPort { get; set; } = new();
}

public class SerialPort
{
    public string Name { get; set; }
    public long BindleRate { get; set; }
    public string Parity { get; set; }
    public string DataBits { get; set; }
    public string StopBits { get; set;}
}