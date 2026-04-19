namespace ObjectOrientedProgrammingApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // OOP helps us represent real-world entities using classes and objects.
        // A class defines data and behavior, and an object is a usable instance of that class.
        #endregion

        #region Example
        Car cityCar = new("Toyota", "Urban Cruiser", 0);
        cityCar.Start();
        cityCar.Accelerate(20);
        cityCar.ShowStatus();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. A Car object is created from a Car class.");
        Console.WriteLine("2. Methods change object behavior and state.");
        Console.WriteLine("3. OOP keeps related data and behavior together.");
        #endregion
    }
}

internal class Car
{
    public string Brand { get; }
    public string Model { get; }
    public int Speed { get; private set; }

    public Car(string brand, string model, int speed)
    {
        Brand = brand;
        Model = model;
        Speed = speed;
    }

    public void Start()
    {
        Console.WriteLine($"{Brand} {Model} has started.");
    }

    public void Accelerate(int increaseBy)
    {
        Speed += increaseBy;
        Console.WriteLine($"{Brand} {Model} accelerated by {increaseBy} km/h.");
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Current speed: {Speed} km/h");
    }
}
