internal static class NamedTuples
{
    public static void Run()
    {
        ShowNamedTuples();
        ShowAccessNamedValues();
    }

    #region 01 - Named Tuples
    private static void ShowNamedTuples()
    {
        // Named tuples give meaningful names to tuple elements.
        // This improves readability compared to Item1 and Item2.
        // They are common when returning multiple values from methods.
        // Good names make code easier for the next developer to understand.

        (int Id, string Name, decimal Price) product = (501, "Keyboard", 1499m);

        Console.WriteLine("\n01 - Named Tuples"); // Output: 01 - Named Tuples
        Console.WriteLine($"Product Tuple: {product}"); // Output: Product Tuple: (501, Keyboard, 1499)
        Console.WriteLine($"Product Id: {product.Id}"); // Output: Product Id: 501

        // Mistake:
        // Using vague names like Value1 or Data1 removes the benefit of named tuples.
        // Use names that clearly describe the fields.

        // 🌍 Real-World Analogy:
        // Think of a named tuple like a labeled mini form.
        // Each field is easier to read because it has a clear label.
    }
    #endregion

    #region 02 - Access Named Values
    private static void ShowAccessNamedValues()
    {
        // Named fields are more readable than Item1 and Item2.
        // Accessing tuple.Name is usually better for clarity.
        // Mixing named fields and Item syntax in the same code can confuse readers.
        // Choose one style and prefer names when available.

        (int EmployeeId, string EmployeeName) employee = (301, "Kavin");
        int employeeId = employee.EmployeeId;
        string employeeName = employee.EmployeeName;
        int employeeIdWithItem = employee.Item1;

        Console.WriteLine("\n02 - Access Named Values"); // Output: 02 - Access Named Values
        Console.WriteLine($"Employee Id: {employeeId}"); // Output: Employee Id: 301
        Console.WriteLine($"Employee Name: {employeeName}"); // Output: Employee Name: Kavin
        Console.WriteLine($"Employee Id Using Item1: {employeeIdWithItem}"); // Output: Employee Id Using Item1: 301

        // Mistake:
        // Mixing Item1 and named fields in the same business code reduces readability.
        // Prefer the named fields when they exist.

        // 🌍 Real-World Analogy:
        // Think of it like reading a file by labeled tabs instead of by position numbers.
        // The labels make navigation clearer.
    }
    #endregion
}
