# Static vs Non-Static Members

## Concept Explanation
Static members belong to the class. Non-static members belong to an object created from the class.

## Real-World Analogy
The school name is shared by all students, but each student has a different personal name.

## Syntax
```csharp
public static string SchoolName = "ABC";
public string StudentName = "Arun";
```

## Step-by-Step Explanation
1. Static members are accessed using the class name.
2. Non-static members require an object.
3. Each object has its own non-static values.

## Best Practices
- Use static for shared data.
- Use instance members for object-specific data.

## Common Mistakes
- Treating static and instance members as the same thing.
- Accessing non-static members without an object.
