namespace GarbageCollectionInDotNetApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // The garbage collector automatically frees memory used by unreachable objects.
        // Most of the time, developers let it work automatically.
        #endregion

        #region Example
        long beforeAllocation = GC.GetTotalMemory(forceFullCollection: false);
        Console.WriteLine($"Memory before allocation: {beforeAllocation:N0} bytes");

        CreateTemporaryObjects();

        long afterAllocation = GC.GetTotalMemory(forceFullCollection: false);
        Console.WriteLine($"Memory after allocation: {afterAllocation:N0} bytes");

        GC.Collect();
        GC.WaitForPendingFinalizers();

        long afterCollection = GC.GetTotalMemory(forceFullCollection: true);
        Console.WriteLine($"Memory after forced collection: {afterCollection:N0} bytes");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Objects are created in managed memory.");
        Console.WriteLine("2. Unused objects can be reclaimed by the garbage collector.");
        Console.WriteLine("3. Manual collection is possible but should be rare in real apps.");
        #endregion
    }

    private static void CreateTemporaryObjects()
    {
        for (int i = 0; i < 5000; i++)
        {
            DemoObject demoObject = new(i);
            _ = demoObject.Id;
        }
    }
}

internal class DemoObject
{
    public int Id { get; }

    public DemoObject(int id)
    {
        Id = id;
    }
}
