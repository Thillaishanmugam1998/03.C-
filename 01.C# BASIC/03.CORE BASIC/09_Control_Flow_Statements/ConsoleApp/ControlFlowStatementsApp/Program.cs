using System;

namespace ControlFlowStatementsApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Control Flow Statements

            Control flow statements decide the order in which code runs.
            They help programs make decisions and repeat actions.
        */
        #endregion

        #region Example
        int score = 75;

        if (score >= 50)
        {
            Console.WriteLine("You passed the exam.");
        }

        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Practice round: {i}");
        }
        #endregion

        #region Output
        /*
            You passed the exam.
            Practice round: 1
            Practice round: 2
            Practice round: 3
        */
        #endregion
    }
}
