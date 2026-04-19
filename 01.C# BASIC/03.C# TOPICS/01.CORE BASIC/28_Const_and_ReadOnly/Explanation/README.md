# Const and Read-Only

## Concept Explanation
`const` values cannot change and must be assigned at compile time. `readonly` fields can be assigned when declared or inside a constructor.

## Real-World Analogy
Think of `const` as printed ink on a card and `readonly` as a value written once during setup.

## Syntax
```csharp
public const int MaxValue = 10;
public readonly string Name;
```

## Step-by-Step Explanation
1. `const` is fixed forever.
2. `readonly` can be set during object creation.
3. After assignment, `readonly` cannot be changed.

## Best Practices
- Use `const` for truly fixed values.
- Use `readonly` for values set once per object.

## Common Mistakes
- Using `const` for values that should be decided at runtime.
- Trying to modify readonly fields later.
