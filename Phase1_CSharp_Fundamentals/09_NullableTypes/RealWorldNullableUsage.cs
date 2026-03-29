internal static class RealWorldNullableUsage
{
    public static void Run()
    {
        ShowPracticalUsage();
    }

    #region 01 - Practical Usage
    private static void ShowPracticalUsage()
    {
        // In real projects, null often comes from APIs, databases, config, and optional user input.
        // Safe navigation ?. prevents crashes when an object or property may be null.
        // Fallback defaults help keep screens, reports, and business rules stable.
        // Good null handling is one of the main ways to avoid NullReferenceException in production.

        CustomerApiResponse apiResponse = new()
        {
            Customer = new CustomerRecord
            {
                Name = null,
                Address = null
            }
        };

        int? dbLoyaltyPoints = null;
        string customerDisplayName = apiResponse.Customer?.Name ?? "Guest User";
        string customerCity = apiResponse.Customer?.Address?.City ?? "City Not Available";
        int loyaltyPoints = dbLoyaltyPoints.GetValueOrDefault();
        string shippingLabel = apiResponse.Customer?.Address?.BuildingName ?? "Default Building";

        Console.WriteLine("\n01 - Practical Usage"); // Output: 01 - Practical Usage
        Console.WriteLine($"Customer Display Name: {customerDisplayName}"); // Output: Customer Display Name: Guest User
        Console.WriteLine($"Customer City: {customerCity}"); // Output: Customer City: City Not Available
        Console.WriteLine($"Loyalty Points: {loyaltyPoints}"); // Output: Loyalty Points: 0
        Console.WriteLine($"Shipping Label: {shippingLabel}"); // Output: Shipping Label: Default Building
        Console.WriteLine($"Customer Object Available: {apiResponse.Customer is not null}"); // Output: Customer Object Available: True

        // Mistake:
        // Direct access like apiResponse.Customer.Address.City will crash if any part is null.
        // Use ?. and fallback values when working with API data, DB values, or optional nested objects.

        // 🌍 Real-World Analogy:
        // Think of null-safe access like checking every door in a hallway before entering the next room.
        // If one door is closed, you safely stop and use a fallback route.
    }
    #endregion

    private sealed class CustomerApiResponse
    {
        public CustomerRecord? Customer { get; init; }
    }

    private sealed class CustomerRecord
    {
        public string? Name { get; init; }
        public AddressRecord? Address { get; init; }
    }

    private sealed class AddressRecord
    {
        public string? City { get; init; }
        public string? BuildingName { get; init; }
    }
}
