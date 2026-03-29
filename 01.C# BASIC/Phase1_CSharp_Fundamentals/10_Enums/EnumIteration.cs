internal static class EnumIteration
{
    public static void Run()
    {
        ShowEnumGetValues();
        ShowEnumGetNames();
    }

    #region 01 - Enum.GetValues
    private static void ShowEnumGetValues()
    {
        // Enum.GetValues returns all values defined in an enum.
        // This is useful for dropdowns, reports, filters, and validation lists.
        // It helps avoid hardcoding values in multiple places.
        // This is a common pattern in admin screens and APIs.

        ShippingMode[] shippingModes = Enum.GetValues<ShippingMode>();

        Console.WriteLine("\n01 - Enum.GetValues"); // Output: 01 - Enum.GetValues
        Console.WriteLine($"Shipping Mode Count: {shippingModes.Length}"); // Output: Shipping Mode Count: 4

        foreach (ShippingMode shippingMode in shippingModes)
        {
            Console.WriteLine($"{shippingMode} = {(int)shippingMode}"); // Output: Standard = 0 ... SameDay = 3
        }

        // Mistake:
        // Hardcoding enum values in many places makes maintenance harder.
        // Use Enum.GetValues when you need the full list.

        // 🌍 Real-World Analogy:
        // Think of Enum.GetValues like asking for the full menu from a restaurant.
        // You get every available option in one place.
    }
    #endregion

    #region 02 - Enum.GetNames
    private static void ShowEnumGetNames()
    {
        // Enum.GetNames returns the names of the enum members as strings.
        // This is helpful for dropdown labels, logs, reports, and documentation screens.
        // Enum.ToString() is also used often when you need the name of one enum value.
        // These methods make enum display cleaner.

        string[] shippingModeNames = Enum.GetNames<ShippingMode>();
        ShippingMode expressMode = ShippingMode.Express;
        string expressModeText = expressMode.ToString();

        Console.WriteLine("\n02 - Enum.GetNames"); // Output: 02 - Enum.GetNames
        Console.WriteLine($"Express Mode Text: {expressModeText}"); // Output: Express Mode Text: Express
        Console.WriteLine($"Shipping Mode Names Count: {shippingModeNames.Length}"); // Output: Shipping Mode Names Count: 4

        foreach (string shippingModeName in shippingModeNames)
        {
            Console.WriteLine($"Shipping Mode Name: {shippingModeName}"); // Output: Shipping Mode Name: Standard ... Shipping Mode Name: SameDay
        }

        // Mistake:
        // Some developers manually type enum names in UI code.
        // That creates mismatch risk if the enum is renamed later.

        // 🌍 Real-World Analogy:
        // Think of Enum.GetNames like reading the labels printed on a control panel.
        // You get the display names directly from the source.
    }
    #endregion

    private enum ShippingMode
    {
        Standard = 0,
        Express = 1,
        Overnight = 2,
        SameDay = 3
    }
}
