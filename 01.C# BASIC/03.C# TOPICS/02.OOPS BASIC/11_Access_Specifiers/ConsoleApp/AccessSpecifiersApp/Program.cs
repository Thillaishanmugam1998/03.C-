namespace AccessSpecifiersApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Access specifiers decide where members can be used.
        // This helps protect data and control visibility in an application.
        #endregion

        #region Example
        Employee employee = new("Keerthi", 45000m);
        Console.WriteLine($"Public Name: {employee.Name}");
        Console.WriteLine($"Internal Employee Id: {employee.EmployeeId}");
        employee.ShowProtectedAccess();
        employee.DisplaySalary();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Public members are accessible outside the class.");
        Console.WriteLine("2. Private members are accessible only inside the class.");
        Console.WriteLine("3. Protected members are used through inheritance.");
        #endregion
    }
}

internal class Person
{
    protected string Department { get; set; } = "Accounts";
}

internal class Employee : Person
{
    public string Name { get; }
    internal int EmployeeId { get; } = 101;
    private decimal Salary { get; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public void DisplaySalary()
    {
        Console.WriteLine($"Private Salary accessed inside class: {Salary:C}");
    }

    public void ShowProtectedAccess()
    {
        Console.WriteLine($"Protected Department accessed in derived class: {Department}");
    }
}
