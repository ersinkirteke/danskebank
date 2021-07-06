using danske.scheduler.common.infrastructure.context;
using danske.scheduler.common.infrastructure.repositories;
using danske.scheduler.common.infrastructure.specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure.repositories
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public EFRepository(DanskeContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");

            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public IReadOnlyCollection<T> Get(ISpecification<T> spec)
        {
            var queryableResultWithIncludes = spec.Includes
               .Aggregate(_dbContext.Set<T>().AsQueryable(),
                   (current, include) => current.Include(include));

            // modify the IQueryable to include any string-based include statements
            var secondaryResult = spec.IncludeStrings
                .Aggregate(queryableResultWithIncludes,
                    (current, include) => current.Include(include));

            // return the result of the query using the specification's criteria expression
            return secondaryResult
                            .Where(spec.Criteria)
                            .ToList().AsReadOnly();
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return _dbSet.ToList().AsReadOnly();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            T existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
