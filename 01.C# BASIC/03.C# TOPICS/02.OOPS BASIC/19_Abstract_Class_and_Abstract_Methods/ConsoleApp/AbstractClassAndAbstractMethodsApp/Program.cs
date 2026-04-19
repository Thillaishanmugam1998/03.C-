namespace AbstractClassAndAbstractMethodsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // An abstract class provides a shared base structure.
        // Abstract methods force derived classes to provide their own implementation.
        #endregion

        #region Example
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea():F2}");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Shape cannot be created directly because it is abstract.");
        Console.WriteLine("2. Circle and Rectangle must implement GetArea().");
        #endregion
    }
}

internal abstract class Shape
{
    public abstract double GetArea();
}

internal class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

internal class Rectangle : Shape
{
    private readonly double _length;
    private readonly double _width;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
