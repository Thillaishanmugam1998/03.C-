# 10 Finalize vs Dispose

## Concept Explanation
`Finalize` and `Dispose` are both related to cleanup, but they behave differently:
- `Dispose` is explicit and predictable. We call it when we finish using an object.
- `Finalize` is automatic and unpredictable. The garbage collector calls it later if needed.

In modern .NET development, `Dispose` is preferred for releasing resources such as files, database connections, and streams.

## Real-World Analogy
Borrowing a library book:
- `Dispose`: you return the book yourself on time.
- `Finalize`: the system eventually notices the book is not in use and processes cleanup later.

## Syntax
```csharp
public class FileManager : IDisposable
{
    public void Dispose()
    {
        Console.WriteLine("Resources released.");
        GC.SuppressFinalize(this);
    }

    ~FileManager()
    {
        Console.WriteLine("Finalizer called.");
    }
}
```

## Step-by-Step Explanation
1. Implement `IDisposable` when your class owns resources that need cleanup.
2. Put explicit cleanup logic in `Dispose`.
3. Use a finalizer only as a safety backup when unmanaged resources exist.
4. Call `GC.SuppressFinalize(this)` inside `Dispose` after cleanup.
5. Prefer `using` statements for automatic disposal.

## Best Practices
- Prefer `Dispose` over finalizers for most cleanup.
- Use `using` or `using var` with disposable objects.
- Keep finalizers lightweight.
- Suppress finalization after successful disposal.

## Common Mistakes
- Assuming finalizers run immediately.
- Forgetting to dispose important resources.
- Adding finalizers unnecessarily.
- Confusing memory cleanup with external resource cleanup.
