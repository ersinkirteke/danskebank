using danske.scheduler.common.domain.entities;
using danske.scheduler.common.domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace danske.scheduler.api.strategy
{
    public class DenmarkStrategy : INotificationStrategy
    {
        private readonly int[] days = { 1, 5, 10, 15, 20 };

        public IReadOnlyCollection<Notification> CreateNotifications(CompanyType companyType)
        {
            DateTime date = DateTime.Now;

            return new List<Notification>()
            {
                new Notification(){ SendDate = date.AddDays(days[0])},
                new Notification(){ SendDate = date.AddDays(days[1])},
                new Notification(){ SendDate = date.AddDays(days[2])},
                new Notification(){ SendDate = date.AddDays(days[3])},
                new Notification(){ SendDate = date.AddDays(days[4])}

            }.AsReadOnly();
        }
    }
}
