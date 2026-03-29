internal static class ListExamples
{
    public static void Run()
    {
        PrintSeparator();
        ShowListBasics();
        PrintSeparator();
        ShowImportantMethods();
        PrintSeparator();
        ShowPropertiesAndConcepts();
    }

    #region 01 - List Basics
    private static void ShowListBasics()
    {
        // List<T> stores items of the same type and can grow or shrink at runtime.
        // This makes it a better choice than an array when you do not know the final size in advance.
        // Common operations are Add, Remove, Count, and iteration.
        // This is useful for carts, user selections, and search results.

        List<string> shoppingCart = new() { "Laptop", "Mouse" };
        shoppingCart.Add("Keyboard");
        shoppingCart.Add("Headset");
        shoppingCart.Remove("Mouse");

        Console.WriteLine("\n01 - List Basics"); // Output: 01 - List Basics
        Console.WriteLine($"Items In Cart: {shoppingCart.Count}"); // Output: Items In Cart: 3
        Console.WriteLine($"First Item: {shoppingCart[0]}"); // Output: First Item: Laptop

        for (int index = 0; index < shoppingCart.Count; index++)
        {
            Console.WriteLine($"Cart Item {index}: {shoppingCart[index]}"); // Output: Cart Item 0: Laptop ... Cart Item 2: Headset
        }

        // Mistake:
        // Beginners sometimes use arrays for dynamic data and then struggle when the size changes.
        // List<T> handles resizing automatically, so it is better for changing collections.

        // 🌍 Real-World Analogy:
        // Think of a List like a shopping cart in an e-commerce app.
        // You can keep adding or removing items until checkout.
    }
    #endregion

    #region 02 - Important List Methods
    private static void ShowImportantMethods()
    {
        // These are the methods most developers use regularly in business applications.
        // Insert adds an item at a specific position, Contains checks existence, and IndexOf gives position.
        // Find is useful when you need the first matching item from a condition.
        // Sort arranges items in place, so it changes the original list order.

        List<int> orderAmounts = new() { 2500, 1200, 4800 };
        orderAmounts.Insert(1, 3000);
        bool hasLargeOrder = orderAmounts.Contains(4800);
        int amountIndex = orderAmounts.IndexOf(3000);
        int firstHighValueOrder = orderAmounts.Find(amount => amount > 2500);
        orderAmounts.Sort();

        Console.WriteLine("\n02 - Important List Methods"); // Output: 02 - Important List Methods
        Console.WriteLine($"Contains 4800: {hasLargeOrder}"); // Output: Contains 4800: True
        Console.WriteLine($"Index Of 3000: {amountIndex}"); // Output: Index Of 3000: 1
        Console.WriteLine($"First High Value Order: {firstHighValueOrder}"); // Output: First High Value Order: 3000
        Console.WriteLine($"Sorted Orders: {string.Join(", ", orderAmounts)}"); // Output: Sorted Orders: 1200, 2500, 3000, 4800

        // Mistake:
        // Sort() changes the same list.
        // If the old order matters, create a copy before sorting.

        // 🌍 Real-World Analogy:
        // Think of these methods like working with an order list in an admin panel.
        // You insert priority orders, search values, and sort for reports.
    }
    #endregion

    #region 03 - Common Properties And Concepts
    private static void ShowPropertiesAndConcepts()
    {
        // Count tells how many items are currently inside the list.
        // Capacity tells how many items the internal storage can hold before resizing happens.
        // AddRange is useful when multiple items must be added together.
        // Clear removes everything from the list.

        List<string> cities = new(capacity: 2) { "Chennai", "Madurai" };
        int initialCapacity = cities.Capacity;
        cities.Add("Coimbatore");
        cities.AddRange(new[] { "Trichy", "Salem" });
        int expandedCapacity = cities.Capacity;
        int currentCount = cities.Count;
        cities.Clear();

        Console.WriteLine("\n03 - Common Properties And Concepts"); // Output: 03 - Common Properties And Concepts
        Console.WriteLine($"Initial Capacity: {initialCapacity}"); // Output: Initial Capacity: 2
        Console.WriteLine($"Expanded Capacity: {expandedCapacity}"); // Output: Expanded Capacity: 8
        Console.WriteLine($"Count Before Clear: {currentCount}"); // Output: Count Before Clear: 5
        Console.WriteLine($"Count After Clear: {cities.Count}"); // Output: Count After Clear: 0

        // Mistake:
        // Count and Capacity are not the same.
        // Count is used items, but Capacity is reserved space.

        // 🌍 Real-World Analogy:
        // Think of Count as passengers currently in a bus.
        // Think of Capacity as total seats available in the bus.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
