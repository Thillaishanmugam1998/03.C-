namespace PolymorphismRealTimeExample;

public class NotificationService
{
    public void SendNotification(NotificationChannel channel, string message)
    {
        channel.Send(message);
    }
}
