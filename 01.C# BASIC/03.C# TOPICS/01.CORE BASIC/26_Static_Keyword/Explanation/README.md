# Static Keyword

## Concept Explanation
The `static` keyword is used for members that belong to the class itself rather than an object.

## Real-World Analogy
Think of a school nameboard shared by all students. It belongs to the school, not to one student.

## Syntax
```csharp
public static int Count = 0;
```

## Step-by-Step Explanation
1. A static member is declared in a class.
2. It is accessed using the class name.
3. No object is needed.

## Best Practices
- Use static members only for shared data or utility behavior.
- Access them with the class name for clarity.

## Common Mistakes
- Trying to access instance members from static methods directly.
- Overusing static state.
