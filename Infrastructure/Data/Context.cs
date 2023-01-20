using Domain.Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions contextOptions) : base(contextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        public async Task CommitAsync()
        {
            await SaveChangesAsync().ConfigureAwait(false);
        }
        public DbSet<Product> Products { get; set; }

    }
}
