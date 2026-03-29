internal static class DeconstructionExamples
{
    public static void Run()
    {
        ShowBasicDeconstruction();
        ShowMethodDeconstruction();
        ShowDeconstructionInForeach();
    }

    #region 01 - Basic Deconstruction
    private static void ShowBasicDeconstruction()
    {
        // Deconstruction splits a tuple into separate variables.
        // This makes multiple returned values easier to use.
        // Variable order matters, so match the tuple positions correctly.
        // This is common in small utility methods and data transformations.

        (int id, string name) customer = (101, "Anita");
        (int customerId, string customerName) = customer;

        Console.WriteLine("\n01 - Basic Deconstruction"); // Output: 01 - Basic Deconstruction
        Console.WriteLine($"Customer Id: {customerId}"); // Output: Customer Id: 101
        Console.WriteLine($"Customer Name: {customerName}"); // Output: Customer Name: Anita

        // Mistake:
        // Wrong variable order gives wrong values without always being obvious.
        // Keep the deconstruction order aligned with the tuple order.

        // 🌍 Real-World Analogy:
        // Think of deconstruction like unpacking a delivery box into separate labeled shelves.
        // Each item goes into its own place.
    }
    #endregion

    #region 02 - Method Deconstruction
    private static void ShowMethodDeconstruction()
    {
        // Deconstruction is very useful with method returns.
        // It lets you directly unpack multiple values from one method call.
        // This is one of the most-used tuple patterns in real applications.
        // It keeps calling code short and readable.

        var (totalOrders, totalRevenue) = GetOrderSummary();

        Console.WriteLine("\n02 - Method Deconstruction"); // Output: 02 - Method Deconstruction
        Console.WriteLine($"Total Orders: {totalOrders}"); // Output: Total Orders: 25
        Console.WriteLine($"Total Revenue: {totalRevenue}"); // Output: Total Revenue: 125000

        // Mistake:
        // Some developers return a tuple but then still access Item1 and Item2 later.
        // Deconstruction is cleaner when both values are needed immediately.

        // 🌍 Real-World Analogy:
        // Think of this like opening a report and directly taking out count and revenue.
        // You get both values ready to use at once.
    }
    #endregion

    #region 03 - Deconstruction In foreach
    private static void ShowDeconstructionInForeach()
    {
        // You can deconstruct tuples directly inside foreach loops.
        // This is useful for simple pair data such as id-name, key-value, or city-sales.
        // It also feels natural with LINQ-style result shapes.
        // This keeps the loop code small and expressive.

        List<(int Id, string Name)> employees = new()
        {
            (201, "Rahul"),
            (202, "Deepa")
        };

        Console.WriteLine("\n03 - Deconstruction In foreach"); // Output: 03 - Deconstruction In foreach

        foreach ((int employeeId, string employeeName) in employees)
        {
            Console.WriteLine($"Employee: {employeeId} - {employeeName}"); // Output: Employee: 201 - Rahul ... Employee: 202 - Deepa
        }

        // Mistake:
        // If the tuple order changes and the foreach variables are not updated, the output becomes wrong.
        // Keep tuple creation and deconstruction aligned.

        // 🌍 Real-World Analogy:
        // Think of foreach deconstruction like reading rows from a short attendance list.
        // Each row is unpacked directly into id and name.
    }
    #endregion

    private static (int totalOrders, decimal totalRevenue) GetOrderSummary()
    {
        return (25, 125000m);
    }
}
