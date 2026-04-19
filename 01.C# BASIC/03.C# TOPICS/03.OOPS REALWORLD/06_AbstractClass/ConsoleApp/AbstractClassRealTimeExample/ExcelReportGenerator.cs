namespace AbstractClassRealTimeExample;

public class ExcelReportGenerator : ReportGenerator
{
    protected override void Export()
    {
        Console.WriteLine("Exporting report as Excel.");
    }
}
