using System;

namespace StaticVsNonStaticMembersApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Static vs Non-Static Members

            Static members belong to the class.
            Non-static members belong to each object.
        */
        #endregion

        #region Example
        Student firstStudent = new("Arun");
        Student secondStudent = new("Priya");

        Console.WriteLine($"Static School Name: {Student.SchoolName}");
        Console.WriteLine($"First Student Name: {firstStudent.Name}");
        Console.WriteLine($"Second Student Name: {secondStudent.Name}");
        #endregion

        #region Output
        /*
            Static School Name: C# Academy
            First Student Name: Arun
            Second Student Name: Priya
        */
        #endregion
    }
}

internal class Student
{
    public static string SchoolName { get; } = "C# Academy";

    public Student(string name)
    {
        Name = name;
    }

    public string Name { get; }
}
