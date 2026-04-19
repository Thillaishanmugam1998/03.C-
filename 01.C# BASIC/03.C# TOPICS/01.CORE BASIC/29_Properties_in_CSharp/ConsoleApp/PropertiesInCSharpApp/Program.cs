using System;

namespace PropertiesInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Properties in C#

            Properties provide controlled access to data in a class.
            They use get and set accessors.
        */
        #endregion

        #region Example
        Employee employee = new()
        {
            Name = "Arun",
            Age = 25
        };

        Console.WriteLine($"Employee Name: {employee.Name}");
        Console.WriteLine($"Employee Age: {employee.Age}");
        #endregion

        #region Output
        /*
            Employee Name: Arun
            Employee Age: 25
        */
        #endregion
    }
}

internal class Employee
{
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }
}
