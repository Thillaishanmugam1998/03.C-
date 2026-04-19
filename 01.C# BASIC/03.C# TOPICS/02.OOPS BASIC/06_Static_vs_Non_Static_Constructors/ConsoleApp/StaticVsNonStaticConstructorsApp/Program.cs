namespace StaticVsNonStaticConstructorsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // A static constructor runs once for the class.
        // A non-static constructor runs every time a new object is created.
        #endregion

        #region Example
        School firstStudent = new("Divya");
        School secondStudent = new("Rahul");

        firstStudent.ShowDetails();
        secondStudent.ShowDetails();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Shared class data is initialized once.");
        Console.WriteLine("2. Instance data is initialized for every object.");
        #endregion
    }
}

internal class School
{
    public static string SchoolName { get; }
    public string StudentName { get; }

    static School()
    {
        SchoolName = "Green Valley School";
        Console.WriteLine("Static constructor executed once.");
    }

    public School(string studentName)
    {
        StudentName = studentName;
        Console.WriteLine($"Non-static constructor executed for {StudentName}.");
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{StudentName} belongs to {SchoolName}.");
    }
}
