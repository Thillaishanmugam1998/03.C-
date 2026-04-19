# 25 Multiple Inheritance

## Concept Explanation
Multiple inheritance means inheriting from more than one base class. C# does not support multiple inheritance with classes, but it does support implementing multiple interfaces.

## Real-World Analogy
A smart device may behave like a printer and a scanner. Instead of inheriting from two classes, it can implement two capability contracts using interfaces.

## Syntax
```csharp
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class MultiFunctionDevice : IPrinter, IScanner
{
    public void Print() { }
    public void Scan() { }
}
```

## Step-by-Step Explanation
1. Understand that C# does not allow two parent classes.
2. Create interfaces for separate behaviors.
3. Implement multiple interfaces in one class.

## Best Practices
- Use interfaces to model multiple capabilities.
- Keep each interface single-purpose.
- Avoid trying to force multiple class inheritance.

## Common Mistakes
- Expecting `class A : B, C` to work in C#.
- Mixing unrelated members into one interface.
