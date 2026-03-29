using System.Diagnostics;

internal static class ArrayVsListPerformance
{
    public static void Run()
    {
        PrintSeparator();

        #region 01 - Array vs List
        // Arrays have a fixed size, so they are simple and memory-efficient when the count is known.
        // Lists grow dynamically, so they are easier when data size can change at runtime.
        // Arrays usually have a small advantage for direct indexed access because there is less management work.
        // A common mistake is choosing an array when the collection needs to grow often.

        const int itemCount = 200_000;

        int[] numbersArray = new int[itemCount];
        List<int> numbersList = new(itemCount);

        Stopwatch arrayFillWatch = Stopwatch.StartNew();
        for (int index = 0; index < numbersArray.Length; index++)
        {
            numbersArray[index] = index;
        }
        arrayFillWatch.Stop();

        Stopwatch listFillWatch = Stopwatch.StartNew();
        for (int index = 0; index < itemCount; index++)
        {
            numbersList.Add(index);
        }
        listFillWatch.Stop();

        long arraySum = 0;
        Stopwatch arrayReadWatch = Stopwatch.StartNew();
        for (int index = 0; index < numbersArray.Length; index++)
        {
            arraySum += numbersArray[index];
        }
        arrayReadWatch.Stop();

        long listSum = 0;
        Stopwatch listReadWatch = Stopwatch.StartNew();
        for (int index = 0; index < numbersList.Count; index++)
        {
            listSum += numbersList[index];
        }
        listReadWatch.Stop();

        Console.WriteLine("\n01 - Array vs List"); // Output: 01 - Array vs List
        Console.WriteLine($"Array Length: {numbersArray.Length}"); // Output: Array Length: 200000
        Console.WriteLine($"List Count: {numbersList.Count}"); // Output: List Count: 200000
        Console.WriteLine($"Array Fill Time (ms): {arrayFillWatch.ElapsedMilliseconds}"); // Output: Displays the measured fill time for the array in milliseconds.
        Console.WriteLine($"List Fill Time (ms): {listFillWatch.ElapsedMilliseconds}"); // Output: Displays the measured fill time for the list in milliseconds.
        Console.WriteLine($"Array Read Sum: {arraySum}"); // Output: Array Read Sum: 19999900000
        Console.WriteLine($"List Read Sum: {listSum}"); // Output: List Read Sum: 19999900000
        Console.WriteLine($"Array Read Time (ms): {arrayReadWatch.ElapsedMilliseconds}"); // Output: Displays the measured read time for the array in milliseconds.
        Console.WriteLine($"List Read Time (ms): {listReadWatch.ElapsedMilliseconds}"); // Output: Displays the measured read time for the list in milliseconds.

        // Mistake:
        // If the collection size changes often, arrays force you to create a new bigger array and copy values.
        // List<T> handles growth for you, so it is usually the better choice for dynamic data.

        // 🌍 Real-World Analogy:
        // Think of an array as a fixed-size box with exact slots.
        // Think of a list as an expandable bag that can hold more items when needed.
        #endregion
    }

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================"); // Output: ========================================
    }
}
