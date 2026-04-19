namespace PolymorphismRealTimeExample;

public class PushNotification : NotificationChannel
{
    public override void Send(string message)
    {
        Console.WriteLine($"Push notification sent: {message}");
    }
}
