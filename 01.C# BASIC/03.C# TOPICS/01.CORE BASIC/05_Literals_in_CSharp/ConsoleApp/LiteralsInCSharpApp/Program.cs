using System;

namespace LiteralsInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Literals in C#

            Literals are fixed values written directly in code.
            Examples include numbers, characters, text, and true/false values.
        */
        #endregion

        #region Example
        int wholeNumber = 100;
        double decimalNumber = 19.75;
        char grade = 'A';
        string message = "Learning C# literals";
        bool isPassed = true;

        Console.WriteLine($"Integer literal: {wholeNumber}");
        Console.WriteLine($"Double literal: {decimalNumber}");
        Console.WriteLine($"Character literal: {grade}");
        Console.WriteLine($"String literal: {message}");
        Console.WriteLine($"Boolean literal: {isPassed}");
        #endregion

        #region Output
        /*
            Integer literal: 100
            Double literal: 19.75
            Character literal: A
            String literal: Learning C# literals
            Boolean literal: True
        */
        #endregion
    }
}
