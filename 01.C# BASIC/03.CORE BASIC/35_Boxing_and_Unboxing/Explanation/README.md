# Boxing and Unboxing

## Concept Explanation
Boxing converts a value type to `object`. Unboxing extracts the value type back from the object.

## Real-World Analogy
Think of boxing as placing an item into a package, and unboxing as taking it back out.

## Syntax
```csharp
int number = 10;
object boxed = number;
int unboxed = (int)boxed;
```

## Step-by-Step Explanation
1. A value type is created.
2. Boxing stores it as an `object`.
3. Unboxing converts it back using an explicit cast.

## Best Practices
- Avoid unnecessary boxing for performance reasons.
- Unbox only to the correct type.

## Common Mistakes
- Unboxing to the wrong type.
- Forgetting the cast during unboxing.
