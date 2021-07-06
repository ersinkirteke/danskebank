using danske.scheduler.common.domain.enums;
using System;

namespace danske.scheduler.common.domain.models
{
    /// <summary>
    /// Company Dto
    /// </summary>
    public class CompanyDto
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public CompanyType Type { get; set; }
        public string Market { get; set; }
    }
}
