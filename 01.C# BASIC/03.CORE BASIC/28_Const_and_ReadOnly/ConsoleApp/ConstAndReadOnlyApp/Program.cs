using System;

namespace ConstAndReadOnlyApp;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Explanation
        /*
            Topic: Const and Read-Only

            const values are fixed at compile time.
            readonly values can be assigned during declaration or in a constructor.
        */
        #endregion

        #region Example
        Product product = new("Keyboard");

        Console.WriteLine($"Const Category: {Product.Category}");
        Console.WriteLine($"ReadOnly Product Name: {product.Name}");
        #endregion

        #region Output
        /*
            Const Category: Electronics
            ReadOnly Product Name: Keyboard
        */
        #endregion
    }
}

internal class Product
{
    public const string Category = "Electronics";

    public Product(string name)
    {
        Name = name;
    }

    public readonly string Name;
}
