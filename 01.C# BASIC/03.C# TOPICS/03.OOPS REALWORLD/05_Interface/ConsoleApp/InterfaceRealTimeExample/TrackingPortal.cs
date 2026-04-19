namespace InterfaceRealTimeExample;

public class TrackingPortal
{
    public void ShowTrackingStatus(IShipmentTracker tracker, string trackingNumber)
    {
        Console.WriteLine("Opening shipment tracking portal...");
        tracker.TrackShipment(trackingNumber);
    }
}
