namespace AbstractClassesInApplicationApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Abstract classes are useful in applications when several objects share common details
        // but must implement some behavior differently.
        #endregion

        #region Example
        Employee manager = new Manager("Karthik", "EMP101");
        Employee developer = new Developer("Maya", "EMP205");

        manager.ShowProfile();
        manager.DoWork();

        developer.ShowProfile();
        developer.DoWork();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. The abstract base class provides shared employee data.");
        Console.WriteLine("2. Each derived class implements work behavior differently.");
        #endregion
    }
}

internal abstract class Employee
{
    protected Employee(string name, string employeeCode)
    {
        Name = name;
        EmployeeCode = employeeCode;
    }

    public string Name { get; }
    public string EmployeeCode { get; }

    public void ShowProfile()
    {
        Console.WriteLine($"Employee: {Name}, Code: {EmployeeCode}");
    }

    public abstract void DoWork();
}

internal sealed class Manager : Employee
{
    public Manager(string name, string employeeCode) : base(name, employeeCode)
    {
    }

    public override void DoWork()
    {
        Console.WriteLine($"{Name} is planning tasks and reviewing progress.");
    }
}

internal sealed class Developer : Employee
{
    public Developer(string name, string employeeCode) : base(name, employeeCode)
    {
    }

    public override void DoWork()
    {
        Console.WriteLine($"{Name} is writing and testing application code.");
    }
}
