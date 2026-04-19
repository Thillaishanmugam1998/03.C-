# 28 Method Overloading

## Concept Explanation
Method overloading means creating multiple methods with the same name but different parameter lists in the same class. It is a form of compile-time polymorphism.

## Real-World Analogy
A calculator can add two numbers, three numbers, or decimal values. The action is still `Add`, but the inputs differ.

## Syntax
```csharp
public int Add(int a, int b) { return a + b; }
public int Add(int a, int b, int c) { return a + b + c; }
```

## Step-by-Step Explanation
1. Create methods with the same name.
2. Change parameter count or parameter type.
3. Call the appropriate version based on arguments.

## Best Practices
- Use overloading only when methods perform closely related work.
- Keep overloads intuitive.
- Avoid ambiguous signatures.

## Common Mistakes
- Trying to overload using only return type.
- Creating confusing overload combinations.
