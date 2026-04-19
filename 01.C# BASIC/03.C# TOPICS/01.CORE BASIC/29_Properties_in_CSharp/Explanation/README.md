# Properties in C#

## Concept Explanation
Properties are members that provide a flexible way to read, write, or control access to fields.

## Real-World Analogy
Think of a property like a reception desk that controls who can view or update information.

## Syntax
```csharp
public string Name { get; set; }
```

## Step-by-Step Explanation
1. A property is declared with a type and name.
2. `get` reads the value.
3. `set` writes the value.

## Best Practices
- Prefer properties over public fields.
- Use validation inside properties when needed.

## Common Mistakes
- Exposing fields directly.
- Forgetting default values for reference types.
