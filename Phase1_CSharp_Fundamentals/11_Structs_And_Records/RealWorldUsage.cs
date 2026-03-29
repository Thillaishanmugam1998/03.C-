internal static class RealWorldUsage
{
    public static void Run()
    {
        ShowWhenToUseStruct();
        ShowWhenToUseRecord();
        ShowRealScenarios();
    }

    #region 01 - When To Use Struct
    private static void ShowWhenToUseStruct()
    {
        // Use struct for small, lightweight data that behaves like one value.
        // Good examples are coordinates, measurements, colors, and money-like values.
        // Structs work well in high-performance scenarios when the type is small and immutable.
        // Avoid using large structs because copying them can be expensive.

        GeoCoordinate coordinate = new(13.0827, 80.2707);

        Console.WriteLine("\n01 - When To Use Struct"); // Output: 01 - When To Use Struct
        Console.WriteLine($"Latitude: {coordinate.Latitude}"); // Output: Latitude: 13.0827
        Console.WriteLine($"Longitude: {coordinate.Longitude}"); // Output: Longitude: 80.2707

        // Mistake:
        // Using struct for large business objects can create performance problems due to repeated copying.
        // Keep structs small and focused.

        // 🌍 Real-World Analogy:
        // Think of a struct like a small coordinate note.
        // It is light, clear, and easy to carry around.
    }
    #endregion

    #region 02 - When To Use Record
    private static void ShowWhenToUseRecord()
    {
        // Use record for immutable data models such as DTOs, API responses, and settings.
        // Records shine when equality should be based on data instead of object identity.
        // They also reduce boilerplate in data-carrying models.
        // This makes them common in modern .NET projects.

        UserDto firstUser = new(101, "Anita", "anita@example.com");
        UserDto secondUser = new(101, "Anita", "anita@example.com");
        bool usersMatchByValue = firstUser == secondUser;

        Console.WriteLine("\n02 - When To Use Record"); // Output: 02 - When To Use Record
        Console.WriteLine($"First User: {firstUser}"); // Output: First User: UserDto { Id = 101, Name = Anita, Email = anita@example.com }
        Console.WriteLine($"Users Match By Value: {usersMatchByValue}"); // Output: Users Match By Value: True

        // Mistake:
        // Using regular mutable classes for pure DTOs often adds more code and weaker safety than needed.
        // Record is a better fit when the model mainly carries data.

        // 🌍 Real-World Analogy:
        // Think of a record like a digital identity card for API data.
        // Its main purpose is to carry stable information clearly.
    }
    #endregion

    #region 03 - Real Scenarios
    private static void ShowRealScenarios()
    {
        // Real systems often mix struct and record based on the need.
        // A coordinate can be a struct because it is small and value-like.
        // A user DTO or configuration model can be a record because it carries immutable business data.
        // Choosing the right type improves readability and correctness.

        GeoCoordinate officeLocation = new(11.0168, 76.9558);
        UserDto apiUser = new(202, "Rahul", "rahul@example.com");
        AppSettings settings = new("Production", true);

        Console.WriteLine("\n03 - Real Scenarios"); // Output: 03 - Real Scenarios
        Console.WriteLine($"Office Location: {officeLocation}"); // Output: Office Location: GeoCoordinate { Latitude = 11.0168, Longitude = 76.9558 }
        Console.WriteLine($"API User: {apiUser}"); // Output: API User: UserDto { Id = 202, Name = Rahul, Email = rahul@example.com }
        Console.WriteLine($"App Settings: {settings}"); // Output: App Settings: AppSettings { Environment = Production, EnableCaching = True }

        // Mistake:
        // Using struct for large nested objects or using class for every simple data model can make the design weaker.
        // Match the type to the data behavior you really need.

        // 🌍 Real-World Analogy:
        // Think of it like choosing the right container.
        // A small card fits a wallet, but a full document needs a proper file folder.
    }
    #endregion

    private readonly record struct GeoCoordinate(double Latitude, double Longitude);

    private sealed record UserDto(int Id, string Name, string Email);

    private sealed record AppSettings(string Environment, bool EnableCaching);
}
