using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Infrastructure.Data
{
    public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseInMemoryDatabase("InMemoryDb");
        //    string connectionString = _configuration["ConnectionString:PostgreSql"] 
        //        ?? throw new ArgumentNullException("ConnectionString:PostgreSql");

        //    optionsBuilder.UseNpgsql(connectionString);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoUsuario>()
                .HasKey(tp => tp.Id);

            modelBuilder.Entity<TipoUsuario>()
                .Property(tp => tp.Nome);
                
    

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
