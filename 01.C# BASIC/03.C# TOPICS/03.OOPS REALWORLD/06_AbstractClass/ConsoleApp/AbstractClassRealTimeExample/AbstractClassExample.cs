namespace AbstractClassRealTimeExample;

public class AbstractClassExample
{
    public void Run()
    {
        #region Explanation
        Console.WriteLine("ABSTRACT CLASS - REAL-TIME EXAMPLE");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("An abstract class is a partially implemented base class that cannot be instantiated directly.");
        Console.WriteLine("It can contain both completed methods and abstract methods that derived classes must implement.");
        Console.WriteLine();
        #endregion

        #region RealWorldExample
        Console.WriteLine("Real-World Analogy:");
        Console.WriteLine("A reporting system may follow the same common steps to prepare reports.");
        Console.WriteLine("But the final export format can differ, such as PDF or Excel.");
        Console.WriteLine("The common workflow is shared, while the final export step is left to specific report types.");
        Console.WriteLine();
        #endregion

        #region CodeExample
        ReportGenerator pdfReport = new PdfReportGenerator();
        pdfReport.GenerateReport();
        Console.WriteLine();

        ReportGenerator excelReport = new ExcelReportGenerator();
        excelReport.GenerateReport();
        Console.WriteLine();
        #endregion

        #region Output
        Console.WriteLine("Key Learning:");
        Console.WriteLine("The abstract class provides shared workflow and forces derived classes to complete the missing step.");
        Console.WriteLine("This is useful when classes share a process but differ in some specific behavior.");
        #endregion
    }
}
