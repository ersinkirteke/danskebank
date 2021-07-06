using danske.scheduler.common.domain.entities;
using danske.scheduler.common.domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace danske.scheduler.api.strategy
{
    public class NotificationOperation
    {
        private INotificationStrategy _notificationStrategy;
        public NotificationOperation(INotificationStrategy notificationStrategy)
        {
            _notificationStrategy = notificationStrategy;
        }

        public IReadOnlyCollection<Notification> CreateNotifications(CompanyType companyType)
        {
           return this._notificationStrategy.CreateNotifications(companyType);
        }
    }
}
