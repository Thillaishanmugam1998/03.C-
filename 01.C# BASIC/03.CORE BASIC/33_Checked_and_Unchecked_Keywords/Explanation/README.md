# Checked and Unchecked Keywords

## Concept Explanation
`checked` and `unchecked` control overflow behavior in arithmetic operations.

## Real-World Analogy
Think of `checked` as a safety alarm and `unchecked` as allowing the system to continue quietly.

## Syntax
```csharp
int result = checked(a + b);
int result2 = unchecked(a + b);
```

## Step-by-Step Explanation
1. `checked` throws an exception on overflow.
2. `unchecked` allows overflow to wrap around.

## Best Practices
- Use `checked` when correctness is important.
- Use `unchecked` only when you understand the consequences.

## Common Mistakes
- Ignoring overflow in critical calculations.
- Using `unchecked` without a good reason.
