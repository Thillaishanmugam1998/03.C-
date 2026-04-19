namespace ConstructorsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // A constructor runs automatically when an object is created.
        // It is used to set initial values for the object.
        #endregion

        #region Example
        Employee employee = new();
        employee.ShowDetails();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. The constructor runs without being called directly.");
        Console.WriteLine("2. It prepares the object with starting values.");
        #endregion
    }
}

internal class Employee
{
    public string Name { get; }
    public string Department { get; }

    public Employee()
    {
        Name = "New Employee";
        Department = "Training";
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Department: {Department}");
    }
}
