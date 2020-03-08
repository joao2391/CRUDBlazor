using Blazor.Client.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Client.Data
{
    public class Context : DbContext
    {        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<RelatorioVenda> RelatorioVendas { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("BlazorDB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Funcionario>()
                .HasKey(f => f.Id);
            modelBuilder.Entity<Pagamento>()
                .HasKey(p => p.Id);
            modelBuilder.Entity<RelatorioVenda>()
                .HasKey(r => r.Id);
            modelBuilder.Entity<Sessao>()
                .HasKey(s => s.Id);
            modelBuilder.Entity<TipoUsuario>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.Id);

        }
    }
}
