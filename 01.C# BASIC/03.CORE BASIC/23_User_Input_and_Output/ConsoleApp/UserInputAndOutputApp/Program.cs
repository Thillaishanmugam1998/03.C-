using System;

namespace UserInputAndOutputApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: User Input and Output

            Output shows information to the user.
            Input allows the user to provide data to the program.
        */
        #endregion

        #region Example
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Guest";
        }

        Console.WriteLine($"Hello, {name}!");
        #endregion

        #region Output
        /*
            Enter your name: Arun
            Hello, Arun!
        */
        #endregion
    }
}
