# 35 Static Class

## Concept Explanation
A static class can contain only static members and cannot be instantiated. It is useful for helper methods, configuration access, or utility operations that do not need object state.

## Real-World Analogy
A toolbox mounted on the wall serves everyone directly. No one creates a new toolbox object each time they need a hammer.

## Syntax
```csharp
public static class Calculator
{
    public static int Add(int a, int b) => a + b;
}
```

## Step-by-Step Explanation
1. Mark the class as `static`.
2. Add only static members.
3. Call them using the class name.
4. Do not try to create an object of the class.

## Best Practices
- Use static classes for stateless helpers.
- Keep them focused on one area of responsibility.
- Avoid hiding excessive global logic in utility classes.

## Common Mistakes
- Trying to instantiate a static class.
- Storing unrelated behaviors together.
