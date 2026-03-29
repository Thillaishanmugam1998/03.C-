internal static class SortedCollections
{
    public static void Run()
    {
        PrintSeparator();
        ShowSortedDictionary();
        PrintSeparator();
        ShowSortedList();
    }

    #region 01 - SortedDictionary
    private static void ShowSortedDictionary()
    {
        // SortedDictionary<TKey, TValue> keeps items automatically sorted by key.
        // It is useful when you need sorted data and frequent insert or remove operations.
        // Internally it is better suited than SortedList for update-heavy scenarios.
        // This is helpful for ranked reports, time-based keys, and ordered lookups.

        SortedDictionary<int, string> orderStatus = new()
        {
            { 1003, "Packed" },
            { 1001, "Placed" },
            { 1002, "Confirmed" }
        };

        bool hasOrder1002 = orderStatus.ContainsKey(1002);

        Console.WriteLine("\n01 - SortedDictionary"); // Output: 01 - SortedDictionary
        Console.WriteLine($"Total SortedDictionary Items: {orderStatus.Count}"); // Output: Total SortedDictionary Items: 3
        Console.WriteLine($"Contains Order 1002: {hasOrder1002}"); // Output: Contains Order 1002: True

        foreach (KeyValuePair<int, string> item in orderStatus)
        {
            Console.WriteLine($"{item.Key}: {item.Value}"); // Output: 1001: Placed ... 1003: Packed
        }

        // Mistake:
        // Do not choose SortedDictionary only because it is sorted.
        // Choose it when you need sorted keys and expect regular insert or remove operations.

        // 🌍 Real-World Analogy:
        // Think of a SortedDictionary like a phone directory that stays alphabetically arranged as entries are added.
    }
    #endregion

    #region 02 - SortedList
    private static void ShowSortedList()
    {
        // SortedList<TKey, TValue> also keeps items sorted by key.
        // It uses array-style storage internally, so lookups can be very efficient in read-heavy scenarios.
        // It is usually better when data changes less often and reads happen more often.
        // This fits dashboards, configuration maps, and reporting tables.

        SortedList<string, decimal> productPrices = new()
        {
            { "Mouse", 599.50m },
            { "Keyboard", 1299.00m },
            { "Laptop", 64999.00m }
        };

        string firstKey = productPrices.Keys[0];
        decimal firstValue = productPrices.Values[0];

        Console.WriteLine("\n02 - SortedList"); // Output: 02 - SortedList
        Console.WriteLine($"Total SortedList Items: {productPrices.Count}"); // Output: Total SortedList Items: 3
        Console.WriteLine($"Price Of Laptop: {productPrices["Laptop"]}"); // Output: Price Of Laptop: 64999.00
        Console.WriteLine($"First Sorted Key: {firstKey}"); // Output: First Sorted Key: Keyboard
        Console.WriteLine($"First Sorted Value: {firstValue}"); // Output: First Sorted Value: 1299.00

        foreach (KeyValuePair<string, decimal> item in productPrices)
        {
            Console.WriteLine($"{item.Key}: {item.Value}"); // Output: Keyboard: 1299.00 ... Mouse: 599.50
        }

        // Mistake:
        // Using SortedList in very insert-heavy scenarios can be inefficient because elements may shift internally.
        // Choose it when reads are frequent and changes are less frequent.

        // 🌍 Real-World Analogy:
        // Think of a SortedList like a sorted printed directory that is excellent for reading, but slower to update often.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
