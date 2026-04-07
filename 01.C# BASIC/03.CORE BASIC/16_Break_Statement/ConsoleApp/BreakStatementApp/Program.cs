using System;

namespace BreakStatementApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Break Statement

            The break statement is used to immediately stop a loop
            or switch block when a condition is met.
        */
        #endregion

        #region Example
        for (int i = 1; i <= 10; i++)
        {
            if (i == 6)
            {
                Console.WriteLine("Loop stopped at 6.");
                break;
            }

            Console.WriteLine($"Number: {i}");
        }
        #endregion

        #region Output
        /*
            Number: 1
            Number: 2
            Number: 3
            Number: 4
            Number: 5
            Loop stopped at 6.
        */
        #endregion
    }
}
