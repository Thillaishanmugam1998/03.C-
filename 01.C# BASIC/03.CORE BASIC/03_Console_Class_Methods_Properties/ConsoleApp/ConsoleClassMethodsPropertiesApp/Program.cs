using System;

namespace ConsoleClassMethodsPropertiesApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Console Class Methods & Properties

            The Console class is used to interact with the command window.
            Methods perform actions such as writing or reading text.
            Properties give information about the console environment.
        */
        #endregion

        #region Example
        Console.Title = "Console Class Methods and Properties Demo";

        Console.WriteLine("Welcome to the Console class demo.");
        Console.Write("This line uses Write, so ");
        Console.WriteLine("the text continues on the same line first.");

        Console.WriteLine("Window title set successfully.");
        Console.WriteLine($"Largest window width supported: {Console.LargestWindowWidth}");
        Console.WriteLine($"Largest window height supported: {Console.LargestWindowHeight}");
        Console.WriteLine("Press any key to continue...");

        Console.ReadKey();
        #endregion

        #region Output
        /*
            Welcome to the Console class demo.
            This line uses Write, so the text continues on the same line first.
            Window title set to: Console Class Methods and Properties Demo
            Largest window width supported: [system dependent]
            Largest window height supported: [system dependent]
            Press any key to continue...
        */
        #endregion
    }
}
