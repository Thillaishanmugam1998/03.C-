# Do While Loop

## Concept Explanation
A `do-while` loop executes the code block once before checking the condition. It is useful when the code must run at least one time.

## Real-World Analogy
Think of trying a password once before the system checks whether it is correct. The attempt happens at least once.

## Syntax
```csharp
int count = 1;

do
{
    Console.WriteLine(count);
    count++;
}
while (count <= 5);
```

## Step-by-Step Explanation
1. The loop body runs first.
2. The condition is checked after the body.
3. If true, the loop repeats.
4. If false, the loop stops.

## Best Practices
- Use `do-while` only when at least one execution is required.
- Update the loop variable correctly.
- Format the `while` condition clearly.

## Common Mistakes
- Forgetting the semicolon after the `while` condition.
- Confusing `while` and `do-while`.
- Creating infinite loops by not updating the variable.
