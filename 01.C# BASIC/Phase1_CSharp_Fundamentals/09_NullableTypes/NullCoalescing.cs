internal static class NullCoalescing
{
    public static void Run()
    {
        ShowNullCoalescingOperator();
        ShowNullCoalescingAssignmentOperator();
    }

    #region 01 - ?? Operator
    private static void ShowNullCoalescingOperator()
    {
        // The ?? operator gives a fallback value when the left side is null.
        // It is used daily for defaults in APIs, UI labels, configuration, and DTO mapping.
        // This keeps the code short and safe.
        // It is better than writing repetitive if-else for simple fallback cases.

        string? productTitle = null;
        decimal? discountPercentage = null;
        string displayTitle = productTitle ?? "Product Name Not Available";
        decimal finalDiscount = discountPercentage ?? 0m;

        Console.WriteLine("\n01 - ?? Operator"); // Output: 01 - ?? Operator
        Console.WriteLine($"Display Title: {displayTitle}"); // Output: Display Title: Product Name Not Available
        Console.WriteLine($"Final Discount: {finalDiscount}"); // Output: Final Discount: 0

        // Mistake:
        // If you forget to provide fallback values, null may continue moving through the program.
        // Later that can cause incorrect output or runtime exceptions.

        // 🌍 Real-World Analogy:
        // Think of ?? like a backup battery.
        // If the main source is missing, the backup source is used immediately.
    }
    #endregion

    #region 02 - ??= Operator
    private static void ShowNullCoalescingAssignmentOperator()
    {
        // The ??= operator assigns a value only when the variable is currently null.
        // It is useful for lazy initialization and default collection setup.
        // This is common in services, DTOs, and optional configuration values.
        // It helps avoid repeating the same null check logic.

        List<string>? logMessages = null;
        string? environmentName = null;

        logMessages ??= new List<string>();
        environmentName ??= "Development";
        logMessages.Add("Application Started");

        Console.WriteLine("\n02 - ??= Operator"); // Output: 02 - ??= Operator
        Console.WriteLine($"Environment Name: {environmentName}"); // Output: Environment Name: Development
        Console.WriteLine($"Log Count: {logMessages.Count}"); // Output: Log Count: 1
        Console.WriteLine($"First Log: {logMessages[0]}"); // Output: First Log: Application Started

        // Mistake:
        // Some developers write long if-null blocks even for simple initialization.
        // ??= is shorter and clearer when you only want to assign if null.

        // 🌍 Real-World Analogy:
        // Think of ??= like filling an empty water bottle.
        // If the bottle already has water, you do not fill it again.
    }
    #endregion
}
