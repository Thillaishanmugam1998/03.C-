namespace MultipleInheritanceApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // C# does not support inheriting from multiple classes.
        // Instead, a class can implement multiple interfaces.
        #endregion

        #region Example
        MultiFunctionDevice device = new();
        device.Print();
        device.Scan();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Multiple inheritance of classes is not supported in C#.");
        Console.WriteLine("2. Multiple interface implementation provides similar flexibility.");
        #endregion
    }
}

internal interface IPrinter
{
    void Print();
}

internal interface IScanner
{
    void Scan();
}

internal sealed class MultiFunctionDevice : IPrinter, IScanner
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }
}
