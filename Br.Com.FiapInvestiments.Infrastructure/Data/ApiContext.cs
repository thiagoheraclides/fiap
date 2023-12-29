using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Infrastructure.Data
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<TipoUsuario> TiposUsuario { get; set; }

        public DbSet<Perfil> Perfis { get; set; }

        public DbSet<Ativo> Ativos { get; set; }

        public DbSet<Aporte> Aportes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Recomendacao> Recomendacoes { get; set; }

    }
}
