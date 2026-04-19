# 33 Sealed Class and Sealed Methods

## Concept Explanation
A sealed class cannot be inherited. A sealed method cannot be overridden further in derived classes. These are useful when you want to stop extension at a certain level.

## Real-World Analogy
A final approved legal document may no longer be changed by junior staff. That is similar to sealing behavior in code.

## Syntax
```csharp
public sealed class Utility { }
```

## Step-by-Step Explanation
1. Use `sealed` on a class to block inheritance.
2. Use `sealed override` on a method to stop further overriding.
3. Protect completed or sensitive behavior from extension.

## Best Practices
- Seal classes only when extension should genuinely be prevented.
- Seal overrides when a behavior must remain fixed.
- Avoid sealing too early without design reasons.

## Common Mistakes
- Overusing `sealed`.
- Expecting sealed classes to be extendable later without code changes.
