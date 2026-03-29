internal static class MultiDimensionalArrays
{
    public static void Run()
    {
        PrintSeparator();

        #region 01 - 2D Arrays
        // A 2D array stores values in rows and columns, like a table or matrix.
        // It is useful for seat maps, monthly reports, and game boards.
        // GetLength(0) gives row count, and GetLength(1) gives column count.
        // A common mistake is mixing row index and column index.

        int[,] salesGrid =
        {
            { 1200, 1350, 1420 },
            { 980, 1100, 1250 }
        };

        Console.WriteLine("\n01 - 2D Arrays"); // Output: 01 - 2D Arrays
        Console.WriteLine($"Rows: {salesGrid.GetLength(0)}"); // Output: Rows: 2
        Console.WriteLine($"Columns: {salesGrid.GetLength(1)}"); // Output: Columns: 3
        Console.WriteLine($"Value at row 0, column 1: {salesGrid[0, 1]}"); // Output: Value at row 0, column 1: 1350

        for (int row = 0; row < salesGrid.GetLength(0); row++)
        {
            for (int column = 0; column < salesGrid.GetLength(1); column++)
            {
                Console.WriteLine($"Cell [{row},{column}] = {salesGrid[row, column]}"); // Output: Cell [0,0] = 1200 ... Cell [1,2] = 1250
            }
        }

        // Mistake:
        // salesGrid[2, 0] is invalid because row indexes here are only 0 and 1.
        // Beginners also confuse [row, column] with [column, row].

        // 🌍 Real-World Analogy:
        // Think of a 2D array like an Excel sheet.
        // You move by row and column to reach one exact cell.
        #endregion
    }

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================"); // Output: ========================================
    }
}
