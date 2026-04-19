# Inheritance - Real-Time Examples

## Concept Explanation

Inheritance allows a class to acquire the members of another class. The existing class is called the base class, and the new class is called the derived class.

It helps avoid duplication and supports code reuse by placing common data and behavior in one shared parent class.

## Real-World Analogy

Think about roles inside a company.

- Every employee has common information like name and employee ID.
- A manager is still an employee, but also manages a department.
- A developer is still an employee, but also writes code using a technology stack.

The manager and developer both inherit common employee traits, while also having their own special behavior.

## Comparison Between Real-World Scenario and Code Implementation

| Real-World Scenario | Code Implementation |
| --- | --- |
| Every company role is an employee | `Manager` and `Developer` inherit from `Employee` |
| All employees have shared details | `Employee` stores common properties |
| A manager has additional responsibilities | `Manager` adds `Department` and `ApproveLeave()` |
| A developer has different responsibilities | `Developer` adds `PrimaryTechnology` and `WriteCode()` |
| Shared structure avoids repetition | Common logic stays in the base class |

## Syntax

```csharp
public class Employee
{
    public string Name { get; set; }
}

public class Manager : Employee
{
    public string Department { get; set; }
}
```

## Step-by-Step Explanation

1. Create a base class called `Employee`.
2. Put shared properties and methods inside the base class.
3. Create derived classes such as `Manager` and `Developer`.
4. Use `:` to inherit from the base class.
5. Add role-specific properties and methods in each derived class.
6. Create objects and observe that derived classes can use both shared and specialized behavior.

## Best Practices

- Keep only truly common members in the base class.
- Use inheritance when there is a clear "is-a" relationship.
- Keep derived classes focused on their specialized behavior.
- Prefer readable names that clearly show the hierarchy.
- Combine inheritance with good separation of concerns.

## Common Mistakes

- Using inheritance for classes that do not have a real parent-child relationship.
- Putting too much unrelated logic in the base class.
- Repeating shared code in derived classes instead of reusing the base class.
- Creating deep inheritance chains that are hard to understand.
