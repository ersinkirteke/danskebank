using System;

namespace danske.scheduler.api.strategy
{
    public class NotificationFactory : INotificationFactory
    {

        public NotificationOperation CreateNotificationOperation(string strategy)
        {
            if (strategy == "DK")
                return new NotificationOperation(new DenmarkStrategy());
            else if (strategy == "FI")
                return new NotificationOperation(new FinlandStrategy());
            else if (strategy == "NO")
                return new NotificationOperation(new NorwayStrategy());
            else if (strategy == "SE")
                return new NotificationOperation(new SwedenStrategy());

            throw new ArgumentException("market is invalid");
        }
    }
}
