using danske.scheduler.common.domain.entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danske.scheduler.common.infrastructure.context
{
    public class DanskeContext : DbContext
    {
        public DanskeContext(DbContextOptions<DanskeContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Notification>()
               .HasOne<Company>(s => s.Company)
               .WithMany(g => g.Notifications)
               .HasForeignKey(f => f.CompanyId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
