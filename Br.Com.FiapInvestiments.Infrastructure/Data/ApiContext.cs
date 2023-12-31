using Br.Com.FiapInvestiments.Domain.Entidades;
using Br.Com.FiapInvestiments.Infrastructure.EFCoreConfig;
using Microsoft.EntityFrameworkCore;

namespace Br.Com.FiapInvestiments.Infrastructure.Data
{
    public class ApiContext(DbContextOptions<ApiContext> options) : DbContext(options)
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoUsuarioConfig());
            modelBuilder.ApplyConfiguration(new PerfilConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new AtivoConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new AporteConfig());
            modelBuilder.ApplyConfiguration(new RecomendacaoConfig());            
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
