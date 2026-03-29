internal static class RecordBasics
{
    public static void Run()
    {
        ShowRecordDefinition();
        ShowValueEquality();
        ShowPositionalRecords();
    }

    #region 01 - Record Definition
    private static void ShowRecordDefinition()
    {
        // Record is a reference type built for data-focused models.
        // It is usually used for immutable data.
        // Records automatically provide helpful members like value-based equality and ToString().
        // This makes them a strong fit for DTOs and API models.

        CustomerProfile profile = new() { Id = 101, Name = "Asha", City = "Chennai" };

        Console.WriteLine("\n01 - Record Definition"); // Output: 01 - Record Definition
        Console.WriteLine($"Customer Profile: {profile}"); // Output: Customer Profile: CustomerProfile { Id = 101, Name = Asha, City = Chennai }
        Console.WriteLine($"Customer Name: {profile.Name}"); // Output: Customer Name: Asha

        // Mistake:
        // Some developers treat records exactly like normal classes and miss their value-focused benefits.
        // Record is best when the model mainly carries data.

        // 🌍 Real-World Analogy:
        // Think of a record like a printed profile card.
        // Its job is to clearly hold and show data.
    }
    #endregion

    #region 02 - Value Equality
    private static void ShowValueEquality()
    {
        // Regular classes use reference equality by default.
        // Records use value equality by default.
        // That means two records with the same data are considered equal.
        // This is one of the biggest practical differences.

        CustomerProfile firstProfile = new() { Id = 101, Name = "Asha", City = "Chennai" };
        CustomerProfile secondProfile = new() { Id = 101, Name = "Asha", City = "Chennai" };
        bool recordsAreEqual = firstProfile == secondProfile;
        bool sameReference = ReferenceEquals(firstProfile, secondProfile);

        Console.WriteLine("\n02 - Value Equality"); // Output: 02 - Value Equality
        Console.WriteLine($"Records Are Equal: {recordsAreEqual}"); // Output: Records Are Equal: True
        Console.WriteLine($"Same Reference: {sameReference}"); // Output: Same Reference: False

        // Mistake:
        // Expecting reference comparison behavior from a record can lead to wrong assumptions.
        // Records compare data, not object identity, by default.

        // 🌍 Real-World Analogy:
        // Think of two printed invoices with the same fields.
        // They are different papers, but they represent the same data.
    }
    #endregion

    #region 03 - Positional Records
    private static void ShowPositionalRecords()
    {
        // Positional records declare properties directly in the record header.
        // They are short, clean, and common for DTOs and simple response models.
        // They also support deconstruction automatically.
        // ToString() output is generated automatically.

        ProductDto product = new(501, "Laptop", 64999m);

        Console.WriteLine("\n03 - Positional Records"); // Output: 03 - Positional Records
        Console.WriteLine($"Product Record: {product}"); // Output: Product Record: ProductDto { Id = 501, Name = Laptop, Price = 64999 }
        Console.WriteLine($"Product Name: {product.Name}"); // Output: Product Name: Laptop

        // Mistake:
        // Some teams still write long boilerplate classes for simple data transfer models.
        // Positional records often make that code much cleaner.

        // 🌍 Real-World Analogy:
        // Think of a positional record like a ready-made shipping label template.
        // You fill the key fields in one quick line.
    }
    #endregion

    private sealed record CustomerProfile
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string City { get; init; } = string.Empty;
    }

    private sealed record ProductDto(int Id, string Name, decimal Price);
}
