using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Br.Com.FiapInvestiments.Infrastructure.EFCoreConfig
{
    internal class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("TB_PEDIDO");

            builder
                .HasKey(p => p.Id)
                .HasName("PK_PEDIDO");

            builder.Property(p => p.Id)
                .HasColumnName("CD_PEDIDO")
                .HasColumnType("BIGINT")
                .UseIdentityAlwaysColumn()
                .IsRequired();

            builder.Property(p => p.CriadoEm)
                .HasColumnName("DT_PEDIDO")                
                .IsRequired();

            builder.Property(p => p.AtivoId)
                .HasColumnName("CD_ATIVO_INVESTIMENTO")
                .IsRequired();

            builder.Property(p => p.UsuarioId)
                .HasColumnName("CD_USUARIO_INVESTIDOR")
                .IsRequired();

            builder.Property(p => p.Quantidade)
                .HasColumnName("QT_PEDIDO")
                .IsRequired();

            builder.Property(p => p.Valor)
                .HasColumnName("VL_PEDIDO")
                .IsRequired();

            builder.Property(p => p.OrdemDeCompra)
                .HasColumnName("FL_ORDEM_COMPRA")
                .IsRequired();

            builder.Property(p => p.Observacao)
                .HasColumnName("DS_OBSERVACAO")
                .HasMaxLength(500);

            builder
                .HasOne(p => p.Usuario)
                .WithMany(p => p.Pedidos)
                .HasConstraintName("FK_USUARIO_PEDIDO")
                .HasForeignKey(p => p.UsuarioId)
                .IsRequired();

            builder
                .HasOne(p => p.Ativo)
                .WithMany(p => p.Pedidos)
                .HasConstraintName("FK_ATIVO_PEDIDO")
                .HasForeignKey(p => p.AtivoId)
                .IsRequired();

            builder
                .HasIndex(p => p.UsuarioId)
                .HasDatabaseName("IDX_USUARIO_PEDIDO");

            builder
                .HasIndex(p => p.AtivoId)
                .HasDatabaseName("IDX_ATIVO_PEDIDO");

        }
    }
}
