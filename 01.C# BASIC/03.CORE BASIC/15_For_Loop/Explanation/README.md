# For Loop

## Concept Explanation
A `for` loop is commonly used when the number of iterations is known in advance. It includes three parts:

- Initialization
- Condition
- Update

## Real-World Analogy
Think of climbing five steps. You know where you start, how far you go, and when to stop.

## Syntax
```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

## Step-by-Step Explanation
1. `int i = 1` runs once at the beginning.
2. `i <= 5` is checked before each repetition.
3. The loop body runs if the condition is true.
4. `i++` updates the counter after each repetition.

## Best Practices
- Use `for` when the iteration count is known.
- Keep initialization, condition, and update simple.
- Use meaningful loop variable names in real projects.

## Common Mistakes
- Writing the wrong loop condition.
- Forgetting to update the counter.
- Using `for` when another loop type would be clearer.
