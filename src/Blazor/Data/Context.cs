using Blazor.Client.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Client.Data
{
    public class Context : DbContext
    {        
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("BlazorDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Id);

        }
    }
}
