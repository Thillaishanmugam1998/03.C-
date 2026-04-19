namespace MethodOverloadingApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Method overloading means the same method name can accept different inputs.
        // The compiler chooses the correct version based on the arguments.
        #endregion

        #region Example
        Calculator calculator = new();

        Console.WriteLine($"Add two integers: {calculator.Add(5, 7)}");
        Console.WriteLine($"Add three integers: {calculator.Add(2, 4, 6)}");
        Console.WriteLine($"Add two decimals: {calculator.Add(2.5, 4.2)}");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. One method name can have many signatures.");
        Console.WriteLine("2. Overloading is compile-time polymorphism.");
        #endregion
    }
}

internal sealed class Calculator
{
    public int Add(int first, int second)
    {
        return first + second;
    }

    public int Add(int first, int second, int third)
    {
        return first + second + third;
    }

    public double Add(double first, double second)
    {
        return first + second;
    }
}
