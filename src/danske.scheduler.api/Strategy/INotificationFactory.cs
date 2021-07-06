namespace danske.scheduler.api.strategy
{
    public interface INotificationFactory
    {
        NotificationOperation CreateNotificationOperation(string strategy);
    }
}
