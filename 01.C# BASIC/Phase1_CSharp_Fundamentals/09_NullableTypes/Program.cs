// ============================================================
// Project  : Phase 1 - C# Language Fundamentals
// Topic    : Nullable Types
// Purpose  : Interview + Real Project Learning
// Standard : C# 10 / .NET 6+
// ============================================================

Console.WriteLine("PHASE 1 - C# LANGUAGE FUNDAMENTALS"); // Output: PHASE 1 - C# LANGUAGE FUNDAMENTALS
Console.WriteLine("Topic: Nullable Types"); // Output: Topic: Nullable Types

NullableValueTypes.Run();
NullChecks.Run();
NullCoalescing.Run();
NullableReferenceTypes.Run();
RealWorldNullableUsage.Run();

Console.WriteLine("\n✅ All topics completed! Press any key to exit..."); // Output: ✅ All topics completed! Press any key to exit...
if (!Console.IsInputRedirected)
{
    Console.ReadKey();
}
