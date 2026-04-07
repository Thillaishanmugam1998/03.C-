using System;

namespace OverrideEqualsMethodApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Override Equals Method

            Overriding Equals allows custom comparison logic
            between two objects.
        */
        #endregion

        #region Example
        Book firstBook = new("C# Basics", "Arun");
        Book secondBook = new("C# Basics", "Arun");

        Console.WriteLine($"Are books equal? {firstBook.Equals(secondBook)}");
        #endregion

        #region Output
        /*
            Are books equal? True
        */
        #endregion
    }
}

internal class Book
{
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public string Title { get; }

    public string Author { get; }

    public override bool Equals(object? obj)
    {
        if (obj is not Book otherBook)
        {
            return false;
        }

        return Title == otherBook.Title && Author == otherBook.Author;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Author);
    }
}
