# Override Equals Method

## Concept Explanation
Overriding `Equals()` allows objects to be compared based on their data instead of just their memory reference.

## Real-World Analogy
Think of comparing two ID cards by their details, not by the paper they are printed on.

## Syntax
```csharp
public override bool Equals(object? obj)
{
    // custom comparison
}
```

## Step-by-Step Explanation
1. Override `Equals`.
2. Check the object type.
3. Compare the important fields or properties.
4. Override `GetHashCode` too.

## Best Practices
- Override `GetHashCode` whenever `Equals` is overridden.
- Compare only meaningful data.

## Common Mistakes
- Forgetting null or type checks.
- Overriding `Equals` without `GetHashCode`.
