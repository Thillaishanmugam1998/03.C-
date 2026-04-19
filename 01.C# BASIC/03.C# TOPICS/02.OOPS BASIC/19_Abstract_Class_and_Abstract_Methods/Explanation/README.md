# 19 Abstract Class and Abstract Methods

## Concept Explanation
An abstract class is a class that cannot be instantiated directly. It is used as a base for related classes. An abstract method has no body in the abstract class and must be implemented by derived classes.

## Real-World Analogy
A generic `Shape` is an idea, not a complete object you draw directly. But `Circle` and `Rectangle` are real shapes that provide their own area calculation.

## Syntax
```csharp
public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public override double GetArea() => 3.14 * 5 * 5;
}
```

## Step-by-Step Explanation
1. Create an abstract base class for common structure.
2. Add abstract methods for required behavior.
3. Inherit from the abstract class.
4. Override abstract methods in each derived class.

## Best Practices
- Use abstract classes for shared base behavior plus required specialization.
- Put common code in the abstract class when appropriate.
- Use clear abstract method names.

## Common Mistakes
- Trying to instantiate an abstract class.
- Forgetting to override abstract methods.
- Using abstract classes when no shared base behavior exists.
