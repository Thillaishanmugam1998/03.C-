namespace AbstractionRealTimeExample;

public class AbstractionExample
{
    public void Run()
    {
        #region Explanation
        Console.WriteLine("ABSTRACTION - REAL-TIME EXAMPLE");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Abstraction means showing only the essential features and hiding the internal implementation details.");
        Console.WriteLine("In this example, a checkout system knows how to use a payment method without knowing every internal step of that payment.");
        Console.WriteLine();
        #endregion

        #region RealWorldExample
        Console.WriteLine("Real-World Analogy:");
        Console.WriteLine("When you pay in an online shopping app, you choose Credit Card or UPI.");
        Console.WriteLine("You only click the payment option and confirm the amount.");
        Console.WriteLine("The app hides the complex background steps such as validation, gateway communication, and transaction processing.");
        Console.WriteLine();
        #endregion

        #region CodeExample
        var checkoutService = new CheckoutService();

        PaymentMethod creditCardPayment = new CreditCardPayment("**** **** **** 1234");
        checkoutService.CompleteOrder(creditCardPayment, 2499m);

        Console.WriteLine();

        PaymentMethod upiPayment = new UpiPayment("arun@upi");
        checkoutService.CompleteOrder(upiPayment, 799m);
        Console.WriteLine();
        #endregion

        #region Output
        Console.WriteLine("Key Learning:");
        Console.WriteLine("The checkout service works with the abstraction `PaymentMethod`.");
        Console.WriteLine("It does not need to know the hidden internal steps of each payment type.");
        #endregion
    }
}
