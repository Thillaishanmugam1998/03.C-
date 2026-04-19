namespace InterfaceRealTimeExample;

public class BlueDartTracker : IShipmentTracker
{
    public void TrackShipment(string trackingNumber)
    {
        Console.WriteLine($"BlueDart tracking started for package {trackingNumber}.");
    }
}
