using System;

namespace FunctionsInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Functions in C#

            Functions are reusable blocks of code that perform a task.
            They help organize code and avoid repetition.
        */
        #endregion

        #region Example
        GreetUser();
        DisplayLine();
        #endregion

        #region Output
        /*
            Welcome to functions in C#.
            -------------------------
        */
        #endregion
    }

    private static void GreetUser()
    {
        Console.WriteLine("Welcome to functions in C#.");
    }

    private static void DisplayLine()
    {
        Console.WriteLine("-------------------------");
    }
}
