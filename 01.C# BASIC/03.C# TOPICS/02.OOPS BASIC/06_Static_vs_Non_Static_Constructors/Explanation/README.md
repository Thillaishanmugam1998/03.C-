# 06 Static vs Non-Static Constructors

## Concept Explanation
A non-static constructor runs every time an object is created. A static constructor runs only once for the class itself, before the first object is created or before any static member is accessed. Static constructors are used to initialize static data shared by all objects.

## Real-World Analogy
Imagine a school:
- Static constructor: the school opens once and sets common rules for everyone.
- Non-static constructor: each student is registered individually when they join.

## Syntax
```csharp
public class School
{
    public static string SchoolName { get; }
    public string StudentName { get; }

    static School()
    {
        SchoolName = "Green Valley School";
    }

    public School(string studentName)
    {
        StudentName = studentName;
    }
}
```

## Step-by-Step Explanation
1. Add static data if it belongs to the class, not individual objects.
2. Use a static constructor to initialize shared class-level data.
3. Use a non-static constructor for object-specific data.
4. Notice the static constructor runs only once.
5. Notice the non-static constructor runs for each object.

## Best Practices
- Use static constructors only for shared initialization.
- Keep static constructor logic simple and safe.
- Use non-static constructors for instance data.
- Avoid heavy work or exception-prone logic in static constructors.

## Common Mistakes
- Expecting a static constructor to run for every object.
- Trying to call a static constructor manually.
- Mixing class-level data with object-level data.
- Placing too much logic in static initialization.
