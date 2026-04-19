# Goto Statement

## Concept Explanation
The `goto` statement transfers execution directly to a labeled statement. It exists in C#, but it should be used very carefully.

## Real-World Analogy
Think of `goto` like jumping to a bookmarked page instead of reading every page in order.

## Syntax
```csharp
goto LabelName;

LabelName:
Console.WriteLine("Hello");
```

## Step-by-Step Explanation
1. A label is created.
2. `goto` jumps to that label.
3. Execution continues from that point.

## Best Practices
- Avoid `goto` in most real programs.
- Prefer loops, methods, and conditions for clearer flow.

## Common Mistakes
- Making code hard to follow.
- Jumping around too much and reducing readability.
