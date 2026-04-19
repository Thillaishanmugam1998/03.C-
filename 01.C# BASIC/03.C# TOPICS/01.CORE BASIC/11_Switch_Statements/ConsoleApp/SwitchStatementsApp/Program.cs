using System;

namespace SwitchStatementsApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Switch Statements

            A switch statement is used when one value needs to be compared
            against multiple possible cases.
        */
        #endregion

        #region Example
        int dayNumber = 3;

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
        #endregion

        #region Output
        /*
            Wednesday
        */
        #endregion
    }
}
