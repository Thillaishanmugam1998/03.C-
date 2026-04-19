namespace MethodHidingApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Method hiding creates a new version of a base method in the derived class.
        // Which method runs depends on the reference type, not only the object type.
        #endregion

        #region Example
        BaseReporter baseReference = new AdvancedReporter();
        AdvancedReporter derivedReference = new();

        baseReference.Show();
        derivedReference.Show();
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. Hidden methods are different from overridden methods.");
        Console.WriteLine("2. Reference type affects which Show method is called.");
        #endregion
    }
}

internal class BaseReporter
{
    public void Show()
    {
        Console.WriteLine("Base reporter output.");
    }
}

internal sealed class AdvancedReporter : BaseReporter
{
    public new void Show()
    {
        Console.WriteLine("Advanced reporter output.");
    }
}
