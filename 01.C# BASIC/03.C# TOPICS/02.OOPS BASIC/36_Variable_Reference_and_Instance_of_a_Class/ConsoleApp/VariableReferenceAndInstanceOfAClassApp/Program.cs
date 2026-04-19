namespace VariableReferenceAndInstanceOfAClassApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // A class variable usually stores a reference to an object instance.
        // When two variables point to the same object, changes through one reference are seen by the other.
        #endregion

        #region Example
        Student firstReference = new("Asha");
        Student secondReference = firstReference;

        secondReference.Name = "Asha Updated";

        Console.WriteLine($"First reference sees: {firstReference.Name}");
        Console.WriteLine($"Second reference sees: {secondReference.Name}");
        Console.WriteLine($"Same instance: {ReferenceEquals(firstReference, secondReference)}");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Variables store references for class objects.");
        Console.WriteLine("2. Two variables can point to the same instance.");
        #endregion
    }
}

internal sealed class Student
{
    public Student(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}
