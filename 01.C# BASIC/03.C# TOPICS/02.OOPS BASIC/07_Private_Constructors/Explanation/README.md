# 07 Private Constructors

## Concept Explanation
A private constructor prevents object creation from outside the class. It is mainly used when a class should control its own instance creation, such as in singleton patterns or utility classes with only static members.

## Real-World Analogy
Think of a company vault that can only be opened from inside the secure control room. Outsiders cannot create access directly. The class controls when and how access is given.

## Syntax
```csharp
public class AppSettings
{
    public static AppSettings Instance { get; } = new AppSettings();

    private AppSettings()
    {
    }
}
```

## Step-by-Step Explanation
1. Mark the constructor as `private`.
2. Prevent outside code from using `new`.
3. Provide a static property or method if controlled access is needed.
4. Use this approach when instance creation must be restricted.

## Best Practices
- Use private constructors when creation must be controlled.
- Combine them with static factory members when needed.
- Document why direct instantiation is blocked.
- Use them thoughtfully, not by default.

## Common Mistakes
- Using private constructors without giving any access path when one is needed.
- Using this pattern where a normal public constructor would be simpler.
- Confusing access restriction with object immutability.
