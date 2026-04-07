using System;

namespace LoopsInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Loops in C#

            Loops are used to repeat a block of code multiple times.
            They help avoid writing the same code again and again.
        */
        #endregion

        #region Example
        Console.WriteLine("Numbers from 1 to 5:");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
        #endregion

        #region Output
        /*
            Numbers from 1 to 5:
            1
            2
            3
            4
            5
        */
        #endregion
    }
}
