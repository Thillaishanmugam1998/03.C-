namespace AbstractionRealTimeExample;

public class CheckoutService
{
    public void CompleteOrder(PaymentMethod paymentMethod, decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Order failed: amount must be greater than zero.");
            return;
        }

        Console.WriteLine("Starting checkout...");
        paymentMethod.ProcessPayment(amount);
        Console.WriteLine("Order completed successfully.");
    }
}
