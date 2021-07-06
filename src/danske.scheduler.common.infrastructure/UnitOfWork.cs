using danske.scheduler.common.domain.entities;
using danske.scheduler.common.infrastructure.context;
using danske.scheduler.common.infrastructure.repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DanskeContext _context;
        //public UnitOfWork(DbContextOptions<DanskeContext> options) : this(new DanskeContext(options)) { }
        public UnitOfWork(DanskeContext context)
        {
            _context = context;
        }
        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EFRepository<T>(_context);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            _context
                .ChangeTracker
                .Entries()
                .ToList()
                .ForEach(x => x.Reload());
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
