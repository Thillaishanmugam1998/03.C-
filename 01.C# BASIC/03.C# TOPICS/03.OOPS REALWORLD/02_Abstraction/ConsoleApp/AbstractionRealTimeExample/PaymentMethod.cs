namespace AbstractionRealTimeExample;

public abstract class PaymentMethod
{
    public string PaymentLabel { get; }

    protected PaymentMethod(string paymentLabel)
    {
        PaymentLabel = paymentLabel;
    }

    // Abstract members define what every payment method must do,
    // while hiding the internal processing details from the caller.
    public abstract void ProcessPayment(decimal amount);

    public void PrintReceiptHeader(decimal amount)
    {
        Console.WriteLine($"Payment Method: {PaymentLabel}");
        Console.WriteLine($"Amount        : {amount:C}");
    }
}
