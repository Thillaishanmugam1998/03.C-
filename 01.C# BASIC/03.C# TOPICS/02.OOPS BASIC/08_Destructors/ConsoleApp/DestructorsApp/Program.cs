namespace DestructorsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // A destructor is called by the garbage collector before object cleanup.
        // Its timing is not under our direct control.
        #endregion

        #region Example
        CreateTemporaryResource();

        Console.WriteLine("Requesting garbage collection for demo purposes...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. The object becomes eligible for cleanup after use.");
        Console.WriteLine("2. The destructor runs when the runtime decides to finalize it.");
        #endregion
    }

    private static void CreateTemporaryResource()
    {
        ResourceTracker tracker = new("Temporary file handler");
        tracker.Use();
    }
}

internal class ResourceTracker
{
    private readonly string _resourceName;

    public ResourceTracker(string resourceName)
    {
        _resourceName = resourceName;
        Console.WriteLine($"{_resourceName} created.");
    }

    public void Use()
    {
        Console.WriteLine($"{_resourceName} is being used.");
    }

    ~ResourceTracker()
    {
        Console.WriteLine($"{_resourceName} destructor executed during finalization.");
    }
}
