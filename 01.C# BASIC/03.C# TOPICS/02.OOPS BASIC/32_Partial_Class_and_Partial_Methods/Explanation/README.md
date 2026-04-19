# 32 Partial Class and Partial Methods

## Concept Explanation
A partial class allows one class definition to be split across multiple files. Partial methods allow one part of the class to declare a method and another part to implement it. This is often used in generated code and large applications.

## Real-World Analogy
A project report may be written by two team members in separate sections, but it still becomes one final report.

## Syntax
```csharp
public partial class Employee
{
    partial void OnCreated();
}
```

## Step-by-Step Explanation
1. Split a class into multiple files using `partial`.
2. Declare a partial method in one file.
3. Implement it in another partial file.
4. Use the combined class normally.

## Best Practices
- Use partial classes for generated code separation or large types.
- Keep file responsibilities clear.
- Use partial methods only where separation is beneficial.

## Common Mistakes
- Splitting small simple classes unnecessarily.
- Forgetting that all partial pieces must share the same accessibility and namespace rules.
