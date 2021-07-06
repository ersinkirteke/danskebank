using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.domain.entities
{
    public class Notification : Entity
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:DD/MM/YYYY}")]
        public DateTime SendDate { get; set; }

        public long CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
