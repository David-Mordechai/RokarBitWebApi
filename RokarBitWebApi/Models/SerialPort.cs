namespace RokarBitWebApi.Models;

public class SerialPort
{
    public string Name { get; set; } = "com0";
    public long BindleRate { get; set; }
    public string Parity { get; set; }
    public string DataBits { get; set; }
    public string StopBits { get; set;}
}