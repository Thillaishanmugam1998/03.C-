namespace ClassAndObjectsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // A class is a blueprint.
        // An object is the real instance created from that blueprint.
        #endregion

        #region Example
        Student student1 = new() { Name = "Arun", Course = "C# Fundamentals" };
        Student student2 = new() { Name = "Meena", Course = "OOP in C#" };

        student1.Introduce();
        student2.Introduce();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. One class can create multiple objects.");
        Console.WriteLine("2. Each object can store its own data.");
        Console.WriteLine("3. Objects use the same class behavior.");
        #endregion
    }
}

internal class Student
{
    public string Name { get; set; } = string.Empty;
    public string Course { get; set; } = string.Empty;

    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name} and I am learning {Course}.");
    }
}
