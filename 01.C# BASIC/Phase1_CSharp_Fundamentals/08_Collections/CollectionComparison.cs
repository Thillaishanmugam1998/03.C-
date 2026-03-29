internal static class CollectionComparison
{
    public static void Run()
    {
        PrintSeparator();

        #region 01 - When to Use Which
        // Choosing the right collection affects speed, memory use, and code clarity.
        // Some collections are best for indexed access, some for lookup by key, and some for order-based processing.
        // Interview questions often focus on why one collection fits better than another.
        // In real projects, the wrong choice can slow down search, inserts, or memory usage.

        string[] comparisonPoints =
        {
            "List vs Array: Use List for dynamic size and rich methods; use Array when size is fixed and overhead should stay low.",
            "Dictionary vs List: Use Dictionary for fast key-based lookup; use List when order and index access matter more than key lookup.",
            "HashSet vs List: Use HashSet for unique values and fast Contains checks; use List when duplicates and stable order are needed.",
            "Stack vs Queue: Use Stack for LIFO work like undo and recursion; use Queue for FIFO work like messaging and ticket processing.",
            "LinkedList vs List: Use LinkedList for frequent insert or remove around known nodes; use List for fast index access and compact memory.",
            "SortedDictionary vs SortedList: Use SortedDictionary for frequent updates in sorted data; use SortedList for read-heavy sorted lookup."
        };

        Console.WriteLine("\n01 - When to Use Which"); // Output: 01 - When to Use Which

        for (int index = 0; index < comparisonPoints.Length; index++)
        {
            Console.WriteLine(comparisonPoints[index]); // Output: Displays each collection comparison guideline.
        }

        Console.WriteLine("Performance Focus: Choose by access pattern, insert frequency, lookup need, and memory behavior."); // Output: Performance Focus: Choose by access pattern, insert frequency, lookup need, and memory behavior.
        Console.WriteLine("Memory Focus: Simpler structures often use less overhead, but flexibility can justify extra memory."); // Output: Memory Focus: Simpler structures often use less overhead, but flexibility can justify extra memory.
        Console.WriteLine("Use Case Focus: Match the collection to the business need instead of using the same type everywhere."); // Output: Use Case Focus: Match the collection to the business need instead of using the same type everywhere.
        Console.WriteLine("Interview Focus: Explain both behavior and the reason for choosing that collection."); // Output: Interview Focus: Explain both behavior and the reason for choosing that collection.

        // Mistake:
        // Choosing a collection only because it is familiar can create performance issues later.
        // Always ask how the data will be added, searched, removed, and read most often.

        // 🌍 Real-World Analogy:
        // Think of collections like tools in a toolbox.
        // A hammer, screwdriver, and wrench all help, but each one is best for a different job.
        #endregion
    }

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
