namespace RokarBitWebApi.Services;

public interface IBitService
{
    void Connect();
    void Disconnect();
    Dictionary<string, bool> GetPowerBit();
    Dictionary<string, bool> GetContinuousBit();
}