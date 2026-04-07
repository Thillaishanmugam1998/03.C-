# User Input and Output

## Concept Explanation
Input means taking data from the user. Output means showing data to the user.

## Real-World Analogy
Think of it like a conversation: one person asks or answers, and the other person listens or speaks back.

## Syntax
```csharp
Console.Write("Enter name: ");
string? name = Console.ReadLine();
Console.WriteLine(name);
```

## Step-by-Step Explanation
1. `Console.Write` displays a prompt.
2. `Console.ReadLine` reads text from the user.
3. `Console.WriteLine` prints the result.

## Best Practices
- Always validate user input.
- Show clear prompts.

## Common Mistakes
- Assuming input is never empty.
- Forgetting `ReadLine()` can return `null`.
