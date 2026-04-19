namespace InterfaceRealTimeExample;

public class InterfaceExample
{
    public void Run()
    {
        #region Explanation
        Console.WriteLine("INTERFACE - REAL-TIME EXAMPLE");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("An interface defines a contract that classes must follow.");
        Console.WriteLine("It tells what should be done, but not how it should be done.");
        Console.WriteLine();
        #endregion

        #region RealWorldExample
        Console.WriteLine("Real-World Analogy:");
        Console.WriteLine("Different courier companies may provide shipment tracking.");
        Console.WriteLine("A shopping portal only expects one capability: track the shipment.");
        Console.WriteLine("Each courier company follows that contract in its own way.");
        Console.WriteLine();
        #endregion

        #region CodeExample
        var portal = new TrackingPortal();

        IShipmentTracker blueDart = new BlueDartTracker();
        IShipmentTracker dtdc = new DtdcTracker();

        portal.ShowTrackingStatus(blueDart, "BD123456789");
        portal.ShowTrackingStatus(dtdc, "DT987654321");
        Console.WriteLine();
        #endregion

        #region Output
        Console.WriteLine("Key Learning:");
        Console.WriteLine("Interfaces create a common contract for unrelated classes.");
        Console.WriteLine("The portal depends on the interface, not on any specific courier company.");
        #endregion
    }
}
