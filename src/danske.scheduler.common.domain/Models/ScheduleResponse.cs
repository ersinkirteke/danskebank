using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.domain.models
{
    public class ScheduleResponse
    {
        public long CompanyId { get; set; }

        public IReadOnlyCollection<NotificationDto> Notifications { get; set; }
    }
}
