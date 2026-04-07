using System;

namespace VariablesInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Variables in C#

            A variable is a named storage location that holds a value.
            The value can change while the program is running.
        */
        #endregion

        #region Example
        string studentName = "Arun";
        int studentAge = 20;

        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Student Age: {studentAge}");

        studentAge = 21;
        Console.WriteLine($"Updated Student Age: {studentAge}");
        #endregion

        #region Output
        /*
            Student Name: Arun
            Student Age: 20
            Updated Student Age: 21
        */
        #endregion
    }
}
