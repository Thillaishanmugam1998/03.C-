namespace AbstractionApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Abstraction exposes only the important operation.
        // The user knows what happens, not every internal implementation detail.
        #endregion

        #region Example
        Payment payment = new CreditCardPayment();
        payment.ProcessPayment(1500m);
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. The base abstraction defines what action is available.");
        Console.WriteLine("2. The concrete class handles how the action is performed.");
        #endregion
    }
}

internal abstract class Payment
{
    public abstract void ProcessPayment(decimal amount);
}

internal class CreditCardPayment : Payment
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Credit card payment of {amount:C} processed securely.");
    }
}
