namespace StaticClassApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Static classes hold only static members and cannot be instantiated.
        // They are useful for helper logic that does not need object state.
        #endregion

        #region Example
        Console.WriteLine($"Add: {MathUtility.Add(12, 8)}");
        Console.WriteLine($"Subtract: {MathUtility.Subtract(12, 8)}");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Static members are accessed using the class name.");
        Console.WriteLine("2. No object is created for a static class.");
        #endregion
    }
}

internal static class MathUtility
{
    public static int Add(int first, int second)
    {
        return first + second;
    }

    public static int Subtract(int first, int second)
    {
        return first - second;
    }
}
