namespace TypesOfConstructorsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Constructors can be written in different ways based on initialization needs.
        // This example shows a default constructor, a parameterized constructor, and a copy-style constructor.
        #endregion

        #region Example
        Product defaultProduct = new();
        Product namedProduct = new("Laptop", 65000m);
        Product copiedProduct = new(namedProduct);

        defaultProduct.ShowDetails("Default Constructor");
        namedProduct.ShowDetails("Parameterized Constructor");
        copiedProduct.ShowDetails("Copy-Style Constructor");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Different constructors can initialize the same class in different ways.");
        Console.WriteLine("2. Constructor overloading improves flexibility.");
        #endregion
    }
}

internal class Product
{
    public string Name { get; }
    public decimal Price { get; }

    public Product()
    {
        Name = "Unknown Product";
        Price = 0m;
    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public Product(Product other)
    {
        Name = other.Name;
        Price = other.Price;
    }

    public void ShowDetails(string constructorType)
    {
        Console.WriteLine($"{constructorType}: {Name} - {Price:C}");
    }
}
