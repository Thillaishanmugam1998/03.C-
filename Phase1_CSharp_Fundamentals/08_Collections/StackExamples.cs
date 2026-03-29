internal static class StackExamples
{
    public static void Run()
    {
        PrintSeparator();
        ShowStackBasics();
        PrintSeparator();
        ShowImportantStackMembers();
    }

    #region 01 - Stack (LIFO)
    private static void ShowStackBasics()
    {
        // Stack<T> follows Last In, First Out order.
        // The last item added is the first item removed.
        // Common operations are Push, Pop, and Peek.
        // This is useful for undo operations, browser history, and expression evaluation.

        Stack<string> browserTabs = new();
        browserTabs.Push("Home");
        browserTabs.Push("Products");
        browserTabs.Push("Checkout");

        string currentTab = browserTabs.Peek();
        string closedTab = browserTabs.Pop();

        Console.WriteLine("\n01 - Stack (LIFO)"); // Output: 01 - Stack (LIFO)
        Console.WriteLine($"Current Tab Before Pop: {currentTab}"); // Output: Current Tab Before Pop: Checkout
        Console.WriteLine($"Closed Tab: {closedTab}"); // Output: Closed Tab: Checkout
        Console.WriteLine($"Next Tab: {browserTabs.Peek()}"); // Output: Next Tab: Products

        foreach (string tab in browserTabs)
        {
            Console.WriteLine($"Remaining Tab: {tab}"); // Output: Remaining Tab: Products ... Remaining Tab: Home
        }

        // Mistake:
        // Beginners sometimes expect Stack<T> to remove the oldest item first.
        // Stack<T> always removes the newest item first.

        // 🌍 Real-World Analogy:
        // Think of a stack like plates in a canteen.
        // The last plate placed on top is the first plate taken out.
    }
    #endregion

    #region 02 - Important Stack Members
    private static void ShowImportantStackMembers()
    {
        // Count tells how many items are inside the stack.
        // Contains checks whether a value exists.
        // Clear removes everything.
        // Peek should be used carefully because calling it on an empty stack throws an exception.

        Stack<int> undoSteps = new();
        undoSteps.Push(1);
        undoSteps.Push(2);
        undoSteps.Push(3);
        bool hasStepTwo = undoSteps.Contains(2);
        int stepCountBeforeClear = undoSteps.Count;
        undoSteps.Clear();

        Console.WriteLine("\n02 - Important Stack Members"); // Output: 02 - Important Stack Members
        Console.WriteLine($"Contains Step 2: {hasStepTwo}"); // Output: Contains Step 2: True
        Console.WriteLine($"Count Before Clear: {stepCountBeforeClear}"); // Output: Count Before Clear: 3
        Console.WriteLine($"Count After Clear: {undoSteps.Count}"); // Output: Count After Clear: 0

        // Mistake:
        // Calling Pop() or Peek() on an empty stack throws InvalidOperationException.
        // Check Count before removing or reading items.

        // 🌍 Real-World Analogy:
        // Think of stack members like checking how many undo actions are available in a text editor.
        // You can inspect, count, or clear that undo history.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
