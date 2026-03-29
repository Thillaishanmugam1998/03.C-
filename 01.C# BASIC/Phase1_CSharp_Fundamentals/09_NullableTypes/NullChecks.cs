internal static class NullChecks
{
    public static void Run()
    {
        ShowNullChecking();
    }

    #region 01 - Null Checking
    private static void ShowNullChecking()
    {
        // Null checks prevent crashes when a value may be missing.
        // You can use == null, != null, is null, and is not null.
        // Pattern matching reads well and is now common in modern C# code.
        // These checks are important before reading properties, calling methods, or returning API data.

        string? customerName = null;
        string? cityName = "Chennai";

        bool customerNameIsNull = customerName == null;
        bool cityNameIsNotNull = cityName != null;
        bool customerPatternCheck = customerName is null;
        bool cityPatternCheck = cityName is not null;

        Console.WriteLine("\n01 - Null Checking"); // Output: 01 - Null Checking
        Console.WriteLine($"Customer Name == null: {customerNameIsNull}"); // Output: Customer Name == null: True
        Console.WriteLine($"City Name != null: {cityNameIsNotNull}"); // Output: City Name != null: True
        Console.WriteLine($"Customer Name is null: {customerPatternCheck}"); // Output: Customer Name is null: True
        Console.WriteLine($"City Name is not null: {cityPatternCheck}"); // Output: City Name is not null: True

        if (cityName is not null)
        {
            Console.WriteLine($"Upper City Name: {cityName.ToUpperInvariant()}"); // Output: Upper City Name: CHENNAI
        }

        // Mistake:
        // Forgetting a null check before calling methods like ToUpperInvariant() can cause NullReferenceException.
        // This is one of the most common runtime errors in beginner code.

        // 🌍 Real-World Analogy:
        // Think of a null check like checking whether a file exists before opening it.
        // If the file is missing, opening it directly will fail.
    }
    #endregion
}
