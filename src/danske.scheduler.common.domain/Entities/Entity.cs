using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace danske.scheduler.common.domain.entities
{
    public class Entity : IEntity
    {
        public long Id { get; set; }
        public DateTimeOffset TimeStamp
        {
            get => this.timestamp.HasValue
                    ? this.timestamp.Value
                    : DateTimeOffset.Now;


            set => this.timestamp = value;
        }

        [NotMapped]
        private DateTimeOffset? timestamp = null;
    }
}
