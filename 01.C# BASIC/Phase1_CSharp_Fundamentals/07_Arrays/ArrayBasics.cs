internal static class ArrayBasics
{
    public static void Run()
    {
        PrintSeparator();

        #region 01 - 1D Arrays
        // A 1D array stores multiple values of the same type in one fixed-size collection.
        // We often use it for marks, monthly sales, item IDs, or product prices.
        // Arrays start at index 0, so the first element is always at position 0.
        // A common mistake is trying to read an index that does not exist.

        int[] studentMarks = new int[5];
        studentMarks[0] = 78;
        studentMarks[1] = 84;
        studentMarks[2] = 91;
        studentMarks[3] = 88;
        studentMarks[4] = 76;

        string[] subjects = { "Math", "Science", "English" };
        int firstMark = studentMarks[0];
        int lastMark = studentMarks[studentMarks.Length - 1];

        Console.WriteLine("\n01 - 1D Arrays"); // Output: 01 - 1D Arrays
        Console.WriteLine($"Total Marks Stored: {studentMarks.Length}"); // Output: Total Marks Stored: 5
        Console.WriteLine($"First Mark: {firstMark}"); // Output: First Mark: 78
        Console.WriteLine($"Last Mark: {lastMark}"); // Output: Last Mark: 76
        Console.WriteLine($"First Subject: {subjects[0]}"); // Output: First Subject: Math

        for (int index = 0; index < studentMarks.Length; index++)
        {
            Console.WriteLine($"Mark at index {index}: {studentMarks[index]}"); // Output: Mark at index 0: 78 ... Mark at index 4: 76
        }

        // Mistake:
        // studentMarks[5] would throw IndexOutOfRangeException because valid indexes are 0 to 4.
        // Always check Length before accessing by index.

        // 🌍 Real-World Analogy:
        // Think of a 1D array like a list of student marks on a sheet.
        // Each mark has one fixed slot, and you read it using the slot number.
        #endregion
    }

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================"); // Output: ========================================
    }
}
