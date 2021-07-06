using danske.scheduler.common.domain.entities;
using danske.scheduler.common.domain.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace danske.scheduler.api.strategy
{
    public class SwedenStrategy : INotificationStrategy
    {
        private readonly int[] days = { 1, 7, 14, 28 };

        public IReadOnlyCollection<Notification> CreateNotifications(CompanyType companyType)
        {
            if (companyType == CompanyType.Small || companyType == CompanyType.Medium)
            {
                DateTime date = DateTime.Now;

                return new List<Notification>()
                    {
                        new Notification(){ SendDate= date.AddDays(days[0])},
                        new Notification(){ SendDate= date.AddDays(days[1])},
                        new Notification(){ SendDate= date.AddDays(days[2])},
                        new Notification(){ SendDate= date.AddDays(days[3])}

                    }.AsReadOnly();
            }

            return new List<Notification>().AsReadOnly();
        }
    }
}
