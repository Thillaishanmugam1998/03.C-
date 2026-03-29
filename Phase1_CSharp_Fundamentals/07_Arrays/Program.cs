// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Arrays
// Purpose  : Interview preparation & learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Arrays"); // Output: Topic: Arrays

ArrayBasics.Run();
MultiDimensionalArrays.Run();
JaggedArrays.Run();
ArrayMethods.Run();
ArrayVsListPerformance.Run();

Console.WriteLine("\n✅ All topics completed! Press any key to exit..."); // Output: ✅ All topics completed! Press any key to exit...

if (!Console.IsInputRedirected)
{
    Console.ReadKey();
}
