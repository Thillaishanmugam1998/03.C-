internal static class ArrayMethods
{
    public static void Run()
    {
        PrintSeparator();
        DemonstrateSort();
        PrintSeparator();
        DemonstrateReverse();
        PrintSeparator();
        DemonstrateCopy();
        PrintSeparator();
        DemonstrateIndexOf();
    }

    #region 01 - Sort
    private static void DemonstrateSort()
    {
        // Array.Sort rearranges the original array in ascending order.
        // It does not create a brand-new array for you.
        // This is useful for marks, prices, names, and ranking data.
        // A common mistake is expecting the unsorted array to stay unchanged.

        int[] scores = { 90, 72, 88, 64, 95 };

        Array.Sort(scores);

        Console.WriteLine("\n01 - Sort"); // Output: 01 - Sort
        Console.WriteLine($"Sorted Scores: {string.Join(", ", scores)}"); // Output: Sorted Scores: 64, 72, 88, 90, 95

        // Mistake:
        // Array.Sort(scores) changes scores itself.
        // If you want the original order too, copy first and sort the copy.

        // 🌍 Real-World Analogy:
        // Think of sorting like arranging books from smallest number to largest number on a shelf.
    }
    #endregion

    #region 02 - Reverse
    private static void DemonstrateReverse()
    {
        // Array.Reverse flips the order of the existing array.
        // It also modifies the same array instance.
        // This is helpful when showing reverse rank or latest-to-oldest order.
        // A common mistake is assuming Reverse returns a new array.

        string[] taskStages = { "Draft", "Review", "Approve", "Publish" };

        Array.Reverse(taskStages);

        Console.WriteLine("\n02 - Reverse"); // Output: 02 - Reverse
        Console.WriteLine($"Reversed Stages: {string.Join(", ", taskStages)}"); // Output: Reversed Stages: Publish, Approve, Review, Draft

        // Mistake:
        // Array.Reverse(taskStages) does not create another collection automatically.
        // It changes the order inside taskStages itself.

        // 🌍 Real-World Analogy:
        // Think of reversing like reading a waiting list from bottom to top instead of top to bottom.
    }
    #endregion

    #region 03 - Copy
    private static void DemonstrateCopy()
    {
        // Array.Copy copies elements from one array into another array.
        // This is useful when you need a safe duplicate before making changes.
        // The destination array must have enough space for the copied items.
        // A common mistake is modifying the original and thinking the copied array will change too.

        int[] sourceStock = { 15, 20, 12, 8 };
        int[] copiedStock = new int[sourceStock.Length];

        Array.Copy(sourceStock, copiedStock, sourceStock.Length);
        sourceStock[0] = 99;

        Console.WriteLine("\n03 - Copy"); // Output: 03 - Copy
        Console.WriteLine($"Source Stock: {string.Join(", ", sourceStock)}"); // Output: Source Stock: 99, 20, 12, 8
        Console.WriteLine($"Copied Stock: {string.Join(", ", copiedStock)}"); // Output: Copied Stock: 15, 20, 12, 8

        // Mistake:
        // After copying, sourceStock and copiedStock are separate arrays.
        // Later changes in one array do not automatically update the other.

        // 🌍 Real-World Analogy:
        // Think of copying like making a duplicate report before editing the original report.
    }
    #endregion

    #region 04 - IndexOf
    private static void DemonstrateIndexOf()
    {
        // Array.IndexOf searches for the first matching value and returns its index.
        // If the value is not found, it returns -1.
        // This is useful for search boxes, code lookups, and validations.
        // A common mistake is forgetting to handle the -1 case.

        string[] productCodes = { "P100", "P200", "P300", "P200" };
        int foundIndex = Array.IndexOf(productCodes, "P300");
        int missingIndex = Array.IndexOf(productCodes, "P999");

        Console.WriteLine("\n04 - IndexOf"); // Output: 04 - IndexOf
        Console.WriteLine($"Index of P300: {foundIndex}"); // Output: Index of P300: 2
        Console.WriteLine($"Index of P999: {missingIndex}"); // Output: Index of P999: -1

        // Mistake:
        // If Array.IndexOf returns -1, the value was not found.
        // Do not use that result as a valid index.

        // 🌍 Real-World Analogy:
        // Think of IndexOf like searching a shelf label and getting the first rack position where that item appears.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================"); // Output: ========================================
    }
}
