using danske.scheduler.common.domain.entities;
using danske.scheduler.common.infrastructure.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure.repositories
{
    public class NotificationRepository : EFRepository<Notification>
    {
        public NotificationRepository(DanskeContext dbContext) : base(dbContext)
        {

        }
    }
}
