internal static class HashSetExamples
{
    public static void Run()
    {
        PrintSeparator();
        ShowHashSetBasics();
        PrintSeparator();
        ShowHashSetOperations();
    }

    #region 01 - HashSet Basics
    private static void ShowHashSetBasics()
    {
        // HashSet<T> stores only unique values.
        // It is useful when duplicate entries must be prevented.
        // Common operations are Add, Remove, and Contains.
        // This fits scenarios like unique IDs, tags, and visited records.

        HashSet<int> employeeIds = new() { 101, 102, 103 };
        bool addedDuplicate = employeeIds.Add(102);
        employeeIds.Add(104);
        employeeIds.Remove(101);

        Console.WriteLine("\n01 - HashSet Basics"); // Output: 01 - HashSet Basics
        Console.WriteLine($"Total Unique IDs: {employeeIds.Count}"); // Output: Total Unique IDs: 3
        Console.WriteLine($"Duplicate Added: {addedDuplicate}"); // Output: Duplicate Added: False
        Console.WriteLine($"Contains 104: {employeeIds.Contains(104)}"); // Output: Contains 104: True

        foreach (int employeeId in employeeIds)
        {
            Console.WriteLine($"Employee ID: {employeeId}"); // Output: Employee ID: 102 ... Employee ID: 104
        }

        // Mistake:
        // HashSet<T> will not keep duplicates, so expecting repeated values is incorrect.
        // If duplicates matter, use List<T> instead.

        // 🌍 Real-World Analogy:
        // Think of a HashSet like storing unique Aadhaar numbers or employee IDs.
        // One ID should appear only once in the system.
    }
    #endregion

    #region 02 - Set Operations
    private static void ShowHashSetOperations()
    {
        // HashSet<T> becomes very powerful with set operations.
        // UnionWith combines unique items from two sets.
        // IntersectWith keeps only common items.
        // ExceptWith removes matching items from the current set.

        HashSet<string> onlineUsers = new() { "Asha", "Bala", "Deepa" };
        HashSet<string> premiumUsers = new() { "Deepa", "Kavin", "Asha" };

        HashSet<string> unionUsers = new(onlineUsers);
        unionUsers.UnionWith(premiumUsers);

        HashSet<string> commonUsers = new(onlineUsers);
        commonUsers.IntersectWith(premiumUsers);

        HashSet<string> basicUsers = new(onlineUsers);
        basicUsers.ExceptWith(premiumUsers);

        Console.WriteLine("\n02 - Set Operations"); // Output: 02 - Set Operations
        Console.WriteLine($"Union Count: {unionUsers.Count}"); // Output: Union Count: 4
        Console.WriteLine($"Common Users: {string.Join(", ", commonUsers)}"); // Output: Common Users: Asha, Deepa
        Console.WriteLine($"Basic Users: {string.Join(", ", basicUsers)}"); // Output: Basic Users: Bala

        // Mistake:
        // UnionWith, IntersectWith, and ExceptWith change the current set.
        // Copy the set first if you also need the original data.

        // 🌍 Real-World Analogy:
        // Think of set operations like comparing customer groups in a marketing system.
        // You can combine, match, or subtract audience lists easily.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
