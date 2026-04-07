using System;

namespace CommandLineArgumentsApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Command Line Arguments

            Command line arguments are values passed to a program
            when it starts running.
        */
        #endregion

        #region Example
        if (args.Length == 0)
        {
            Console.WriteLine("No command line arguments were provided.");
        }
        else
        {
            Console.WriteLine("Command line arguments:");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Argument {i + 1}: {args[i]}");
            }
        }
        #endregion

        #region Output
        /*
            Command line arguments:
            Argument 1: apple
            Argument 2: mango
        */
        #endregion
    }
}
