# 03 Constructors

## Concept Explanation
A constructor is a special method in a class that runs automatically when an object is created. It helps initialize the object with default or required values. In C#, the constructor name must match the class name and it does not have a return type.

## Real-World Analogy
When a new employee joins a company, onboarding happens immediately. That onboarding process is like a constructor because it sets the employee up with required details before regular work begins.

## Syntax
```csharp
public class Employee
{
    public string Name { get; set; }

    public Employee()
    {
        Name = "New Employee";
    }
}
```

## Step-by-Step Explanation
1. Create a class.
2. Add a constructor with the same name as the class.
3. Put initialization logic inside the constructor.
4. Create an object with `new`.
5. Notice that the constructor runs automatically.

## Best Practices
- Use constructors to ensure objects start in a valid state.
- Keep constructor logic simple and focused on initialization.
- Provide clear defaults if needed.
- Use parameterized constructors when some values are required.

## Common Mistakes
- Giving constructors a return type.
- Forgetting that constructors run automatically.
- Writing too much business logic inside constructors.
- Leaving important members uninitialized.
