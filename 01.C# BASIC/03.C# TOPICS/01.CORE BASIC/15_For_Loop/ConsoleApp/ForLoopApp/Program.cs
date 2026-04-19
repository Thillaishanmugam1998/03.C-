using System;

namespace ForLoopApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: For Loop

            A for loop is used when the number of repetitions is known.
            It combines initialization, condition, and update in one place.
        */
        #endregion

        #region Example
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Iteration number: {i}");
        }
        #endregion

        #region Output
        /*
            Iteration number: 1
            Iteration number: 2
            Iteration number: 3
            Iteration number: 4
            Iteration number: 5
        */
        #endregion
    }
}
