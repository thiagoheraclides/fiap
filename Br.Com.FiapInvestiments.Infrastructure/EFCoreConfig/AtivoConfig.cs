using Br.Com.FiapInvestiments.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Br.Com.FiapInvestiments.Infrastructure.EFCoreConfig
{
    internal class AtivoConfig : IEntityTypeConfiguration<Ativo>
    {
        public void Configure(EntityTypeBuilder<Ativo> builder)
        {
            builder.ToTable("TB_ATIVO_INVESTIMENTO");

            builder
                .HasKey(p => p.Id)
                .HasName("PK_ATIVO_INVESTIMENTO");

            builder.Property(p => p.Id)
                .HasColumnName("CD_ATIVO_INVESTIMENTO")
                .HasColumnType("INTEGER")
                .UseIdentityAlwaysColumn()
                .IsRequired();

            builder.Property(p => p.Sigla)
                .HasColumnName("SG_ATIVO_INVESTIMENTO")
                .HasMaxLength(5)
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasColumnName("NM_ATIVO_INVESTIMENTO")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.CriadoEm)
                .HasColumnName("DT_REGISTRO")
                .IsRequired();

            builder.Property(p => p.EncerraEm)
                .HasColumnName("DT_ENCERRAMENTO_ATIVO");

            builder.Property(p => p.RentabilidadeEmDias)
                .HasColumnName("NR_TEMPO_DIAS_RENTABILIDADE")
                .IsRequired();

            builder.Property(p => p.ValorRentabilidade)
                .HasColumnName("VL_RENTABILIDADE")
                .IsRequired();

            builder.Property(p => p.EscalaDeRisco)
                .HasColumnName("NR_ESCALA_RISCO")
                .IsRequired();

        }
    }
}
