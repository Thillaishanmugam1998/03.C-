namespace PolymorphismRealTimeExample;

public class PolymorphismExample
{
    public void Run()
    {
        #region Explanation
        Console.WriteLine("POLYMORPHISM - REAL-TIME EXAMPLE");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Polymorphism means one common reference can behave in different ways based on the actual object it points to.");
        Console.WriteLine("In this example, different notification channels respond differently to the same send request.");
        Console.WriteLine();
        #endregion

        #region RealWorldExample
        Console.WriteLine("Real-World Analogy:");
        Console.WriteLine("An e-commerce system can notify customers by email, SMS, or push notification.");
        Console.WriteLine("The system performs one action: send notification.");
        Console.WriteLine("But the actual behavior changes depending on which notification channel is used.");
        Console.WriteLine();
        #endregion

        #region CodeExample
        var service = new NotificationService();

        NotificationChannel email = new EmailNotification();
        NotificationChannel sms = new SmsNotification();
        NotificationChannel push = new PushNotification();

        service.SendNotification(email, "Your order has been shipped.");
        service.SendNotification(sms, "OTP: 482913");
        service.SendNotification(push, "Flash sale starts in 10 minutes.");
        Console.WriteLine();
        #endregion

        #region Output
        Console.WriteLine("Key Learning:");
        Console.WriteLine("The same method call works with different object types.");
        Console.WriteLine("The runtime decides which overridden method should be executed.");
        #endregion
    }
}
