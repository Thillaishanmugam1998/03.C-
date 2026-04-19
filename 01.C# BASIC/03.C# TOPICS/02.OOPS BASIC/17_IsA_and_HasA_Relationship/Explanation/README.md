# 17 IsA and HasA Relationship

## Concept Explanation
`IsA` and `HasA` help us choose between inheritance and composition:
- `IsA` means inheritance. Example: `Car IsA Vehicle`.
- `HasA` means composition. Example: `Car HasA Engine`.

This is a key design decision in object-oriented programming.

## Real-World Analogy
A smartphone `is a` device, but it `has a` battery. The first describes identity. The second describes ownership or containment.

## Syntax
```csharp
public class Vehicle { }
public class Car : Vehicle { }

public class Engine { }
public class CarWithEngine
{
    public Engine Engine { get; } = new Engine();
}
```

## Step-by-Step Explanation
1. Ask whether the child truly is a type of the parent.
2. If yes, use inheritance.
3. If an object simply contains another object, use composition.
4. Choose the simpler, more accurate relationship.

## Best Practices
- Use `IsA` only for real hierarchical relationships.
- Prefer `HasA` when one object uses or owns another.
- Use composition to reduce tight coupling.

## Common Mistakes
- Using inheritance for everything.
- Modeling containment as inheritance.
- Ignoring composition when it would be cleaner.
