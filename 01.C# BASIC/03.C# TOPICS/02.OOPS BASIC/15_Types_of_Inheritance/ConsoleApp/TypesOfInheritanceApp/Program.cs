namespace TypesOfInheritanceApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // C# supports single, multilevel, and hierarchical inheritance with classes.
        // This example demonstrates all three patterns in a simple learning model.
        #endregion

        #region Example
        Manager manager = new() { Name = "Harish", EmployeeCode = "EMP200", TeamSize = 8 };
        manager.ShowPersonInfo();
        manager.ShowEmployeeInfo();
        manager.ShowManagerInfo();

        Developer developer = new() { Name = "Sana", EmployeeCode = "EMP350", PrimaryLanguage = "C#" };
        developer.ShowPersonInfo();
        developer.ShowDeveloperInfo();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Single inheritance: Employee inherits Person.");
        Console.WriteLine("2. Multilevel inheritance: Manager inherits Employee which inherits Person.");
        Console.WriteLine("3. Hierarchical inheritance: Developer and Manager both inherit from Employee.");
        #endregion
    }
}

internal class Person
{
    public string Name { get; set; } = string.Empty;

    public void ShowPersonInfo()
    {
        Console.WriteLine($"Person Name: {Name}");
    }
}

internal class Employee : Person
{
    public string EmployeeCode { get; set; } = string.Empty;

    public void ShowEmployeeInfo()
    {
        Console.WriteLine($"Employee Code: {EmployeeCode}");
    }
}

internal class Manager : Employee
{
    public int TeamSize { get; set; }

    public void ShowManagerInfo()
    {
        Console.WriteLine($"Manages team size: {TeamSize}");
    }
}

internal class Developer : Employee
{
    public string PrimaryLanguage { get; set; } = string.Empty;

    public void ShowDeveloperInfo()
    {
        Console.WriteLine($"Primary Language: {PrimaryLanguage}");
    }
}
