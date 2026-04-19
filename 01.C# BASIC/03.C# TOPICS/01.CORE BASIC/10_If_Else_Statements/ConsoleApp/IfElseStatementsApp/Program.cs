using System;

namespace IfElseStatementsApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: If-Else Statements

            If-else statements are used to make decisions.
            They run one block when a condition is true and another block when it is false.
        */
        #endregion

        #region Example
        int age = 17;

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote yet.");
        }
        #endregion

        #region Output
        /*
            You are not eligible to vote yet.
        */
        #endregion
    }
}
