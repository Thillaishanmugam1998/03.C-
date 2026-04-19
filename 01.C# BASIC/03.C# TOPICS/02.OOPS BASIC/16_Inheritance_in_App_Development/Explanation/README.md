# 16 Inheritance in App Development

## Concept Explanation
Inheritance is often used in applications to share common behavior across related components. For example, screens, users, documents, or notifications may share base functionality while still having specialized behavior.

## Real-World Analogy
In a company app, every user may have common details such as name and email. An admin user and a customer user both inherit those common features but perform different actions.

## Syntax
```csharp
public class AppUser
{
    public string Name { get; set; } = string.Empty;
}

public class AdminUser : AppUser
{
    public void ManageUsers() { }
}
```

## Step-by-Step Explanation
1. Find repeated behavior in similar application objects.
2. Move shared logic to a base class.
3. Derive specialized classes for specific roles.
4. Add unique behavior in child classes.

## Best Practices
- Use inheritance when application models have a real hierarchy.
- Keep shared behavior in the base class.
- Avoid forcing unrelated classes into the same inheritance tree.
- Recheck if interfaces or composition are more flexible.

## Common Mistakes
- Creating a base class that is too generic.
- Putting role-specific logic into the base class.
- Using inheritance only because several classes look similar.
