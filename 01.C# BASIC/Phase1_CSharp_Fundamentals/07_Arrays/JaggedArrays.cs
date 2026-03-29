internal static class JaggedArrays
{
    public static void Run()
    {
        PrintSeparator();

        #region 01 - Jagged Arrays
        // A jagged array is an array of arrays.
        // Each inner array can have a different size.
        // This is helpful when every row does not have the same number of values.
        // A common mistake is thinking a jagged array behaves exactly like a 2D array.

        int[][] classroomMarks =
        {
            new int[] { 85, 90, 88 },
            new int[] { 72, 80 },
            new int[] { 95, 91, 93, 89 }
        };

        Console.WriteLine("\n01 - Jagged Arrays"); // Output: 01 - Jagged Arrays
        Console.WriteLine($"Total Classrooms: {classroomMarks.Length}"); // Output: Total Classrooms: 3
        Console.WriteLine($"Students in Classroom 1: {classroomMarks[0].Length}"); // Output: Students in Classroom 1: 3
        Console.WriteLine($"Students in Classroom 2: {classroomMarks[1].Length}"); // Output: Students in Classroom 2: 2

        for (int classroom = 0; classroom < classroomMarks.Length; classroom++)
        {
            for (int student = 0; student < classroomMarks[classroom].Length; student++)
            {
                Console.WriteLine($"Classroom {classroom}, Student {student}: {classroomMarks[classroom][student]}"); // Output: Classroom 0, Student 0: 85 ... Classroom 2, Student 3: 89
            }
        }

        // Mistake:
        // classroomMarks[1, 0] is not valid syntax for jagged arrays.
        // Use classroomMarks[1][0] because you first access the inner array, then its element.

        // 🌍 Real-World Analogy:
        // Think of jagged arrays like classrooms with different student counts.
        // One room may have 20 students, another may have 35.
        #endregion
    }

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================"); // Output: ========================================
    }
}
