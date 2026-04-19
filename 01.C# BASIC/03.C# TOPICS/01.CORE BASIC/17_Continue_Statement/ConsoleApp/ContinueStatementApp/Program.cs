using System;

namespace ContinueStatementApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Continue Statement

            The continue statement skips the current loop iteration
            and moves to the next one.
        */
        #endregion

        #region Example
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }

            Console.WriteLine($"Number: {i}");
        }
        #endregion

        #region Output
        /*
            Number: 1
            Number: 2
            Number: 4
            Number: 5
        */
        #endregion
    }
}
