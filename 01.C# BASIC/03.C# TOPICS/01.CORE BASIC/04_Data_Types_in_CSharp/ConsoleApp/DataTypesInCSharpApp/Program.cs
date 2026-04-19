using System;

namespace DataTypesInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Data Types in C#

            Data types tell the compiler what kind of value a variable will store.
            Different data types are used for numbers, text, true/false values,
            and more complex objects.
        */
        #endregion

        #region Example
        int age = 25;
        double height = 5.9;
        char grade = 'A';
        bool isLearning = true;
        string name = "Thillai";

        Console.WriteLine("Common C# Data Types:");
        Console.WriteLine($"int value: {age}");
        Console.WriteLine($"double value: {height}");
        Console.WriteLine($"char value: {grade}");
        Console.WriteLine($"bool value: {isLearning}");
        Console.WriteLine($"string value: {name}");
        #endregion

        #region Output
        /*
            Common C# Data Types:
            int value: 25
            double value: 5.9
            char value: A
            bool value: True
            string value: Thillai
        */
        #endregion
    }
}
