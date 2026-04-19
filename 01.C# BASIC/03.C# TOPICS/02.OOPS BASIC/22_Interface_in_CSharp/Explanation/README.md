# 22 Interface in C#

## Concept Explanation
An interface defines a contract that classes must follow. It describes what members should exist, but not how they are implemented. Interfaces help build loosely coupled and flexible applications.

## Real-World Analogy
A remote control defines buttons such as power and volume. Different TV brands implement those actions in their own way, but the contract remains similar.

## Syntax
```csharp
public interface ILogger
{
    void Log(string message);
}
```

## Step-by-Step Explanation
1. Create an interface with required members.
2. Implement the interface in one or more classes.
3. Use the interface type to work with different implementations.

## Best Practices
- Keep interfaces small and focused.
- Name interfaces clearly, often with an `I` prefix.
- Use interfaces to reduce dependency on concrete classes.

## Common Mistakes
- Making interfaces too large.
- Confusing interfaces with abstract classes.
- Depending directly on implementations when an interface would be better.
