namespace InheritanceRealTimeExample;

public class Manager : Employee
{
    public string Department { get; }

    public Manager(string name, int employeeId, string department)
        : base(name, employeeId)
    {
        Department = department;
    }

    public void ApproveLeave()
    {
        Console.WriteLine($"Manager {Name} approved a leave request for the {Department} department.");
    }
}
