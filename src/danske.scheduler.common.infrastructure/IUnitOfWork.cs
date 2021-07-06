using danske.scheduler.common.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        void Commit();
        void Rollback();
    }
}
