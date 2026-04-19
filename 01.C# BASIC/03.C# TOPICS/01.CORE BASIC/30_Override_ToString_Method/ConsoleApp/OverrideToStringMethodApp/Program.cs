using System;

namespace OverrideToStringMethodApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Override ToString Method

            Overriding ToString lets us control how an object
            is displayed as text.
        */
        #endregion

        #region Example
        Student student = new("Arun", 25);
        Console.WriteLine(student);
        #endregion

        #region Output
        /*
            Name: Arun, Age: 25
        */
        #endregion
    }
}

internal class Student
{
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; }

    public int Age { get; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
