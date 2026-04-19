# Type Casting in C#

## Concept Explanation
Type casting is the process of converting one data type into another. In C#, this happens in two common ways:

- Implicit casting: done automatically when no data loss is expected
- Explicit casting: done manually when there may be data loss

## Real-World Analogy
Think of pouring water from a small cup into a large bottle and from a large bottle into a small cup.

- Small to large is safe, like implicit casting
- Large to small may lose some water, like explicit casting

## Syntax
```csharp
int a = 10;
double b = a;

double x = 9.8;
int y = (int)x;
```

## Step-by-Step Explanation
1. `double b = a;` converts `int` to `double` automatically.
2. `int y = (int)x;` manually converts `double` to `int`.
3. Explicit casting may remove the decimal part.

## Best Practices
- Use implicit casting when possible.
- Use explicit casting carefully when precision may be lost.
- Print both original and converted values while learning.

## Common Mistakes
- Forgetting the cast for narrowing conversions.
- Expecting decimal values to round automatically during explicit casts.
- Ignoring possible data loss.
