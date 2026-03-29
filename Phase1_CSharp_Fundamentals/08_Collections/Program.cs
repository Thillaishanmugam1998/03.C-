// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Collections (Advanced)
// Purpose  : Interview preparation & learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Collections (Advanced)"); // Output: Topic: Collections (Advanced)

ListExamples.Run();
DictionaryExamples.Run();
HashSetExamples.Run();
StackExamples.Run();
QueueExamples.Run();
LinkedListExamples.Run();
SortedCollections.Run();
CollectionComparison.Run();

Console.WriteLine("\n✅ All topics completed! Press any key to exit..."); // Output: ✅ All topics completed! Press any key to exit...

if (!Console.IsInputRedirected)
{
    Console.ReadKey();
}
