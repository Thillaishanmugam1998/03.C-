namespace PolymorphismRealTimeExample;

public class SmsNotification : NotificationChannel
{
    public override void Send(string message)
    {
        Console.WriteLine($"SMS notification sent: {message}");
    }
}
