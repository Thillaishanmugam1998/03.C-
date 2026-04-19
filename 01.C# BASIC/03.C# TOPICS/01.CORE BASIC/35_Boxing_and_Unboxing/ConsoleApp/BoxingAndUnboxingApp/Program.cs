using System;

namespace BoxingAndUnboxingApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Boxing and Unboxing

            Boxing converts a value type into an object.
            Unboxing converts that object back to the original value type.
        */
        #endregion

        #region Example
        int number = 25;
        object boxedValue = number;
        int unboxedValue = (int)boxedValue;

        Console.WriteLine($"Original value: {number}");
        Console.WriteLine($"Boxed value: {boxedValue}");
        Console.WriteLine($"Unboxed value: {unboxedValue}");
        #endregion

        #region Output
        /*
            Original value: 25
            Boxed value: 25
            Unboxed value: 25
        */
        #endregion
    }
}
