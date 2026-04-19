# 21 Abstract Classes in Application

## Concept Explanation
Abstract classes are useful in real applications when several related classes share common behavior and state, but each derived class must implement some specific behavior differently.

## Real-World Analogy
An `Employee` base type in an HR system may share common details like name and employee code, but `Manager` and `Developer` perform different work.

## Syntax
```csharp
public abstract class Employee
{
    public string Name { get; set; } = string.Empty;
    public abstract void DoWork();
}
```

## Step-by-Step Explanation
1. Create an abstract base class for shared application behavior.
2. Put common fields, properties, or methods in that class.
3. Add abstract methods for role-specific work.
4. Implement those methods in derived classes.

## Best Practices
- Use abstract classes when classes share both state and behavior.
- Keep the base class meaningful and reusable.
- Use abstract methods only for truly required custom behavior.

## Common Mistakes
- Using an abstract class when no shared implementation exists.
- Making the base class too large and unrelated.
