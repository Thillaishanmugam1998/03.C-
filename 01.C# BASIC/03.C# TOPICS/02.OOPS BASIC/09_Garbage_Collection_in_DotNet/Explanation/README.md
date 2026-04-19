# 09 Garbage Collection in .NET

## Concept Explanation
Garbage Collection (GC) in .NET automatically frees memory used by objects that are no longer reachable by the application. This reduces manual memory management and helps prevent many memory-related bugs.

The garbage collector mainly works with generations:
- Generation 0 for short-lived objects
- Generation 1 as a buffer stage
- Generation 2 for long-lived objects

## Real-World Analogy
Think of office housekeeping. Items no one uses anymore are removed to keep the workspace clean. Frequently changing temporary items are cleaned more often than long-term furniture.

## Syntax
```csharp
Console.WriteLine(GC.GetTotalMemory(false));
GC.Collect();
GC.WaitForPendingFinalizers();
```

## Step-by-Step Explanation
1. Your program creates objects in memory.
2. Some objects become unreachable when nothing references them.
3. The garbage collector identifies those objects.
4. It reclaims their memory when needed.
5. Developers usually let GC work automatically instead of forcing collection.

## Best Practices
- Trust automatic GC in normal applications.
- Reduce unnecessary object creation in performance-critical code.
- Dispose unmanaged resources properly.
- Measure memory issues before optimizing.

## Common Mistakes
- Calling `GC.Collect()` without a valid reason.
- Assuming GC also closes all external resources immediately.
- Confusing memory cleanup with resource cleanup.
