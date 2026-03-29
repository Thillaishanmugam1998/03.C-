internal static class TupleBasics
{
    public static void Run()
    {
        ShowValueTupleBasics();
        ShowTupleReturnFromMethod();
    }

    #region 01 - ValueTuple Basics
    private static void ShowValueTupleBasics()
    {
        // ValueTuple lets you group multiple values together without creating a separate type.
        // It is useful for short-lived data and quick method results.
        // Item1, Item2 and so on are the default field names.
        // Use tuples for temporary grouped values, not for rich business models.

        (int, string) productInfo = (101, "Laptop");

        Console.WriteLine("\n01 - ValueTuple Basics"); // Output: 01 - ValueTuple Basics
        Console.WriteLine($"Product Id: {productInfo.Item1}"); // Output: Product Id: 101
        Console.WriteLine($"Product Name: {productInfo.Item2}"); // Output: Product Name: Laptop

        // Mistake:
        // Using tuples for complex long-term data models makes code harder to read later.
        // For richer models, use a class or record.

        // 🌍 Real-World Analogy:
        // Think of a tuple like a small sticky note holding two quick details.
        // It is handy for short use, but not ideal as a full customer file.
    }
    #endregion

    #region 02 - Returning Tuple From Method
    private static void ShowTupleReturnFromMethod()
    {
        // Returning multiple values from a method is one of the most common tuple use cases.
        // It avoids creating a full extra model for very small results.
        // This is often used for status plus message, totals plus count, or id plus name.
        // It is especially helpful in service methods and validation helpers.

        (bool success, string message) operationResult = SaveOrder();

        Console.WriteLine("\n02 - Returning Tuple From Method"); // Output: 02 - Returning Tuple From Method
        Console.WriteLine($"Operation Success: {operationResult.success}"); // Output: Operation Success: True
        Console.WriteLine($"Operation Message: {operationResult.message}"); // Output: Operation Message: Order saved successfully

        // Mistake:
        // If the method returns many unrelated values, the tuple becomes hard to understand.
        // Use tuples for short, clear, related outputs only.

        // 🌍 Real-World Analogy:
        // Think of this like getting a delivery result and a short note together.
        // You receive the status and the message in one return package.
    }
    #endregion

    private static (bool success, string message) SaveOrder()
    {
        return (true, "Order saved successfully");
    }
}
