namespace InterfaceInterviewQAApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // This program presents short interview-style answers about interfaces.
        // It also demonstrates a simple interface implementation.
        #endregion

        #region Example
        Console.WriteLine("Q1. What is an interface?");
        Console.WriteLine("A1. It is a contract that defines members a class must implement.");

        Console.WriteLine();
        Console.WriteLine("Q2. Why do we use interfaces?");
        Console.WriteLine("A2. To achieve flexibility, loose coupling, and support multiple behaviors.");

        Console.WriteLine();
        Console.WriteLine("Q3. Can a class implement multiple interfaces?");
        Console.WriteLine("A3. Yes. C# supports implementing multiple interfaces.");

        IPrinter printer = new ConsolePrinter();
        printer.Print();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Interfaces define required behavior.");
        Console.WriteLine("2. They are commonly discussed in interviews with abstract classes.");
        #endregion
    }
}

internal interface IPrinter
{
    void Print();
}

internal sealed class ConsolePrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Document printed to console.");
    }
}
