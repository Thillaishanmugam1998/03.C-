internal static class NullableValueTypes
{
    public static void Run()
    {
        ShowNullableValueTypes();
    }

    #region 01 - Nullable Value Types (int?)
    private static void ShowNullableValueTypes()
    {
        // int? is a short form of Nullable<int>.
        // It allows a value type to store either a normal number or null.
        // This is common for optional age, optional discount, or optional database values.
        // HasValue, Value, and GetValueOrDefault() are used often in real projects.

        int? optionalAge = 25;
        int? missingAge = null;
        Nullable<int> optionalScore = 88;
        bool hasAge = optionalAge.HasValue;
        int ageValue = optionalAge.Value;
        int missingAgeDefault = missingAge.GetValueOrDefault();
        int missingAgeCustomDefault = missingAge.GetValueOrDefault(18);

        Console.WriteLine("\n01 - Nullable Value Types (int?)"); // Output: 01 - Nullable Value Types (int?)
        Console.WriteLine($"Optional Age Has Value: {hasAge}"); // Output: Optional Age Has Value: True
        Console.WriteLine($"Optional Age Value: {ageValue}"); // Output: Optional Age Value: 25
        Console.WriteLine($"Missing Age Is Null: {missingAge is null}"); // Output: Missing Age Is Null: True
        Console.WriteLine($"Optional Score Value: {optionalScore.GetValueOrDefault()}"); // Output: Optional Score Value: 88
        Console.WriteLine($"Missing Age Default: {missingAgeDefault}"); // Output: Missing Age Default: 0
        Console.WriteLine($"Missing Age Custom Default: {missingAgeCustomDefault}"); // Output: Missing Age Custom Default: 18

        // Mistake:
        // Accessing missingAge.Value without checking HasValue throws InvalidOperationException.
        // Always check HasValue or use GetValueOrDefault() when null is possible.

        // 🌍 Real-World Analogy:
        // Think of a nullable value like an optional form field.
        // A customer may enter a value, or leave it empty.
    }
    #endregion
}
