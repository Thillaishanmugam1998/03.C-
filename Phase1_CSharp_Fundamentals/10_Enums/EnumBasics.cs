internal static class EnumBasics
{
    public static void Run()
    {
        ShowEnumDefinition();
        ShowEnumCasting();
    }

    #region 01 - Enum Definition
    private static void ShowEnumDefinition()
    {
        // An enum is a named set of constant values.
        // It makes code easier to read than plain numbers.
        // You can assign custom numeric values when business rules need them.
        // If you do not assign 0 carefully, default enum values can become confusing.

        TicketPriority priority = TicketPriority.High;
        TicketPriority defaultPriority = default;
        int highPriorityNumber = (int)priority;

        Console.WriteLine("\n01 - Enum Definition"); // Output: 01 - Enum Definition
        Console.WriteLine($"Priority Name: {priority}"); // Output: Priority Name: High
        Console.WriteLine($"Priority Numeric Value: {highPriorityNumber}"); // Output: Priority Numeric Value: 2
        Console.WriteLine($"Default Priority: {defaultPriority}"); // Output: Default Priority: None

        // Mistake:
        // If 0 does not represent a valid first state, default enum values may hold an unexpected value.
        // In real projects, keep a safe 0 value like None or Unknown when possible.

        // 🌍 Real-World Analogy:
        // Think of an enum like labels on delivery packages.
        // A label such as High or Low is clearer than remembering a raw number.
    }
    #endregion

    #region 02 - Enum To Int And Int To Enum
    private static void ShowEnumCasting()
    {
        // Casting from enum to int gives the underlying numeric value.
        // Casting from int to enum converts the number into the enum type.
        // This is common when working with database codes, API values, or config settings.
        // Enum comparison is also common because it is fast and readable.

        TicketPriority mediumPriority = TicketPriority.Medium;
        int mediumPriorityCode = (int)mediumPriority;
        TicketPriority priorityFromCode = (TicketPriority)3;
        bool isHighPriority = priorityFromCode == TicketPriority.High;
        bool isHigherThanMedium = priorityFromCode > TicketPriority.Medium;

        Console.WriteLine("\n02 - Enum To Int And Int To Enum"); // Output: 02 - Enum To Int And Int To Enum
        Console.WriteLine($"Medium Priority Code: {mediumPriorityCode}"); // Output: Medium Priority Code: 1
        Console.WriteLine($"Priority From Code 3: {priorityFromCode}"); // Output: Priority From Code 3: High
        Console.WriteLine($"Is High Priority: {isHighPriority}"); // Output: Is High Priority: True
        Console.WriteLine($"Is Higher Than Medium: {isHigherThanMedium}"); // Output: Is Higher Than Medium: True

        // Mistake:
        // Casting any int to an enum is allowed, even if that value is not actually defined.
        // Validate external values before trusting them.

        // 🌍 Real-World Analogy:
        // Think of enum casting like converting a status label to a stored code and back again.
        // The app shows the friendly label, while the database may store the number.
    }
    #endregion

    private enum TicketPriority
    {
        None = 0,
        Medium = 1,
        High = 2,
        Critical = 3
    }
}
