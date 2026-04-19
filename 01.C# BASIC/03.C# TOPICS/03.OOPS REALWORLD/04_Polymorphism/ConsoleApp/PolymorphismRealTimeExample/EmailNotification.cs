namespace PolymorphismRealTimeExample;

public class EmailNotification : NotificationChannel
{
    public override void Send(string message)
    {
        Console.WriteLine($"Email notification sent: {message}");
    }
}
