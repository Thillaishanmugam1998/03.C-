using System;

namespace WhileLoopApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: While Loop

            A while loop repeats as long as its condition remains true.
            The condition is checked before each repetition.
        */
        #endregion

        #region Example
        int count = 1;

        while (count <= 5)
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }
        #endregion

        #region Output
        /*
            Count: 1
            Count: 2
            Count: 3
            Count: 4
            Count: 5
        */
        #endregion
    }
}
