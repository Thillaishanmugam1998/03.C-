namespace AbstractionRealTimeExample;

public class CreditCardPayment : PaymentMethod
{
    private readonly string _maskedCardNumber;

    public CreditCardPayment(string maskedCardNumber)
        : base("Credit Card")
    {
        _maskedCardNumber = maskedCardNumber;
    }

    public override void ProcessPayment(decimal amount)
    {
        PrintReceiptHeader(amount);
        Console.WriteLine("Validating card details...");
        Console.WriteLine($"Charging card {_maskedCardNumber}...");
        Console.WriteLine("Payment completed through credit card gateway.");
    }
}
