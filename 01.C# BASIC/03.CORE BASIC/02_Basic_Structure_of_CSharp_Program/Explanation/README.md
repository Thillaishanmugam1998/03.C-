# Basic Structure of C# Program

## Concept Explanation
A basic C# program is made up of organized parts that help the compiler understand how the application should run. In beginner-friendly examples, these parts usually include `using` directives, a `namespace`, a `class`, and the `Main` method.

The `Main` method is the entry point of the program. This means the program starts executing from there.

## Real-World Analogy
Think of a C# program like a school building:

- `using` directives are like the list of resources the school can access.
- `namespace` is the school campus name.
- `class` is a classroom.
- `Main` method is the teacher starting the lesson.
- Statements inside `Main` are the actual lesson activities.

## Syntax
```csharp
using System;

namespace SampleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello from Main!");
    }
}
```

## Step-by-Step Explanation
1. `using System;` allows us to use built-in features like `Console`.
2. `namespace SampleApp;` groups related code under one name.
3. `internal class Program` defines a class named `Program`.
4. `private static void Main(string[] args)` defines the starting point of the application.
5. `Console.WriteLine(...)` runs when the program starts and prints text to the console.

## Best Practices
- Keep the program structure clear and consistent.
- Use meaningful namespace and class names.
- Keep `Main` simple in beginner examples.
- Add comments when learning so each section is easy to recognize.

## Common Mistakes
- Forgetting braces around the class or method body.
- Misspelling `Main`, which can stop the program from running as expected.
- Confusing the purpose of `namespace`, `class`, and `Main`.
- Writing statements outside the method body when using the class-based structure.
