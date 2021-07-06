using System;

namespace danske.scheduler.common.domain.entities
{
    public class Entity: IEntity
    {
        public long Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}
