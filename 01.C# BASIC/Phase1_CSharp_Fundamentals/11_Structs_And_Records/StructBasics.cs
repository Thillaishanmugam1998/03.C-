internal static class StructBasics
{
    public static void Run()
    {
        ShowStructDefinition();
        ShowDefaultBehavior();
        ShowReadonlyStruct();
    }

    #region 01 - Struct Definition
    private static void ShowStructDefinition()
    {
        // A struct is a value type.
        // It is a good fit for small data that represents one value or one small concept.
        // Structs are commonly used for coordinates, ranges, money values, and lightweight models.
        // Keep structs small and prefer immutability for safer behavior.

        ScreenPoint startPoint = new(10, 20);
        ScreenPoint copiedPoint = startPoint;
        copiedPoint.X = 50;

        Console.WriteLine("\n01 - Struct Definition"); // Output: 01 - Struct Definition
        Console.WriteLine($"Original Point: {startPoint}"); // Output: Original Point: X: 10, Y: 20
        Console.WriteLine($"Copied Point: {copiedPoint}"); // Output: Copied Point: X: 50, Y: 20

        // Mistake:
        // Making large mutable structs can hurt performance because values are copied.
        // Use struct for small, lightweight data.

        // 🌍 Real-World Analogy:
        // Think of a struct like a small printed token card.
        // When you copy it, you get a separate card, not a shared one.
    }
    #endregion

    #region 02 - Default Behavior
    private static void ShowDefaultBehavior()
    {
        // A struct always has a default value, even without custom initialization.
        // Numeric fields become 0, bool becomes false, and reference fields become null.
        // Parameterless construction also gives default values.
        // This behavior matters when structs are created in arrays or as fields.

        Measurement defaultMeasurement = default;
        Measurement constructedMeasurement = new();

        Console.WriteLine("\n02 - Default Behavior"); // Output: 02 - Default Behavior
        Console.WriteLine($"Default Width: {defaultMeasurement.Width}"); // Output: Default Width: 0
        Console.WriteLine($"Default Height: {defaultMeasurement.Height}"); // Output: Default Height: 0
        Console.WriteLine($"Constructed Width: {constructedMeasurement.Width}"); // Output: Constructed Width: 0
        Console.WriteLine($"Constructed Height: {constructedMeasurement.Height}"); // Output: Constructed Height: 0

        // Mistake:
        // Some beginners expect new StructName() to run custom logic like a class constructor by default.
        // For structs, parameterless creation gives the default field values unless explicitly defined.

        // 🌍 Real-World Analogy:
        // Think of a default struct like a blank form.
        // Every box starts empty or zero until you fill it.
    }
    #endregion

    #region 03 - readonly struct
    private static void ShowReadonlyStruct()
    {
        // readonly struct is used when the whole struct should stay immutable.
        // This can improve safety and reduce defensive copies in some scenarios.
        // It is a strong fit for value objects such as coordinates, date ranges, and money values.
        // Immutability makes code easier to reason about.

        CurrencyAmount price = new(999.50m, "INR");

        Console.WriteLine("\n03 - readonly struct"); // Output: 03 - readonly struct
        Console.WriteLine($"Currency Amount: {price}"); // Output: Currency Amount: 999.50 INR
        Console.WriteLine($"Currency Code: {price.CurrencyCode}"); // Output: Currency Code: INR

        // Mistake:
        // A mutable struct can surprise you because copied values change independently.
        // readonly struct is usually safer when the value should never change after creation.

        // 🌍 Real-World Analogy:
        // Think of a readonly struct like a sealed bill.
        // Once printed, its amount and currency should not change.
    }
    #endregion

    private struct ScreenPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ScreenPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }

    private struct Measurement
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    private readonly struct CurrencyAmount
    {
        public decimal Amount { get; }
        public string CurrencyCode { get; }

        public CurrencyAmount(decimal amount, string currencyCode)
        {
            Amount = amount;
            CurrencyCode = currencyCode;
        }

        public override string ToString()
        {
            return $"{Amount:0.00} {CurrencyCode}";
        }
    }
}
