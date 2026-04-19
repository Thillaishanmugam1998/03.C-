using System;

namespace UserDefinedFunctionsApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: User-Defined Functions

            User-defined functions are methods created by the programmer
            to solve a specific problem.
        */
        #endregion

        #region Example
        int sum = AddNumbers(10, 20);
        Console.WriteLine($"Sum: {sum}");
        #endregion

        #region Output
        /*
            Sum: 30
        */
        #endregion
    }

    private static int AddNumbers(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
