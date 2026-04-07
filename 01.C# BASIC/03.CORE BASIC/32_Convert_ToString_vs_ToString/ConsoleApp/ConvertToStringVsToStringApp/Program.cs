using System;

namespace ConvertToStringVsToStringApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Convert.ToString vs ToString

            ToString is called on an object instance.
            Convert.ToString can safely handle null values.
        */
        #endregion

        #region Example
        object? value = null;
        int number = 100;

        string safeText = Convert.ToString(value) ?? string.Empty;
        string numberText = number.ToString();

        Console.WriteLine($"Convert.ToString(null): '{safeText}'");
        Console.WriteLine($"number.ToString(): '{numberText}'");
        #endregion

        #region Output
        /*
            Convert.ToString(null): ''
            number.ToString(): '100'
        */
        #endregion
    }
}
