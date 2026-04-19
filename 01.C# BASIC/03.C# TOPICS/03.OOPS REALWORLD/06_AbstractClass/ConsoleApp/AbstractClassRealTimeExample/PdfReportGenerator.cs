namespace AbstractClassRealTimeExample;

public class PdfReportGenerator : ReportGenerator
{
    protected override void Export()
    {
        Console.WriteLine("Exporting report as PDF.");
    }
}
