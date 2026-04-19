# 15 Types of Inheritance

## Concept Explanation
Inheritance can appear in different forms:
- Single inheritance
- Multilevel inheritance
- Hierarchical inheritance

C# classes do not support multiple inheritance of classes, but interfaces can help achieve similar flexibility.

## Real-World Analogy
Think of an organization chart:
- Single: Employee -> Manager
- Multilevel: Person -> Employee -> Manager
- Hierarchical: Employee -> Developer and Employee -> Tester

## Syntax
```csharp
public class Person { }
public class Employee : Person { }
public class Manager : Employee { }
public class Developer : Employee { }
```

## Step-by-Step Explanation
1. Start with a common base class.
2. Add one derived class for single inheritance.
3. Continue inheritance for multilevel inheritance.
4. Create multiple child classes from one base for hierarchical inheritance.

## Best Practices
- Use the simplest inheritance structure that fits the model.
- Avoid complex inheritance hierarchies.
- Prefer interfaces when multiple capabilities are needed.

## Common Mistakes
- Expecting multiple inheritance with classes in C#.
- Overengineering inheritance trees.
- Using inheritance when composition is clearer.
