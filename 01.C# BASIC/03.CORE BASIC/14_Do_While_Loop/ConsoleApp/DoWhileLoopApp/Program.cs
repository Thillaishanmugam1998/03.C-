using System;

namespace DoWhileLoopApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Do While Loop

            A do-while loop runs the code block first and checks the condition after.
            This means the loop body runs at least one time.
        */
        #endregion

        #region Example
        int count = 1;

        do
        {
            Console.WriteLine($"Count: {count}");
            count++;
        }
        while (count <= 5);
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
