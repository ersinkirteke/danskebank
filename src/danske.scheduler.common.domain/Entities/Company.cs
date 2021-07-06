using danske.scheduler.common.domain.enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace danske.scheduler.common.domain.entities
{
    /// <summary>
    /// Company Entity
    /// </summary>
    public class Company : Entity
    {
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }
        public long Number { get; set; }
        public CompanyType Type { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string Market { get; set; }

        public ICollection<Notification> Notifications { get; set; }

    }
}
