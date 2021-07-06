using danske.scheduler.common.domain.entities;
using danske.scheduler.common.domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace danske.scheduler.api.strategy
{
    public interface INotificationStrategy
    {
        IReadOnlyCollection<Notification> CreateNotifications(CompanyType companyType);
    }
}
