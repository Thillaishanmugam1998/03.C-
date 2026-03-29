internal static class EnumFlagsExample
{
    public static void Run()
    {
        ShowFlagsAttribute();
        ShowCheckingFlags();
    }

    #region 01 - Flags Attribute
    private static void ShowFlagsAttribute()
    {
        // [Flags] is used when an enum should hold multiple combined values.
        // Each value should be a power of 2 so combinations work correctly.
        // This is common for permissions, feature toggles, and access rights.
        // Bitwise OR combines multiple flags into one value.

        AccessRights userRights = AccessRights.Read | AccessRights.Write;
        int userRightsCode = (int)userRights;

        Console.WriteLine("\n01 - [Flags] Attribute"); // Output: 01 - [Flags] Attribute
        Console.WriteLine($"User Rights: {userRights}"); // Output: User Rights: Read, Write
        Console.WriteLine($"User Rights Code: {userRightsCode}"); // Output: User Rights Code: 3

        // Mistake:
        // If flags are not assigned as powers of 2, combinations can overlap and become incorrect.
        // Use 1, 2, 4, 8, 16 and so on for flag values.

        // 🌍 Real-World Analogy:
        // Think of flags like switches on a machine.
        // You can turn on one switch or many switches together.
    }
    #endregion

    #region 02 - Checking Flags
    private static void ShowCheckingFlags()
    {
        // HasFlag checks whether a combined enum contains a specific flag.
        // Bitwise AND is another common way to check flags.
        // Both approaches are used in production code.
        // Feature flags and role permissions often use these checks.

        AccessRights adminRights = AccessRights.Read | AccessRights.Write | AccessRights.Delete;
        bool hasDelete = adminRights.HasFlag(AccessRights.Delete);
        bool hasWrite = (adminRights & AccessRights.Write) == AccessRights.Write;
        bool hasExport = adminRights.HasFlag(AccessRights.Export);

        Console.WriteLine("\n02 - Checking Flags"); // Output: 02 - Checking Flags
        Console.WriteLine($"Admin Rights: {adminRights}"); // Output: Admin Rights: Read, Write, Delete
        Console.WriteLine($"Has Delete: {hasDelete}"); // Output: Has Delete: True
        Console.WriteLine($"Has Write: {hasWrite}"); // Output: Has Write: True
        Console.WriteLine($"Has Export: {hasExport}"); // Output: Has Export: False

        // Mistake:
        // Using normal enum values without [Flags] can make combined values hard to understand.
        // Use [Flags] when one variable must store multiple options together.

        // 🌍 Real-World Analogy:
        // Think of permission flags like access cards in an office.
        // One card can grant entry to multiple rooms at the same time.
    }
    #endregion

    [Flags]
    private enum AccessRights
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Export = 8
    }
}
