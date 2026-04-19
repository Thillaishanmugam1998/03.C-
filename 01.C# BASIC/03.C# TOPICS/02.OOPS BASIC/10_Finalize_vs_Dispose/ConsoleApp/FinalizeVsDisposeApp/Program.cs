namespace FinalizeVsDisposeApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Dispose is used for predictable cleanup.
        // Finalize is a backup cleanup mechanism that runs later through the garbage collector.
        #endregion

        #region Example
        using (DemoConnection connection = new("LearningDatabase"))
        {
            connection.Open();
        }

        Console.WriteLine("Dispose has already executed because the using block ended.");
        Console.WriteLine("A finalizer exists as a backup, but we should not depend on it.");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Dispose gives deterministic cleanup.");
        Console.WriteLine("2. Finalize is non-deterministic and should be a fallback only.");
        #endregion
    }
}

internal class DemoConnection : IDisposable
{
    private bool _disposed;
    private readonly string _connectionName;

    public DemoConnection(string connectionName)
    {
        _connectionName = connectionName;
        Console.WriteLine($"{_connectionName} created.");
    }

    public void Open()
    {
        if (_disposed)
        {
            throw new ObjectDisposedException(nameof(DemoConnection));
        }

        Console.WriteLine($"{_connectionName} opened.");
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        Console.WriteLine($"{_connectionName} disposed explicitly.");
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    ~DemoConnection()
    {
        Console.WriteLine($"{_connectionName} finalizer executed.");
    }
}
