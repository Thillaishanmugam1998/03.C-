// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Tuples & Deconstruction
// Purpose  : Interview + Real Project Learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Tuples & Deconstruction"); // Output: Topic: Tuples & Deconstruction

TupleBasics.Run();
NamedTuples.Run();
DeconstructionExamples.Run();
DiscardPattern.Run();
RealWorldUsage.Run();

Console.WriteLine("\n✅ All topics completed! Press any key to exit..."); // Output: ✅ All topics completed! Press any key to exit...
if (!Console.IsInputRedirected)
{
    Console.ReadKey();
}
