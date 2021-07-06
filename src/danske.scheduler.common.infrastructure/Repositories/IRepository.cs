using danske.scheduler.common.infrastructure.specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure.repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IReadOnlyCollection<TEntity> GetAll();
        IReadOnlyCollection<TEntity> Get(ISpecification<TEntity> spec);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(int id);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
