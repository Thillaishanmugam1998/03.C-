namespace InterfaceInCSharpApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // An interface defines what a class must do.
        // Different classes can implement the same contract in different ways.
        #endregion

        #region Example
        ILogger logger = new FileLogger();
        logger.Log("Student progress saved.");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. ILogger describes a contract.");
        Console.WriteLine("2. FileLogger provides the actual implementation.");
        #endregion
    }
}

internal interface ILogger
{
    void Log(string message);
}

internal sealed class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[FileLogger] {message}");
    }
}
