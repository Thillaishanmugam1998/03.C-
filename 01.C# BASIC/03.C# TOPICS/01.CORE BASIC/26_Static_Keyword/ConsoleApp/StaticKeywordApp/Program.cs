using System;

namespace StaticKeywordApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Static Keyword

            The static keyword means a member belongs to the class itself
            instead of belonging to an object instance.
        */
        #endregion

        #region Example
        Console.WriteLine($"Company Name: {Company.CompanyName}");
        Company.ShowCompanyName();
        #endregion

        #region Output
        /*
            Company Name: Learn C#
            Company Name from static method: Learn C#
        */
        #endregion
    }
}

internal static class Company
{
    public static string CompanyName { get; } = "Learn C#";

    public static void ShowCompanyName()
    {
        Console.WriteLine($"Company Name from static method: {CompanyName}");
    }
}
