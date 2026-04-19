using System;

namespace TypeCastingInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Type Casting in C#

            Type casting means converting a value from one data type to another.
            It can be implicit when safe, or explicit when data could be lost.
        */
        #endregion

        #region Example
        int number = 50;
        double implicitCast = number;

        double price = 99.99;
        int explicitCast = (int)price;

        Console.WriteLine($"Original int value: {number}");
        Console.WriteLine($"After implicit casting to double: {implicitCast}");
        Console.WriteLine($"Original double value: {price}");
        Console.WriteLine($"After explicit casting to int: {explicitCast}");
        #endregion

        #region Output
        /*
            Original int value: 50
            After implicit casting to double: 50
            Original double value: 99.99
            After explicit casting to int: 99
        */
        #endregion
    }
}
