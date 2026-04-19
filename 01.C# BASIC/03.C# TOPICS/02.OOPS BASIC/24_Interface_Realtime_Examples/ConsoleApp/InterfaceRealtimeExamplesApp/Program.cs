namespace InterfaceRealtimeExamplesApp;

internal class Program
{
    private static void Main()
    {
        #region Explanation
        // Interfaces are used in real applications to switch between implementations easily.
        // Here, different payment methods follow the same payment contract.
        #endregion

        #region Example
        IPaymentGateway cardPayment = new CardPaymentGateway();
        IPaymentGateway upiPayment = new UpiPaymentGateway();

        cardPayment.Pay(1250m);
        upiPayment.Pay(780m);
        #endregion

        #region Output
        Console.WriteLine();
        Console.WriteLine("Expected learning outcome:");
        Console.WriteLine("1. One interface can support multiple real-world implementations.");
        Console.WriteLine("2. Calling code stays simple and flexible.");
        #endregion
    }
}

internal interface IPaymentGateway
{
    void Pay(decimal amount);
}

internal sealed class CardPaymentGateway : IPaymentGateway
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Card payment of {amount:C} completed.");
    }
}

internal sealed class UpiPaymentGateway : IPaymentGateway
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"UPI payment of {amount:C} completed.");
    }
}
