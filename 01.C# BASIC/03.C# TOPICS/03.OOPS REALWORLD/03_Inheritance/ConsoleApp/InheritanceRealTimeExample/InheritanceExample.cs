namespace InheritanceRealTimeExample;

public class InheritanceExample
{
    public void Run()
    {
        #region Explanation
        Console.WriteLine("INHERITANCE - REAL-TIME EXAMPLE");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Inheritance allows one class to reuse the properties and methods of another class.");
        Console.WriteLine("In this example, Manager and Developer inherit common employee details from the Employee class.");
        Console.WriteLine();
        #endregion

        #region RealWorldExample
        Console.WriteLine("Real-World Analogy:");
        Console.WriteLine("In a company, all employees have common details such as name and employee ID.");
        Console.WriteLine("At the same time, a manager has manager-specific responsibilities and a developer has developer-specific responsibilities.");
        Console.WriteLine("Instead of repeating common employee information in every role, we place shared details in one base employee class.");
        Console.WriteLine();
        #endregion

        #region CodeExample
        var manager = new Manager("Meena", 101, "Operations");
        manager.ShowBasicInfo();
        Console.WriteLine($"Department    : {manager.Department}");
        manager.ApproveLeave();
        Console.WriteLine();

        var developer = new Developer("Rahul", 205, "C#");
        developer.ShowBasicInfo();
        Console.WriteLine($"Technology    : {developer.PrimaryTechnology}");
        developer.WriteCode();
        Console.WriteLine();
        #endregion

        #region Output
        Console.WriteLine("Key Learning:");
        Console.WriteLine("Common employee data is inherited from the Employee base class.");
        Console.WriteLine("Derived classes reuse shared behavior and add their own specialized behavior.");
        #endregion
    }
}
