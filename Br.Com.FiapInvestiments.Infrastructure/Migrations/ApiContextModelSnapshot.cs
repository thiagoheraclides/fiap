﻿// <auto-generated />
using System;
using Br.Com.FiapInvestiments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Br.Com.FiapInvestiments.Infrastructure.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Aporte", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("CD_APORTE_CONTA");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_APORTE_CONTA");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("DS_OBSERVACAO");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_USUARIO_INVESTIDOR");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("VL_APORTE_CONTA");

                    b.HasKey("Id")
                        .HasName("PK_APORTE_CONTA");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("IDX_USUARIO_APORTE_CONTA");

                    b.ToTable("TB_APORTE_CONTA", (string)null);
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Ativo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CD_ATIVO_INVESTIMENTO");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_REGISTRO");

                    b.Property<DateTime?>("EncerraEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_ENCERRAMENTO_ATIVO");

                    b.Property<int>("EscalaDeRisco")
                        .HasColumnType("integer")
                        .HasColumnName("NR_ESCALA_RISCO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("NM_ATIVO_INVESTIMENTO");

                    b.Property<long>("RentabilidadeEmDias")
                        .HasColumnType("bigint")
                        .HasColumnName("NR_TEMPO_DIAS_RENTABILIDADE");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)")
                        .HasColumnName("SG_ATIVO_INVESTIMENTO");

                    b.Property<decimal>("ValorRentabilidade")
                        .HasColumnType("numeric")
                        .HasColumnName("VL_RENTABILIDADE");

                    b.HasKey("Id")
                        .HasName("PK_ATIVO_INVESTIMENTO");

                    b.ToTable("TB_ATIVO_INVESTIMENTO", (string)null);
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Pedido", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)")
                        .HasColumnName("CD_PEDIDO");

                    b.Property<long>("AtivoId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_ATIVO_INVESTIMENTO");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_PEDIDO");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("DS_OBSERVACAO");

                    b.Property<bool>("OrdemDeCompra")
                        .HasColumnType("boolean")
                        .HasColumnName("FL_ORDEM_COMPRA");

                    b.Property<long>("Quantidade")
                        .HasColumnType("bigint")
                        .HasColumnName("QT_PEDIDO");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_USUARIO_INVESTIDOR");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("VL_PEDIDO");

                    b.HasKey("Id")
                        .HasName("PK_PEDIDO");

                    b.HasIndex("AtivoId")
                        .HasDatabaseName("IDX_ATIVO_PEDIDO");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("IDX_USUARIO_PEDIDO");

                    b.ToTable("TB_PEDIDO", (string)null);
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Perfil", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CD_PERFIL_INVESTIDOR");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_REGISTRO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("DS_PERFIL_INVESTIDOR");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("NM_PERFIL_INVESTIDOR");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("FL_ATIVO");

                    b.HasKey("Id")
                        .HasName("PK_PERFIL_INVESTIDOR");

                    b.ToTable("TB_PERFIL_INVESTIDOR", (string)null);
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Recomendacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CD_RECOMENDACAO_INVESTIMENTO");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AtivoId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_ATIVO_INVESTIMENTO");

                    b.Property<long>("ConsultorId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_USUARIO_CONSULTOR");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_COMPRA_SIMULACAO");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("DS_OBSERVACAO");

                    b.Property<long>("Quantidade")
                        .HasColumnType("bigint")
                        .HasColumnName("QT_COMPRA_SIMULACAO");

                    b.Property<long>("RentabilidadeEmDias")
                        .HasColumnType("bigint")
                        .HasColumnName("NR_TEMPO_DIAS_RETABILIDADE");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_USUARIO_INVESTIDOR");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric")
                        .HasColumnName("VL_COMPRA_SIMULACAO");

                    b.HasKey("Id")
                        .HasName("PK_RECOMENDACAO_INVESTIMENTO");

                    b.HasIndex("AtivoId")
                        .HasDatabaseName("IDX_RECOME_INVESTIMENTO_ATIVO");

                    b.HasIndex("ConsultorId")
                        .HasDatabaseName("IDX_USUARIO_CONSULTOR_RECOMENDACAO");

                    b.HasIndex("UsuarioId")
                        .HasDatabaseName("IDX_USUARIO_INVESTIDOR_RECOMENDACAO");

                    b.ToTable("TB_RECOMENDACAO_INVESTIMENTO", (string)null);
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.TipoUsuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CD_TIPO_USUARIO");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_REGISTRO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("DS_TIPO_USUARIO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("NM_TIPO_USUARIO");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean")
                        .HasColumnName("FL_ATIVO");

                    b.HasKey("Id")
                        .HasName("PK_TIPO_USUARIO");

                    b.ToTable("TB_TIPO_USUARIO", (string)null);
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CD_USUARIO");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)")
                        .HasColumnName("NR_CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("DS_EMAIL");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("DS_LOGIN");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("NM_USUARIO");

                    b.Property<long>("PerfilId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_PERFIL_INVESTIDOR");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("TX_SENHA");

                    b.Property<long>("TipoUsuarioId")
                        .HasColumnType("bigint")
                        .HasColumnName("CD_TIPO_USUARIO");

                    b.Property<DateTime>("UltimoAcesso")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DT_ULTIMO_ACESSO");

                    b.HasKey("Id")
                        .HasName("PK_USUARIO");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasDatabaseName("UK_USUARIO_NRCPF_UNIQUE");

                    b.HasIndex("Login")
                        .IsUnique()
                        .HasDatabaseName("UK_USUARIO_LOGIN_UNIQUE");

                    b.HasIndex("PerfilId");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("TB_USUARIO", (string)null);
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Aporte", b =>
                {
                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("Aportes")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_USUARIO_APORTE_CONTA");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Pedido", b =>
                {
                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.Ativo", "Ativo")
                        .WithMany("Pedidos")
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_ATIVO_PEDIDO");

                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_USUARIO_PEDIDO");

                    b.Navigation("Ativo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Recomendacao", b =>
                {
                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.Ativo", "Ativo")
                        .WithMany("Recomendacoes")
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_RECOME_INVESTIMENTO_ATIVO");

                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.Usuario", "Consultor")
                        .WithMany("RecomendacoesConsultor")
                        .HasForeignKey("ConsultorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_USUARIO_CONSULTOR");

                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("RecomendacoesUsuario")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_USUARIO_INVESTIDOR");

                    b.Navigation("Ativo");

                    b.Navigation("Consultor");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Usuario", b =>
                {
                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.Perfil", "Perfil")
                        .WithMany("Usuarios")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_PERFIL_INVESTIDOR");

                    b.HasOne("Br.Com.FiapInvestiments.Domain.Entidades.TipoUsuario", "TipoUsuario")
                        .WithMany("Usuarios")
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_TIPO_USUARIO");

                    b.Navigation("Perfil");

                    b.Navigation("TipoUsuario");
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Ativo", b =>
                {
                    b.Navigation("Pedidos");

                    b.Navigation("Recomendacoes");
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Perfil", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.TipoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Br.Com.FiapInvestiments.Domain.Entidades.Usuario", b =>
                {
                    b.Navigation("Aportes");

                    b.Navigation("Pedidos");

                    b.Navigation("RecomendacoesConsultor");

                    b.Navigation("RecomendacoesUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
