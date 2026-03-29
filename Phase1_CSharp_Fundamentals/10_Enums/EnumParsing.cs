internal static class EnumParsing
{
    public static void Run()
    {
        ShowEnumParse();
        ShowEnumTryParse();
    }

    #region 01 - Enum.Parse
    private static void ShowEnumParse()
    {
        // Enum.Parse converts text into an enum value.
        // It is useful when input is known to be valid.
        // You can also ignore case by passing true.
        // This is often seen in config files or controlled inputs.

        string inputText = "Completed";
        OrderState parsedState = Enum.Parse<OrderState>(inputText);
        OrderState parsedIgnoreCaseState = Enum.Parse<OrderState>("cancelled", ignoreCase: true);

        Console.WriteLine("\n01 - Enum.Parse"); // Output: 01 - Enum.Parse
        Console.WriteLine($"Parsed State: {parsedState}"); // Output: Parsed State: Completed
        Console.WriteLine($"Parsed Ignore Case State: {parsedIgnoreCaseState}"); // Output: Parsed Ignore Case State: Cancelled

        // Mistake:
        // Enum.Parse throws an exception if the input is invalid.
        // Do not use it with untrusted user input unless you validate first.

        // 🌍 Real-World Analogy:
        // Think of Enum.Parse like reading a known label from a trusted form.
        // When the label is correct, the system maps it to the internal status.
    }
    #endregion

    #region 02 - Enum.TryParse
    private static void ShowEnumTryParse()
    {
        // Enum.TryParse is safer than Parse because it does not throw for invalid input.
        // This is one of the most-used enum methods in real applications.
        // It is perfect for user input, API text, query strings, and imported files.
        // Always prefer it when the source may be invalid.

        string userInput = "Pending";
        string invalidInput = "Waiting";

        bool parsedPending = Enum.TryParse(userInput, out OrderState pendingState);
        bool parsedInvalid = Enum.TryParse(invalidInput, out OrderState invalidState);

        Console.WriteLine("\n02 - Enum.TryParse"); // Output: 02 - Enum.TryParse
        Console.WriteLine($"Parsed Pending: {parsedPending}"); // Output: Parsed Pending: True
        Console.WriteLine($"Pending State: {pendingState}"); // Output: Pending State: Pending
        Console.WriteLine($"Parsed Invalid Input: {parsedInvalid}"); // Output: Parsed Invalid Input: False
        Console.WriteLine($"Invalid State Result: {invalidState}"); // Output: Invalid State Result: Draft

        // Mistake:
        // Many beginners use Parse everywhere and then get runtime exceptions for bad input.
        // Use TryParse for safe conversion when values come from outside the program.

        // 🌍 Real-World Analogy:
        // Think of TryParse like a security guard checking an ID before entry.
        // Invalid input is handled safely instead of crashing the system.
    }
    #endregion

    private enum OrderState
    {
        Draft = 0,
        Pending = 1,
        Completed = 2,
        Cancelled = 3
    }
}
