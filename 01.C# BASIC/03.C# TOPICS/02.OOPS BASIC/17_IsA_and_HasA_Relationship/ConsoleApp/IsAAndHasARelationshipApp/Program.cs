namespace IsAAndHasARelationshipApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // "IsA" usually maps to inheritance.
        // "HasA" usually maps to composition.
        #endregion

        #region Example
        Car car = new();
        car.Brand = "Honda";
        car.StartVehicle();
        car.ShowEngineDetails();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Car IsA Vehicle, so it inherits Vehicle behavior.");
        Console.WriteLine("2. Car HasA Engine, so it contains an Engine object.");
        #endregion
    }
}

internal class Vehicle
{
    public string Brand { get; set; } = string.Empty;

    public void StartVehicle()
    {
        Console.WriteLine($"{Brand} vehicle started.");
    }
}

internal class Engine
{
    public int HorsePower { get; } = 120;

    public void ShowInfo()
    {
        Console.WriteLine($"Engine horsepower: {HorsePower}");
    }
}

internal class Car : Vehicle
{
    private readonly Engine _engine = new();

    public void ShowEngineDetails()
    {
        _engine.ShowInfo();
    }
}
