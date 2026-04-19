# Convert.ToString vs ToString

## Concept Explanation
`ToString()` is an instance method, so it is called on an object. `Convert.ToString()` is a static method that can safely return an empty string when the value is `null`.

## Real-World Analogy
Think of `ToString()` like asking a person to introduce themselves. If no person is there, that fails. `Convert.ToString()` is like asking a receptionist to provide a safe answer even when no one is present.

## Syntax
```csharp
string a = number.ToString();
string? b = Convert.ToString(value);
```

## Step-by-Step Explanation
1. `number.ToString()` converts a real value to text.
2. `Convert.ToString(value)` can accept `null`.
3. If `value` is `null`, `Convert.ToString` returns an empty string.

## Best Practices
- Use `ToString()` for known non-null values.
- Use `Convert.ToString()` when null is possible.

## Common Mistakes
- Calling `ToString()` on a null reference.
- Assuming both methods behave the same in all cases.
