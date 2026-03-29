internal static class EnumRealWorldUsage
{
    public static void Run()
    {
        ShowEnumInSwitch();
        ShowPracticalScenarios();
        ShowEnumValidation();
    }

    #region 01 - Enum In Switch
    private static void ShowEnumInSwitch()
    {
        // Enums work very well in switch statements.
        // This makes business logic more readable than comparing magic numbers or strings.
        // Switch with enums is common in order processing, workflow steps, and user permissions.
        // It helps group behavior by state clearly.

        OrderStatus orderStatus = OrderStatus.Completed;
        string orderMessage = orderStatus switch
        {
            OrderStatus.Pending => "Order is waiting for processing",
            OrderStatus.Completed => "Order completed successfully",
            OrderStatus.Cancelled => "Order has been cancelled",
            _ => "Order status is unknown"
        };

        Console.WriteLine("\n01 - Enum In Switch"); // Output: 01 - Enum In Switch
        Console.WriteLine($"Order Status: {orderStatus}"); // Output: Order Status: Completed
        Console.WriteLine($"Order Message: {orderMessage}"); // Output: Order Message: Order completed successfully

        // Mistake:
        // Using raw numbers in switch blocks makes code hard to understand and maintain.
        // Enums make each case readable.

        // 🌍 Real-World Analogy:
        // Think of a switch with enums like routing parcels by labeled destination.
        // Each label clearly decides the next action.
    }
    #endregion

    #region 02 - Practical Scenarios
    private static void ShowPracticalScenarios()
    {
        // Enums are heavily used for statuses, roles, and feature settings in real applications.
        // They improve readability, reduce bugs, and avoid magic numbers.
        // ToString is often used for logging and UI output.
        // Comparison is also common for workflow rules.

        OrderStatus orderStatus = OrderStatus.Pending;
        UserRole userRole = UserRole.Admin;
        FeatureOptions enabledFeatures = FeatureOptions.Reports | FeatureOptions.Notifications;
        bool isAdmin = userRole == UserRole.Admin;
        string roleText = userRole.ToString();

        Console.WriteLine("\n02 - Practical Scenarios"); // Output: 02 - Practical Scenarios
        Console.WriteLine($"Order Status: {orderStatus}"); // Output: Order Status: Pending
        Console.WriteLine($"User Role: {roleText}"); // Output: User Role: Admin
        Console.WriteLine($"Enabled Features: {enabledFeatures}"); // Output: Enabled Features: Reports, Notifications
        Console.WriteLine($"Is Admin: {isAdmin}"); // Output: Is Admin: True

        // Mistake:
        // Using magic numbers like 1, 2, 3 for status or role codes makes bugs harder to spot.
        // Enums keep meaning clear in code reviews and interviews.

        // 🌍 Real-World Analogy:
        // Think of enums here like labeled badges in a company.
        // The badge clearly shows role, status, or enabled access.
    }
    #endregion

    #region 03 - Validation
    private static void ShowEnumValidation()
    {
        // Enum.IsDefined checks whether a value really exists in the enum.
        // This is important when values come from APIs, databases, or external files.
        // It helps validate numeric input before trusting it.
        // This is commonly used after enum casting.

        int validOrderStatusCode = 2;
        int invalidOrderStatusCode = 7;
        bool validCodeExists = Enum.IsDefined(typeof(OrderStatus), validOrderStatusCode);
        bool invalidCodeExists = Enum.IsDefined(typeof(OrderStatus), invalidOrderStatusCode);

        Console.WriteLine("\n03 - Validation"); // Output: 03 - Validation
        Console.WriteLine($"Valid Code 2 Exists: {validCodeExists}"); // Output: Valid Code 2 Exists: True
        Console.WriteLine($"Invalid Code 7 Exists: {invalidCodeExists}"); // Output: Invalid Code 7 Exists: False

        // Mistake:
        // Casting 7 to OrderStatus succeeds, but that does not make it a valid defined member.
        // Use Enum.IsDefined when external numeric values must be validated.

        // 🌍 Real-World Analogy:
        // Think of validation like checking whether a room number actually exists in a hotel.
        // A number may look valid, but the room may not exist.
    }
    #endregion

    private enum OrderStatus
    {
        Pending = 0,
        Completed = 1,
        Cancelled = 2
    }

    private enum UserRole
    {
        Guest = 0,
        User = 1,
        Admin = 2
    }

    [Flags]
    private enum FeatureOptions
    {
        None = 0,
        Reports = 1,
        Notifications = 2,
        AuditTrail = 4
    }
}
