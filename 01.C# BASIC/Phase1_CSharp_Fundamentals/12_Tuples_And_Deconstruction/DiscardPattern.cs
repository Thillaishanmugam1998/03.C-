internal static class DiscardPattern
{
    public static void Run()
    {
        ShowDiscardPattern();
        ShowOutVariableDeconstruction();
    }

    #region 01 - Discard
    private static void ShowDiscardPattern()
    {
        // The discard symbol _ is used when you do not need one of the returned values.
        // This keeps the code cleaner than creating unused variables.
        // It is often used with tuples, deconstruction, and pattern matching.
        // Discards improve readability when some returned values are not important.

        var (_, employeeName) = GetEmployeeIdentity();

        Console.WriteLine("\n01 - Discard"); // Output: 01 - Discard
        Console.WriteLine($"Employee Name: {employeeName}"); // Output: Employee Name: Priya

        // Mistake:
        // Creating temporary unused variables adds noise to the code.
        // Use _ when a returned value is not needed.

        // 🌍 Real-World Analogy:
        // Think of discard like ignoring the wrapper and keeping only the item you need.
        // You do not store what has no value to you.
    }
    #endregion

    #region 02 - out Variable Deconstruction
    private static void ShowOutVariableDeconstruction()
    {
        // out var lets you declare the output variable directly in the method call.
        // This is commonly used with TryParse methods.
        // It keeps code shorter and is widely used in production code.
        // It is not tuple deconstruction, but it follows the same idea of unpacking values cleanly.

        bool parsedAge = int.TryParse("29", out int age);
        bool parsedInvalid = int.TryParse("abc", out _);

        Console.WriteLine("\n02 - out Variable Deconstruction"); // Output: 02 - out Variable Deconstruction
        Console.WriteLine($"Parsed Age: {parsedAge}"); // Output: Parsed Age: True
        Console.WriteLine($"Age Value: {age}"); // Output: Age Value: 29
        Console.WriteLine($"Parsed Invalid Input: {parsedInvalid}"); // Output: Parsed Invalid Input: False

        // Mistake:
        // Keeping unused out variables makes code harder to scan.
        // Use out _ when the output value is not needed.

        // 🌍 Real-World Analogy:
        // Think of out var like getting a result slip directly from a machine.
        // You take the useful output only when you need it.
    }
    #endregion

    private static (int Id, string Name) GetEmployeeIdentity()
    {
        return (401, "Priya");
    }
}
