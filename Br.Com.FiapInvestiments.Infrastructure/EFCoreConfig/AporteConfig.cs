using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Br.Com.FiapInvestiments.Infrastructure.EFCoreConfig
{
    internal class AporteConfig : IEntityTypeConfiguration<Aporte>
    {
        public void Configure(EntityTypeBuilder<Aporte> builder)
        {
            builder.ToTable("TB_APORTE_CONTA");

            builder
                .HasKey(p => p.Id)
                .HasName("PK_APORTE_CONTA");

            builder.Property(p => p.Id)
                .HasColumnName("CD_APORTE_CONTA")
                .HasColumnType("BIGINT")
                .UseIdentityAlwaysColumn()
                .IsRequired();

            builder.Property(p => p.UsuarioId)
                 .HasColumnName("CD_USUARIO_INVESTIDOR")
                 .IsRequired();

            builder.Property(p => p.CriadoEm)
                .HasColumnName("DT_APORTE_CONTA")
                .IsRequired();

            builder.Property(p => p.Valor)
                .HasColumnName("VL_APORTE_CONTA")
                .IsRequired();

            builder.Property(p => p.Observacao)
                .HasColumnName("DS_OBSERVACAO")
                .HasMaxLength(500);

            builder
                .HasOne(p => p.Usuario)
                .WithMany(p => p.Aportes)
                .HasConstraintName("FK_USUARIO_APORTE_CONTA")
                .HasForeignKey(p => p.UsuarioId)
                .IsRequired();

            builder
                .HasIndex(p => p.UsuarioId)
                .HasDatabaseName("IDX_USUARIO_APORTE_CONTA");
        }
    }
}
