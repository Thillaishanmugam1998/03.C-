namespace InterfaceRealTimeExample;

public class DtdcTracker : IShipmentTracker
{
    public void TrackShipment(string trackingNumber)
    {
        Console.WriteLine($"DTDC tracking started for package {trackingNumber}.");
    }
}
