# 14 Inheritance

## Concept Explanation
Inheritance allows one class to acquire members from another class. The existing class is the base class, and the new class is the derived class. This promotes reuse and models hierarchical relationships.

## Real-World Analogy
A `Dog` is an `Animal`. It shares common animal features such as name and age, while also having its own behavior such as barking.

## Syntax
```csharp
public class Animal
{
    public string Name { get; set; } = string.Empty;
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}
```

## Step-by-Step Explanation
1. Create a base class with common members.
2. Create a derived class using `:`.
3. Access inherited members in the derived class.
4. Add specialized behavior in the derived class.

## Best Practices
- Use inheritance only for true `is-a` relationships.
- Keep the base class focused on shared behavior.
- Avoid deep inheritance chains when composition is simpler.
- Reuse carefully to avoid tight coupling.

## Common Mistakes
- Using inheritance for code reuse without a real relationship.
- Putting too much unrelated logic in the base class.
- Confusing inheritance with composition.
