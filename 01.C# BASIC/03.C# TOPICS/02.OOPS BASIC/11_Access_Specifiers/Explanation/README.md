# 11 Access Specifiers

## Concept Explanation
Access specifiers in C# control where a class member or type can be accessed. They help us protect data and design clear boundaries between what should be visible and what should stay internal.

Common access specifiers:
- `public`
- `private`
- `protected`
- `internal`
- `protected internal`
- `private protected`

## Real-World Analogy
Think of a company building:
- `public`: reception area anyone can enter
- `private`: personal locker only the owner can open
- `protected`: area accessible to department members
- `internal`: only employees inside the company can enter

## Syntax
```csharp
public class Employee
{
    public string Name;
    private decimal salary;
    protected string Department;
    internal int EmployeeId;
}
```

## Step-by-Step Explanation
1. Create a class.
2. Add members with different access levels.
3. Access public members from outside the class.
4. Keep private members available only inside the class.
5. Use protected members in inheritance scenarios.

## Best Practices
- Use the most restrictive access level possible.
- Expose only what other classes truly need.
- Keep internal implementation details hidden.
- Use properties and methods to control private data.

## Common Mistakes
- Making everything public.
- Confusing `private` and `protected`.
- Exposing internal state directly.
- Ignoring access modifiers in API design.
