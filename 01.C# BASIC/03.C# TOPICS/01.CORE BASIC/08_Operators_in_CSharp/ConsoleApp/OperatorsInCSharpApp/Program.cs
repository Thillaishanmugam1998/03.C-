using System;

namespace OperatorsInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Operators in C#

            Operators are symbols used to perform operations on values.
            Common operator groups include arithmetic, comparison, and logical operators.
        */
        #endregion

        #region Example
        int a = 10;
        int b = 5;

        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Is a greater than b? {a > b}");
        Console.WriteLine($"Are both conditions true? {(a > b && b > 0)}");
        #endregion

        #region Output
        /*
            Addition: 15
            Subtraction: 5
            Multiplication: 50
            Division: 2
            Is a greater than b? True
            Are both conditions true? True
        */
        #endregion
    }
}
