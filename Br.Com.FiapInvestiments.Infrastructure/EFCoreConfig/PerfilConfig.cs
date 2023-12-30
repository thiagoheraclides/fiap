using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Br.Com.FiapInvestiments.Infrastructure.EFCoreConfig
{
    internal class PerfilConfig : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("TB_PERFIL_INVESTIDOR");

            builder
                .HasKey(p => p.Id)
                .HasName("PK_PERFIL_INVESTIDOR");

            builder.Property(p => p.Id)
                .HasColumnName("CD_PERFIL_INVESTIDOR")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName("NM_PERFIL_INVESTIDOR")
                .HasMaxLength(20);

            builder.Property(p => p.Descricao)
                .HasColumnName("DS_PERFIL_INVESTIDOR")
                .HasMaxLength(200);

            builder.Property(p => p.Status)
                .HasColumnName("FL_ATIVO")
                .IsRequired();

            builder.Property(p => p.CriadoEm)
                .HasColumnName("DT_REGISTRO")
                .IsRequired();
        }
    }
}
