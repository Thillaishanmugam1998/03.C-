using System;

namespace CheckedAndUncheckedKeywordsApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Checked and Unchecked Keywords

            checked detects arithmetic overflow and throws an exception.
            unchecked allows overflow without throwing an exception.
        */
        #endregion

        #region Example
        int maxValue = int.MaxValue;

        try
        {
            int checkedResult = checked(maxValue + 1);
            Console.WriteLine(checkedResult);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Overflow detected inside checked block.");
        }

        int uncheckedResult = unchecked(maxValue + 1);
        Console.WriteLine($"Unchecked result: {uncheckedResult}");
        #endregion

        #region Output
        /*
            Overflow detected inside checked block.
            Unchecked result: -2147483648
        */
        #endregion
    }
}
