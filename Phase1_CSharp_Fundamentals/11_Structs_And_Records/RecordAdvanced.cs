internal static class RecordAdvanced
{
    public static void Run()
    {
        ShowInitOnlyProperties();
        ShowWithExpression();
        ShowDeconstruction();
        ShowRecordStruct();
    }

    #region 01 - init-only Properties
    private static void ShowInitOnlyProperties()
    {
        // init allows assignment only during object creation.
        // set allows assignment at any time after creation.
        // init is helpful for immutable models.
        // This is common in records and configuration models.

        AppConfig initConfig = new() { Environment = "Production", Region = "South India" };
        MutableConfig mutableConfig = new() { Environment = "Development" };
        mutableConfig.Environment = "Testing";

        Console.WriteLine("\n01 - init-only Properties"); // Output: 01 - init-only Properties
        Console.WriteLine($"Init Config Environment: {initConfig.Environment}"); // Output: Init Config Environment: Production
        Console.WriteLine($"Mutable Config Environment: {mutableConfig.Environment}"); // Output: Mutable Config Environment: Testing

        // Mistake:
        // Using set everywhere can make data change unexpectedly after creation.
        // Use init when the object should stay stable after it is created.

        // 🌍 Real-World Analogy:
        // Think of init like setting details on a printed ID card before lamination.
        // After that, the data should not change.
    }
    #endregion

    #region 02 - with Expression
    private static void ShowWithExpression()
    {
        // with creates a copy of a record and changes selected properties.
        // This is great for immutable update patterns.
        // The copy is shallow, not deep.
        // If a nested reference object is shared, both records still point to the same nested object.

        OrderSnapshot originalOrder = new(1001, "Pending", new AddressInfo("Chennai"));
        OrderSnapshot updatedOrder = originalOrder with { Status = "Completed" };
        AddressInfo sharedAddress = originalOrder.DeliveryAddress;
        bool sameNestedReference = ReferenceEquals(originalOrder.DeliveryAddress, updatedOrder.DeliveryAddress);

        Console.WriteLine("\n02 - with Expression"); // Output: 02 - with Expression
        Console.WriteLine($"Original Order Status: {originalOrder.Status}"); // Output: Original Order Status: Pending
        Console.WriteLine($"Updated Order Status: {updatedOrder.Status}"); // Output: Updated Order Status: Completed
        Console.WriteLine($"Same Nested Address Reference: {sameNestedReference}"); // Output: Same Nested Address Reference: True
        Console.WriteLine($"Shared Address City: {sharedAddress.City}"); // Output: Shared Address City: Chennai

        // Mistake:
        // Some developers think with always creates a full deep copy.
        // It copies the top-level record, but nested reference objects are still shared unless you copy them too.

        // 🌍 Real-World Analogy:
        // Think of with like copying a form and changing one field.
        // The attached supporting document can still be the same shared document.
    }
    #endregion

    #region 03 - Deconstruction
    private static void ShowDeconstruction()
    {
        // Deconstruction extracts record values into separate variables.
        // This is very clean for quick reads and simple transformations.
        // Positional records support this naturally.
        // It is often used in mapping and response handling.

        EmployeeDto employee = new(301, "Kavin", "Developer");
        var (employeeId, employeeName, employeeRole) = employee;

        Console.WriteLine("\n03 - Deconstruction"); // Output: 03 - Deconstruction
        Console.WriteLine($"Employee Id: {employeeId}"); // Output: Employee Id: 301
        Console.WriteLine($"Employee Name: {employeeName}"); // Output: Employee Name: Kavin
        Console.WriteLine($"Employee Role: {employeeRole}"); // Output: Employee Role: Developer

        // Mistake:
        // Beginners sometimes avoid deconstruction and manually read every property even for short cases.
        // Deconstruction keeps simple data extraction neat.

        // 🌍 Real-World Analogy:
        // Think of deconstruction like unpacking items from a labeled delivery box.
        // Each item is taken out directly into its own place.
    }
    #endregion

    #region 04 - record struct
    private static void ShowRecordStruct()
    {
        // record struct combines value-type behavior with record-style benefits.
        // It is useful when you want lightweight value semantics and readable data modeling.
        // Equality is based on values, but the type is still a struct.
        // This can fit coordinates, ranges, and compact value objects.

        Coordinates firstCoordinates = new(12, 15);
        Coordinates secondCoordinates = new(12, 15);
        bool coordinatesEqual = firstCoordinates == secondCoordinates;

        Console.WriteLine("\n04 - record struct"); // Output: 04 - record struct
        Console.WriteLine($"First Coordinates: {firstCoordinates}"); // Output: First Coordinates: Coordinates { X = 12, Y = 15 }
        Console.WriteLine($"Second Coordinates: {secondCoordinates}"); // Output: Second Coordinates: Coordinates { X = 12, Y = 15 }
        Console.WriteLine($"Coordinates Equal: {coordinatesEqual}"); // Output: Coordinates Equal: True

        // Mistake:
        // Using a class for tiny value-focused data can add unnecessary reference semantics.
        // record struct can be a better fit for compact value objects.

        // 🌍 Real-World Analogy:
        // Think of a record struct like a small GPS coordinate label.
        // It is lightweight, but still compares by its actual values.
    }
    #endregion

    private sealed record AppConfig
    {
        public string Environment { get; init; } = string.Empty;
        public string Region { get; init; } = string.Empty;
    }

    private sealed class MutableConfig
    {
        public string Environment { get; set; } = string.Empty;
    }

    private sealed record OrderSnapshot(int Id, string Status, AddressInfo DeliveryAddress);

    private sealed class AddressInfo
    {
        public string City { get; }

        public AddressInfo(string city)
        {
            City = city;
        }
    }

    private sealed record EmployeeDto(int Id, string Name, string Role);

    private readonly record struct Coordinates(int X, int Y);
}
