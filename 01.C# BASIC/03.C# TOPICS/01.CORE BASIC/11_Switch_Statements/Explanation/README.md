# Switch Statements

## Concept Explanation
A `switch` statement checks one expression against multiple cases. It is often easier to read than many `if-else if` blocks when comparing a single value.

## Real-World Analogy
Think of a menu selection machine. The number you press decides which item is selected from several choices.

## Syntax
```csharp
switch (value)
{
    case 1:
        Console.WriteLine("One");
        break;
    default:
        Console.WriteLine("Other");
        break;
}
```

## Step-by-Step Explanation
1. The switch expression is evaluated.
2. Each `case` is checked.
3. The matching case runs.
4. `break` stops execution from falling into the next case.
5. `default` runs if no case matches.

## Best Practices
- Use `switch` when comparing one value against many options.
- Add a `default` case for unexpected input.
- Keep each case small and focused.

## Common Mistakes
- Forgetting `break` in traditional switch cases.
- Omitting `default`.
- Using `switch` when conditions are not based on one value.
