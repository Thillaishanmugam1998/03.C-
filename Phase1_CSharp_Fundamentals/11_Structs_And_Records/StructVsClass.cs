internal static class StructVsClass
{
    public static void Run()
    {
        ShowValueVsReferenceType();
        ShowBoxingAndUnboxing();
    }

    #region 01 - Value vs Reference Type
    private static void ShowValueVsReferenceType()
    {
        // Struct is a value type and class is a reference type.
        // Copying a struct creates a new separate value.
        // Copying a class variable copies the reference, so both variables point to the same object.
        // This difference is one of the most important interview topics.

        ProductStockStruct stockStructOne = new(10);
        ProductStockStruct stockStructTwo = stockStructOne;
        stockStructTwo.Quantity = 25;

        ProductStockClass stockClassOne = new(10);
        ProductStockClass stockClassTwo = stockClassOne;
        stockClassTwo.Quantity = 25;

        Console.WriteLine("\n01 - Value vs Reference Type"); // Output: 01 - Value vs Reference Type
        Console.WriteLine($"Struct Original Quantity: {stockStructOne.Quantity}"); // Output: Struct Original Quantity: 10
        Console.WriteLine($"Struct Copied Quantity: {stockStructTwo.Quantity}"); // Output: Struct Copied Quantity: 25
        Console.WriteLine($"Class Original Quantity: {stockClassOne.Quantity}"); // Output: Class Original Quantity: 25
        Console.WriteLine($"Class Copied Quantity: {stockClassTwo.Quantity}"); // Output: Class Copied Quantity: 25

        // Mistake:
        // Treating a struct like a class can cause confusion because copies behave differently.
        // Always ask whether you want copied values or shared references.

        // 🌍 Real-World Analogy:
        // Think of a struct like a photocopy of a bill and a class like a shared online document.
        // The photocopy is separate, but the shared document is the same file for both users.
    }
    #endregion

    #region 02 - Boxing / Unboxing
    private static void ShowBoxingAndUnboxing()
    {
        // Boxing converts a value type into object or an interface reference.
        // Unboxing converts it back to the original value type.
        // Boxing creates extra work and should be avoided in performance-sensitive code.
        // This often happens when structs are stored as object.

        ProductStockStruct boxedStockSource = new(40);
        object boxedStock = boxedStockSource;
        ProductStockStruct unboxedStock = (ProductStockStruct)boxedStock;
        unboxedStock.Quantity = 60;

        Console.WriteLine("\n02 - Boxing / Unboxing"); // Output: 02 - Boxing / Unboxing
        Console.WriteLine($"Original Struct Quantity: {boxedStockSource.Quantity}"); // Output: Original Struct Quantity: 40
        Console.WriteLine($"Unboxed Struct Quantity: {unboxedStock.Quantity}"); // Output: Unboxed Struct Quantity: 60
        Console.WriteLine($"Boxed Type Name: {boxedStock.GetType().Name}"); // Output: Boxed Type Name: ProductStockStruct

        // Mistake:
        // Repeated boxing and unboxing can reduce performance and create extra allocations.
        // Avoid storing structs as object unless it is truly needed.

        // 🌍 Real-World Analogy:
        // Think of boxing like packing a small item inside a larger shipping box.
        // It works, but it adds extra wrapping and unpacking work.
    }
    #endregion

    private struct ProductStockStruct
    {
        public int Quantity { get; set; }

        public ProductStockStruct(int quantity)
        {
            Quantity = quantity;
        }
    }

    private sealed class ProductStockClass
    {
        public int Quantity { get; set; }

        public ProductStockClass(int quantity)
        {
            Quantity = quantity;
        }
    }
}
