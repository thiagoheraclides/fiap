using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Br.Com.FiapInvestiments.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ATIVO_INVESTIMENTO",
                columns: table => new
                {
                    CD_ATIVO_INVESTIMENTO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SG_ATIVO_INVESTIMENTO = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    NM_ATIVO_INVESTIMENTO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DT_REGISTRO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DT_ENCERRAMENTO_ATIVO = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    NR_TEMPO_DIAS_RENTABILIDADE = table.Column<long>(type: "bigint", nullable: false),
                    VL_RENTABILIDADE = table.Column<decimal>(type: "numeric", nullable: false),
                    NR_ESCALA_RISCO = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATIVO_INVESTIMENTO", x => x.CD_ATIVO_INVESTIMENTO);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERFIL_INVESTIDOR",
                columns: table => new
                {
                    CD_PERFIL_INVESTIDOR = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_PERFIL_INVESTIDOR = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DS_PERFIL_INVESTIDOR = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    FL_ATIVO = table.Column<bool>(type: "boolean", nullable: false),
                    DT_REGISTRO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERFIL_INVESTIDOR", x => x.CD_PERFIL_INVESTIDOR);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPO_USUARIO",
                columns: table => new
                {
                    CD_TIPO_USUARIO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NM_TIPO_USUARIO = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DS_TIPO_USUARIO = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    FL_ATIVO = table.Column<bool>(type: "boolean", nullable: false),
                    DT_REGISTRO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_USUARIO", x => x.CD_TIPO_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    CD_USUARIO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NR_CPF = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    NM_USUARIO = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    DS_EMAIL = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    DS_LOGIN = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    TX_SENHA = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DT_ULTIMO_ACESSO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CD_PERFIL_INVESTIDOR = table.Column<long>(type: "bigint", nullable: true),
                    CD_TIPO_USUARIO = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.CD_USUARIO);
                    table.ForeignKey(
                        name: "FK_PERFIL_INVESTIDOR",
                        column: x => x.CD_PERFIL_INVESTIDOR,
                        principalTable: "TB_PERFIL_INVESTIDOR",
                        principalColumn: "CD_PERFIL_INVESTIDOR");
                    table.ForeignKey(
                        name: "FK_TIPO_USUARIO",
                        column: x => x.CD_TIPO_USUARIO,
                        principalTable: "TB_TIPO_USUARIO",
                        principalColumn: "CD_TIPO_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_APORTE_CONTA",
                columns: table => new
                {
                    CD_APORTE_CONTA = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    VL_APORTE_CONTA = table.Column<decimal>(type: "numeric", nullable: false),
                    DT_APORTE_CONTA = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DS_OBSERVACAO = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CD_USUARIO_INVESTIDOR = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APORTE_CONTA", x => x.CD_APORTE_CONTA);
                    table.ForeignKey(
                        name: "FK_USUARIO_APORTE_CONTA",
                        column: x => x.CD_USUARIO_INVESTIDOR,
                        principalTable: "TB_USUARIO",
                        principalColumn: "CD_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_PEDIDO",
                columns: table => new
                {
                    CD_PEDIDO = table.Column<decimal>(type: "numeric(20,0)", nullable: false),
                    DT_PEDIDO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    QT_PEDIDO = table.Column<long>(type: "bigint", nullable: false),
                    VL_PEDIDO = table.Column<decimal>(type: "numeric", nullable: false),
                    FL_ORDEM_COMPRA = table.Column<bool>(type: "boolean", nullable: false),
                    DS_OBSERVACAO = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CD_USUARIO_INVESTIDOR = table.Column<long>(type: "bigint", nullable: false),
                    CD_ATIVO_INVESTIMENTO = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEDIDO", x => x.CD_PEDIDO);
                    table.ForeignKey(
                        name: "FK_ATIVO_PEDIDO",
                        column: x => x.CD_ATIVO_INVESTIMENTO,
                        principalTable: "TB_ATIVO_INVESTIMENTO",
                        principalColumn: "CD_ATIVO_INVESTIMENTO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USUARIO_PEDIDO",
                        column: x => x.CD_USUARIO_INVESTIDOR,
                        principalTable: "TB_USUARIO",
                        principalColumn: "CD_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_RECOMENDACAO_INVESTIMENTO",
                columns: table => new
                {
                    CD_RECOMENDACAO_INVESTIMENTO = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VL_COMPRA_SIMULACAO = table.Column<decimal>(type: "numeric", nullable: false),
                    QT_COMPRA_SIMULACAO = table.Column<long>(type: "bigint", nullable: false),
                    DT_COMPRA_SIMULACAO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NR_TEMPO_DIAS_RETABILIDADE = table.Column<long>(type: "bigint", nullable: false),
                    DS_OBSERVACAO = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CD_USUARIO_INVESTIDOR = table.Column<long>(type: "bigint", nullable: false),
                    CD_USUARIO_CONSULTOR = table.Column<long>(type: "bigint", nullable: false),
                    CD_ATIVO_INVESTIMENTO = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECOMENDACAO_INVESTIMENTO", x => x.CD_RECOMENDACAO_INVESTIMENTO);
                    table.ForeignKey(
                        name: "FK_RECOME_INVESTIMENTO_ATIVO",
                        column: x => x.CD_ATIVO_INVESTIMENTO,
                        principalTable: "TB_ATIVO_INVESTIMENTO",
                        principalColumn: "CD_ATIVO_INVESTIMENTO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USUARIO_CONSULTOR",
                        column: x => x.CD_USUARIO_CONSULTOR,
                        principalTable: "TB_USUARIO",
                        principalColumn: "CD_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USUARIO_INVESTIDOR",
                        column: x => x.CD_USUARIO_INVESTIDOR,
                        principalTable: "TB_USUARIO",
                        principalColumn: "CD_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IDX_USUARIO_APORTE_CONTA",
                table: "TB_APORTE_CONTA",
                column: "CD_USUARIO_INVESTIDOR");

            migrationBuilder.CreateIndex(
                name: "IDX_ATIVO_PEDIDO",
                table: "TB_PEDIDO",
                column: "CD_ATIVO_INVESTIMENTO");

            migrationBuilder.CreateIndex(
                name: "IDX_USUARIO_PEDIDO",
                table: "TB_PEDIDO",
                column: "CD_USUARIO_INVESTIDOR");

            migrationBuilder.CreateIndex(
                name: "IDX_RECOME_INVESTIMENTO_ATIVO",
                table: "TB_RECOMENDACAO_INVESTIMENTO",
                column: "CD_ATIVO_INVESTIMENTO");

            migrationBuilder.CreateIndex(
                name: "IDX_USUARIO_CONSULTOR_RECOMENDACAO",
                table: "TB_RECOMENDACAO_INVESTIMENTO",
                column: "CD_USUARIO_CONSULTOR");

            migrationBuilder.CreateIndex(
                name: "IDX_USUARIO_INVESTIDOR_RECOMENDACAO",
                table: "TB_RECOMENDACAO_INVESTIMENTO",
                column: "CD_USUARIO_INVESTIDOR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_CD_PERFIL_INVESTIDOR",
                table: "TB_USUARIO",
                column: "CD_PERFIL_INVESTIDOR");

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_CD_TIPO_USUARIO",
                table: "TB_USUARIO",
                column: "CD_TIPO_USUARIO");

            migrationBuilder.CreateIndex(
                name: "UK_USUARIO_LOGIN_UNIQUE",
                table: "TB_USUARIO",
                column: "DS_LOGIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_USUARIO_NRCPF_UNIQUE",
                table: "TB_USUARIO",
                column: "NR_CPF",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_APORTE_CONTA");

            migrationBuilder.DropTable(
                name: "TB_PEDIDO");

            migrationBuilder.DropTable(
                name: "TB_RECOMENDACAO_INVESTIMENTO");

            migrationBuilder.DropTable(
                name: "TB_ATIVO_INVESTIMENTO");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.DropTable(
                name: "TB_PERFIL_INVESTIDOR");

            migrationBuilder.DropTable(
                name: "TB_TIPO_USUARIO");
        }
    }
}
