namespace MultipleInheritanceRealtimeExampleApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // One real application component may support several capabilities.
        // In C#, interfaces help us combine those capabilities cleanly.
        #endregion

        #region Example
        ReportService service = new();
        service.Print();
        service.SendEmail();
        service.Export();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. ReportService supports multiple behaviors through interfaces.");
        Console.WriteLine("2. This is the practical alternative to multiple class inheritance in C#.");
        #endregion
    }
}

internal interface IPrintable
{
    void Print();
}

internal interface IEmailable
{
    void SendEmail();
}

internal interface IExportable
{
    void Export();
}

internal sealed class ReportService : IPrintable, IEmailable, IExportable
{
    public void Print()
    {
        Console.WriteLine("Report printed successfully.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Report emailed successfully.");
    }

    public void Export()
    {
        Console.WriteLine("Report exported successfully.");
    }
}
