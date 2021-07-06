using System;

namespace danske.scheduler.common.domain.entities
{
    public interface IEntity
    {
        long Id { get; set; }
        DateTimeOffset TimeStamp { get; set; }
    }
}
