# Loops in C#

## Concept Explanation
Loops repeat a block of code until a condition becomes false or until the loop finishes its defined count.

Common loops in C#:
- `for`
- `while`
- `do-while`
- `foreach`

## Real-World Analogy
Think of a loop like doing exercise repetitions. You repeat the same movement for a certain number of times.

## Syntax
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

## Step-by-Step Explanation
1. A loop starts with an initial value.
2. A condition is checked.
3. The loop body runs if the condition is true.
4. The loop variable changes.
5. The process repeats until the condition becomes false.

## Best Practices
- Make sure the loop has a clear ending condition.
- Use descriptive variable names when needed.
- Keep loop bodies easy to read.

## Common Mistakes
- Creating infinite loops by mistake.
- Updating the loop variable incorrectly.
- Writing too much code inside a loop.
