internal static class DictionaryExamples
{
    public static void Run()
    {
        PrintSeparator();
        ShowDictionaryBasics();
        PrintSeparator();
        ShowImportantDictionaryMembers();
    }

    #region 01 - Dictionary Basics
    private static void ShowDictionaryBasics()
    {
        // Dictionary<TKey, TValue> stores data as key-value pairs.
        // It is very fast when you need to find a value by a unique key.
        // Common operations are Add, access by key, and ContainsKey checks.
        // This is useful for contacts, product lookups, and caching.

        Dictionary<string, string> phoneContacts = new()
        {
            { "Anita", "9876543210" },
            { "Rahul", "9123456780" }
        };

        phoneContacts.Add("Deepa", "9000011111");
        string anitaNumber = phoneContacts["Anita"];
        bool hasKiran = phoneContacts.ContainsKey("Kiran");

        Console.WriteLine("\n01 - Dictionary Basics"); // Output: 01 - Dictionary Basics
        Console.WriteLine($"Total Contacts: {phoneContacts.Count}"); // Output: Total Contacts: 3
        Console.WriteLine($"Anita Number: {anitaNumber}"); // Output: Anita Number: 9876543210
        Console.WriteLine($"Contains Kiran: {hasKiran}"); // Output: Contains Kiran: False

        foreach (KeyValuePair<string, string> contact in phoneContacts)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}"); // Output: Anita: 9876543210 ... Deepa: 9000011111
        }

        // Mistake:
        // Accessing phoneContacts["Kiran"] would throw KeyNotFoundException if the key does not exist.
        // Use ContainsKey or TryGetValue before direct access when the key may be missing.

        // 🌍 Real-World Analogy:
        // Think of a Dictionary like phone contacts on a mobile.
        // You search by the person's name and quickly get the number.
    }
    #endregion

    #region 02 - Important Dictionary Members
    private static void ShowImportantDictionaryMembers()
    {
        // TryGetValue is one of the safest and most common methods for real projects.
        // Keys and Values help when you need only one side of the data.
        // The indexer can update an existing value quickly.
        // Remove deletes a key-value pair if the key exists.

        Dictionary<string, decimal> productPrices = new()
        {
            { "Laptop", 65000m },
            { "Mouse", 750m },
            { "Keyboard", 1500m }
        };

        bool foundMouse = productPrices.TryGetValue("Mouse", out decimal mousePrice);
        productPrices["Mouse"] = 799m;
        bool removedKeyboard = productPrices.Remove("Keyboard");

        Console.WriteLine("\n02 - Important Dictionary Members"); // Output: 02 - Important Dictionary Members
        Console.WriteLine($"Found Mouse: {foundMouse}"); // Output: Found Mouse: True
        Console.WriteLine($"Mouse Price Before Update: {mousePrice}"); // Output: Mouse Price Before Update: 750
        Console.WriteLine($"Updated Mouse Price: {productPrices["Mouse"]}"); // Output: Updated Mouse Price: 799
        Console.WriteLine($"Removed Keyboard: {removedKeyboard}"); // Output: Removed Keyboard: True
        Console.WriteLine($"Key Count: {productPrices.Keys.Count}"); // Output: Key Count: 2
        Console.WriteLine($"Value Count: {productPrices.Values.Count}"); // Output: Value Count: 2

        // Mistake:
        // Add() throws an error if the same key already exists.
        // Use the indexer when you want to update a value for an existing key.

        // 🌍 Real-World Analogy:
        // Think of a Dictionary like a product price map in an online store.
        // Product code is the key, and price is the value you update or read quickly.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
