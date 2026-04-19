# 01 Object Oriented Programming (OOPs)

## Concept Explanation
Object Oriented Programming (OOP) is a programming style where we model real-world things as software objects. Each object contains data and behavior. In C#, OOP helps us organize code into classes so programs become easier to read, reuse, test, and maintain.

The four main pillars of OOP are:
- Encapsulation
- Abstraction
- Inheritance
- Polymorphism

## Real-World Analogy
Think of a car. A car has data such as brand, model, and speed. It also has behavior such as start, stop, and accelerate. In OOP, we describe the blueprint of a car in a class and then create real car objects from that blueprint.

## Syntax
```csharp
public class Car
{
    public string Brand;

    public void Start()
    {
        Console.WriteLine("Car started.");
    }
}

Car myCar = new Car();
myCar.Brand = "Toyota";
myCar.Start();
```

## Step-by-Step Explanation
1. Create a class to represent a concept from the real world.
2. Add fields or properties to store data.
3. Add methods to define behavior.
4. Create objects from the class using the `new` keyword.
5. Use those objects to access data and behavior.

## Best Practices
- Create classes that represent clear real-world responsibilities.
- Keep data and related behavior together.
- Prefer properties over public fields in real applications.
- Use meaningful names for classes and methods.
- Avoid creating very large classes with too many responsibilities.

## Common Mistakes
- Treating OOP as only class creation instead of modeling behavior and responsibility.
- Making everything public.
- Creating classes with unrelated members.
- Forgetting that objects are created from class blueprints.
