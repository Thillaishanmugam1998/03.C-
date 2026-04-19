# 30 Method Overriding

## Concept Explanation
Method overriding allows a derived class to provide a new implementation for a base class method marked as `virtual`, `abstract`, or already `override`. This is runtime polymorphism.

## Real-World Analogy
Every animal makes a sound, but a dog barks and a cat meows. The behavior changes based on the actual object.

## Syntax
```csharp
public class Animal
{
    public virtual void Speak() { }
}

public class Dog : Animal
{
    public override void Speak() { }
}
```

## Step-by-Step Explanation
1. Mark the base method as `virtual`.
2. Inherit from the base class.
3. Use `override` in the derived class.
4. Call the method through a base reference to see runtime behavior.

## Best Practices
- Override only when behavior must truly change.
- Keep the method meaning consistent across derived classes.
- Use `base` when the parent behavior should also run.

## Common Mistakes
- Forgetting `virtual` in the base class.
- Confusing overriding with hiding.
