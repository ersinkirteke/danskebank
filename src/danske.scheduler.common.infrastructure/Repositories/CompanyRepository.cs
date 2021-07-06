using danske.scheduler.common.domain.entities;
using danske.scheduler.common.infrastructure.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure.repositories
{
    public class CompanyRepository : EFRepository<Company>
    {
        public CompanyRepository(DanskeContext dbContext) : base(dbContext)
        {

        }
    }
}
