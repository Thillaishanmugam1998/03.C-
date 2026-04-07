# Console Class Methods & Properties

## Concept Explanation
The `Console` class in C# is used in console applications to interact with the terminal window. It helps us display output, take input, and access information about the console environment.

Methods are used to perform actions. For example:
- `Console.WriteLine()` prints text and moves to the next line.
- `Console.Write()` prints text without moving to the next line.
- `Console.ReadLine()` reads a full line of input.
- `Console.ReadKey()` reads a key press.

Properties store or expose information about the console. For example:
- `Console.Title`
- `Console.ForegroundColor`
- `Console.BackgroundColor`
- `Console.LargestWindowWidth`

## Real-World Analogy
Think of the `Console` class like a receptionist desk:

- Methods are the actions the receptionist performs, such as speaking or listening.
- Properties are the details about the reception area, such as its title board, colors, or size.

## Syntax
```csharp
Console.Title = "My App";
Console.WriteLine("Hello!");
Console.Write("Enter your name: ");
string? name = Console.ReadLine();
Console.ReadKey();
```

## Step-by-Step Explanation
1. `Console.Title = "My App";` changes the title of the console window.
2. `Console.WriteLine("Hello!");` prints a message and moves to a new line.
3. `Console.Write("Enter your name: ");` prints text without moving to the next line.
4. `Console.ReadLine();` waits for the user to type and press Enter.
5. `Console.ReadKey();` waits for a single key press.
6. Properties such as `LargestWindowWidth` give information about the current system console.

## Best Practices
- Use `WriteLine` for readable output.
- Use `Write` when you want user input on the same line as the prompt.
- Be careful when changing console colors or title so the output remains clear.
- Remember that some console properties depend on the operating system and terminal.

## Common Mistakes
- Confusing `Write` and `WriteLine`.
- Forgetting that `ReadLine()` can return `null`.
- Using `ReadKey()` in automated environments where no keyboard input is available.
- Assuming console size-related properties are the same on every computer.
