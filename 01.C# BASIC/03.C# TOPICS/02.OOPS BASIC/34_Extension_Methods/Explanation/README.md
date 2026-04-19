# 34 Extension Methods

## Concept Explanation
Extension methods allow you to add methods to existing types without modifying their source code. They are static methods written in static classes, but they are called like instance methods.

## Real-World Analogy
Think of attaching a smart accessory to an existing appliance so it gains extra capability without changing the original appliance design.

## Syntax
```csharp
public static class StringExtensions
{
    public static string ToTitle(this string value)
    {
        return value.ToUpper();
    }
}
```

## Step-by-Step Explanation
1. Create a static class.
2. Create a static method.
3. Use `this` before the first parameter type.
4. Call the method as if it belongs to the original type.

## Best Practices
- Use extension methods for helpful, reusable additions.
- Keep them discoverable and relevant to the type.
- Avoid replacing clear domain methods with too many extensions.

## Common Mistakes
- Forgetting the containing class must be static.
- Forgetting the first parameter needs `this`.
