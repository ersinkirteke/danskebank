using danske.scheduler.common.domain.models;
using System.Collections.Generic;

namespace danske.scheduler.api.services
{
    public interface IScheduleService
    {
        ScheduleResponse CreateNotifications(ScheduleRequest schedule);
    }
}
