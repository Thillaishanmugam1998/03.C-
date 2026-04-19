namespace AbstractionRealTimeExample;

public class UpiPayment : PaymentMethod
{
    private readonly string _upiId;

    public UpiPayment(string upiId)
        : base("UPI")
    {
        _upiId = upiId;
    }

    public override void ProcessPayment(decimal amount)
    {
        PrintReceiptHeader(amount);
        Console.WriteLine("Sending payment request to UPI app...");
        Console.WriteLine($"UPI ID used   : {_upiId}");
        Console.WriteLine("Payment completed through UPI.");
    }
}
