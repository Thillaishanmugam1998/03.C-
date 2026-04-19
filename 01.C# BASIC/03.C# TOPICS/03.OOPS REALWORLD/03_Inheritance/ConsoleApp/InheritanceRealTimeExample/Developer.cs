namespace InheritanceRealTimeExample;

public class Developer : Employee
{
    public string PrimaryTechnology { get; }

    public Developer(string name, int employeeId, string primaryTechnology)
        : base(name, employeeId)
    {
        PrimaryTechnology = primaryTechnology;
    }

    public void WriteCode()
    {
        Console.WriteLine($"Developer {Name} is building features using {PrimaryTechnology}.");
    }
}
