namespace InheritanceRealTimeExample;

public class Employee
{
    public string Name { get; }
    public int EmployeeId { get; }

    public Employee(string name, int employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    public void ShowBasicInfo()
    {
        Console.WriteLine($"Employee Name : {Name}");
        Console.WriteLine($"Employee ID   : {EmployeeId}");
    }
}
