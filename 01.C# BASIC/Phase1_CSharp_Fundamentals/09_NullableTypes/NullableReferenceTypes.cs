#nullable enable

internal static class NullableReferenceTypes
{
    public static void Run()
    {
        ShowNullableReferenceTypes();
    }

    #region 01 - string? vs string
    private static void ShowNullableReferenceTypes()
    {
        // #nullable enable turns on compiler support for nullable reference types.
        // string means the variable should not be null.
        // string? means the variable can be null, so the compiler expects you to handle that safely.
        // These warnings help prevent NullReferenceException before runtime.

        string customerCode = "CUST-1001";
        string? middleName = null;
        bool customerCodeHasText = customerCode.Length > 0;
        int middleNameLength = middleName?.Length ?? 0;

        Console.WriteLine("\n01 - string? vs string"); // Output: 01 - string? vs string
        Console.WriteLine($"Customer Code: {customerCode}"); // Output: Customer Code: CUST-1001
        Console.WriteLine($"Customer Code Has Text: {customerCodeHasText}"); // Output: Customer Code Has Text: True
        Console.WriteLine($"Middle Name Is Null: {middleName is null}"); // Output: Middle Name Is Null: True
        Console.WriteLine($"Middle Name Length: {middleNameLength}"); // Output: Middle Name Length: 0

        // Mistake:
        // Ignoring nullable warnings defeats the purpose of nullable reference types.
        // If the compiler says a value may be null, handle it before using it.

        // 🌍 Real-World Analogy:
        // Think of nullable reference types like warning signs on a road.
        // They alert you before you enter a risky area.
    }
    #endregion
}
