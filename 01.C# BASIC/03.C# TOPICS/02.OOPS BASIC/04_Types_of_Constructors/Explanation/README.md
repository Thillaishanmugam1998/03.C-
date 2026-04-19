# 04 Types of Constructors

## Concept Explanation
In C#, common constructor types include default constructors, parameterized constructors, copy-style constructors created by developers, static constructors, and private constructors. Each type serves a different initialization purpose.

## Real-World Analogy
Think of buying a mobile phone:
- Default setup: comes with standard settings.
- Customized setup: configured with your language and account.
- Company-wide setup: a one-time system activation.
- Restricted setup: only the company can create certain internal devices.

## Syntax
```csharp
public class Product
{
    public string Name { get; }

    public Product()
    {
        Name = "Unknown";
    }

    public Product(string name)
    {
        Name = name;
    }
}
```

## Step-by-Step Explanation
1. Create a class.
2. Add a constructor without parameters for default values.
3. Add another constructor with parameters for custom values.
4. Use the proper constructor depending on the situation.
5. Understand that some special types like static and private constructors have restricted usage.

## Best Practices
- Provide only constructors that make sense for the object.
- Use constructor overloading to support different initialization needs.
- Avoid too many overloads with confusing parameter combinations.
- Keep constructor intent clear.

## Common Mistakes
- Creating too many constructors without a clear reason.
- Not distinguishing default and parameterized constructor use cases.
- Assuming C# automatically creates a default constructor after a custom one is added.
- Misunderstanding static and private constructors.
