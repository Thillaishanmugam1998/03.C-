namespace PolymorphismApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Polymorphism allows the same method call to behave differently
        // depending on the actual object behind the reference.
        #endregion

        #region Example
        Shape[] shapes =
        {
            new Circle(),
            new Rectangle()
        };

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. The same Draw method call works for different shape objects.");
        Console.WriteLine("2. Runtime polymorphism selects the right implementation.");
        #endregion
    }
}

internal abstract class Shape
{
    public abstract void Draw();
}

internal sealed class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

internal sealed class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}
