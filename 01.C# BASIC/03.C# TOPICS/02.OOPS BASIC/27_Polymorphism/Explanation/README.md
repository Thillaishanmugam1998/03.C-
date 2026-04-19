# 27 Polymorphism

## Concept Explanation
Polymorphism means the same interface or method name can behave differently depending on the object involved. In C#, this appears mainly as compile-time polymorphism and runtime polymorphism.

## Real-World Analogy
The command `Draw` can work for a circle, rectangle, or triangle, but each shape draws itself differently.

## Syntax
```csharp
Shape shape = new Circle();
shape.Draw();
```

## Step-by-Step Explanation
1. Create a common base type or interface.
2. Define a common member.
3. Implement behavior differently in different classes.
4. Use the base reference to call the same member.

## Best Practices
- Use polymorphism to avoid long `if` or `switch` chains.
- Prefer base types or interfaces when behavior varies by object type.
- Keep behaviors aligned with the shared contract.

## Common Mistakes
- Confusing overloading with overriding.
- Using type checks everywhere instead of polymorphism.
