namespace SealedClassAndSealedMethodsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Sealed classes cannot be inherited.
        // Sealed override methods cannot be overridden again.
        #endregion

        #region Example
        PremiumReport report = new();
        report.Generate();

        Utility.ShowMessage();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Utility is sealed and cannot be inherited.");
        Console.WriteLine("2. PremiumReport seals the Generate override.");
        #endregion
    }
}

internal class Report
{
    public virtual void Generate()
    {
        Console.WriteLine("Base report generated.");
    }
}

internal class FinancialReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Financial report generated.");
    }
}

internal sealed class PremiumReport : FinancialReport
{
    public sealed override void Generate()
    {
        Console.WriteLine("Premium financial report generated.");
    }
}

internal sealed class Utility
{
    public static void ShowMessage()
    {
        Console.WriteLine("Utility static method executed.");
    }
}
