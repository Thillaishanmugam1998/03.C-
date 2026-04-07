using System;

namespace StringInCSharpApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: String in C#

            A string is a sequence of characters used to store text.
            Strings are one of the most common types in C#.
        */
        #endregion

        #region Example
        string firstName = "Arun";
        string lastName = "Kumar";
        string fullName = firstName + " " + lastName;

        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Length: {fullName.Length}");
        Console.WriteLine($"Uppercase: {fullName.ToUpper()}");
        #endregion

        #region Output
        /*
            Full Name: Arun Kumar
            Length: 10
            Uppercase: ARUN KUMAR
        */
        #endregion
    }
}
