# While Loop

## Concept Explanation
A `while` loop runs a block of code repeatedly while a condition is true. The condition is checked before entering the loop body.

## Real-World Analogy
Think of filling buckets while water is available. As long as water remains, you keep filling.

## Syntax
```csharp
int count = 1;

while (count <= 5)
{
    Console.WriteLine(count);
    count++;
}
```

## Step-by-Step Explanation
1. The condition is checked first.
2. If true, the loop body runs.
3. The loop variable is updated.
4. The condition is checked again.

## Best Practices
- Always update the loop variable.
- Make the condition easy to understand.
- Use `while` when the number of repetitions is not fixed in advance.

## Common Mistakes
- Forgetting to update the variable.
- Writing conditions that never become false.
- Using `while` when a `for` loop would be clearer.
