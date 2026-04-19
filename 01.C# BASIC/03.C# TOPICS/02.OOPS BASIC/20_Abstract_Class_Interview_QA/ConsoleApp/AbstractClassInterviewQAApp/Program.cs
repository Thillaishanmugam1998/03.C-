namespace AbstractClassInterviewQAApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // This topic uses a small console Q&A format to reinforce interview-ready answers.
        // The example also shows that abstract classes can contain both concrete and abstract members.
        #endregion

        #region Example
        Console.WriteLine("Q1. Can we create an object of an abstract class?");
        Console.WriteLine("A1. No. An abstract class cannot be instantiated directly.");

        Console.WriteLine();
        Console.WriteLine("Q2. Can an abstract class contain normal methods?");
        Console.WriteLine("A2. Yes. It can contain both implemented methods and abstract methods.");

        Console.WriteLine();
        Console.WriteLine("Q3. Why do we use abstract classes?");
        Console.WriteLine("A3. To define a common base with shared code and mandatory behavior for child classes.");

        Report report = new SalesReport();
        report.ShowTitle();
        report.Generate();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Abstract classes support partial implementation.");
        Console.WriteLine("2. Derived classes complete the required abstract behavior.");
        #endregion
    }
}

internal abstract class Report
{
    public void ShowTitle()
    {
        Console.WriteLine("Report generation started.");
    }

    public abstract void Generate();
}

internal class SalesReport : Report
{
    public override void Generate()
    {
        Console.WriteLine("Sales report generated successfully.");
    }
}
