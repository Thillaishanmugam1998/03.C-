# Override ToString Method

## Concept Explanation
`ToString()` is a method inherited from `object`. Overriding it allows an object to return a meaningful string representation.

## Real-World Analogy
Think of it like designing a custom name tag for an object.

## Syntax
```csharp
public override string ToString()
{
    return "Custom text";
}
```

## Step-by-Step Explanation
1. Create a class.
2. Override `ToString()`.
3. Return readable text about the object.

## Best Practices
- Return useful summary information.
- Keep the output short and readable.

## Common Mistakes
- Forgetting `override`.
- Returning unclear or incomplete text.
