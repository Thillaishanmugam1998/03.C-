namespace PrivateConstructorsApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // A private constructor prevents outside code from creating objects directly.
        // This is useful when a class wants to control instance creation.
        #endregion

        #region Example
        AppSettings settings = AppSettings.Instance;
        settings.ShowSettings();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. External code cannot create the class with new.");
        Console.WriteLine("2. The class exposes a controlled shared instance.");
        #endregion
    }
}

internal class AppSettings
{
    public static AppSettings Instance { get; } = new();
    public string ApplicationName { get; }

    private AppSettings()
    {
        ApplicationName = "CSharp Basics Learning";
    }

    public void ShowSettings()
    {
        Console.WriteLine($"Application Name: {ApplicationName}");
    }
}
