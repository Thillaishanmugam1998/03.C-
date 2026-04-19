namespace PartialClassAndPartialMethodsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // A partial class can be split across multiple files.
        // A partial method can be declared in one part and implemented in another part.
        #endregion

        #region Example
        Student student = new("Lavanya", "C# OOP");
        student.ShowDetails();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. The Student class is formed from multiple partial declarations.");
        Console.WriteLine("2. The partial method is implemented in a different file.");
        #endregion
    }
}
