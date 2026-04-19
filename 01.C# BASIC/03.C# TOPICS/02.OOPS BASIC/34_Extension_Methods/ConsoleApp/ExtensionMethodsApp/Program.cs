namespace ExtensionMethodsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Extension methods add useful functionality to existing types
        // without modifying the original type definition.
        #endregion

        #region Example
        string courseName = "c# oop basics";
        Console.WriteLine(courseName.ToTitleStyle());

        int mark = 82;
        Console.WriteLine($"Has passed: {mark.IsPassingMark()}");
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Extension methods are defined in static classes.");
        Console.WriteLine("2. They are called like instance methods.");
        #endregion
    }
}

internal static class LearningExtensions
{
    public static string ToTitleStyle(this string value)
    {
        return value.ToUpperInvariant();
    }

    public static bool IsPassingMark(this int mark)
    {
        return mark >= 40;
    }
}
