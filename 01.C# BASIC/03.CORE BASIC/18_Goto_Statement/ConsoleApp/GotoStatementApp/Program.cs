using System;

namespace GotoStatementApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Goto Statement

            The goto statement jumps program execution directly
            to a labeled statement in the same method.
        */
        #endregion

        #region Example
        int number = 2;

        if (number == 2)
        {
            goto ShowMessage;
        }

        Console.WriteLine("This line is skipped.");

    ShowMessage:
        Console.WriteLine("Execution jumped to the label.");
        #endregion

        #region Output
        /*
            Execution jumped to the label.
        */
        #endregion
    }
}
