namespace AbstractClassRealTimeExample;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        Console.WriteLine("Collecting data...");
        Console.WriteLine("Formatting report...");
        Export();
        Console.WriteLine("Report generation completed.");
    }

    // Each report type must decide its own export behavior.
    protected abstract void Export();
}
