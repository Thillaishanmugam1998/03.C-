# 02 Class and Objects

## Concept Explanation
A class is a blueprint. An object is the actual instance created from that blueprint. In C#, a class defines what data and behavior an object should have, and objects are the real usable items in memory.

## Real-World Analogy
A house plan is like a class. The actual house built from that plan is like an object. Many houses can be built from one plan, just as many objects can be created from one class.

## Syntax
```csharp
public class Student
{
    public string Name = string.Empty;

    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}.");
    }
}

Student student1 = new Student();
student1.Name = "Anu";
student1.Introduce();
```

## Step-by-Step Explanation
1. Define a class using the `class` keyword.
2. Add members such as fields, properties, and methods.
3. Create an object using `new`.
4. Store the object in a variable.
5. Access the members using the dot operator.

## Best Practices
- Use PascalCase for class names.
- Give each class one clear purpose.
- Initialize members properly.
- Prefer properties for data exposure.
- Keep objects small and meaningful for learning examples.

## Common Mistakes
- Confusing a class with an object.
- Forgetting to create an object before using instance members.
- Using one object variable as if it creates multiple objects automatically.
- Not setting required values before calling methods.
