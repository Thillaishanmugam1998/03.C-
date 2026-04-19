# 08 Destructors

## Concept Explanation
A destructor in C# is a special method that runs when the garbage collector prepares to clean up an object. It is used for final cleanup of unmanaged resources, but in modern .NET, `IDisposable` and `Dispose` are preferred for most cleanup tasks.

## Real-World Analogy
Imagine a hotel room checkout inspection. Before the room is fully released, the staff does a final check. A destructor is like that final cleanup stage, but the timing is controlled by the system, not by you.

## Syntax
```csharp
public class ResourceHolder
{
    ~ResourceHolder()
    {
        Console.WriteLine("Destructor executed.");
    }
}
```

## Step-by-Step Explanation
1. Create a class.
2. Add a destructor using `~ClassName()`.
3. Understand that you cannot call it manually.
4. The garbage collector decides when it runs.
5. Use it only when final cleanup support is needed.

## Best Practices
- Prefer `Dispose` for predictable cleanup.
- Use destructors only when unmanaged resource cleanup is required.
- Keep destructor logic minimal.
- Never depend on destructor timing.

## Common Mistakes
- Assuming the destructor runs immediately when an object goes out of scope.
- Using destructors for normal business logic.
- Forgetting that destructor execution is non-deterministic.
