using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Kondominium.RepositoryBase.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Admininstrador = table.Column<bool>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    DataInsercao = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Excluido = table.Column<bool>(nullable: false),
                    Funcionario = table.Column<bool>(nullable: false),
                    Inquilino = table.Column<bool>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Morador = table.Column<bool>(nullable: false),
                    Proprietario = table.Column<bool>(nullable: false),
                    RepresentanteOficial = table.Column<bool>(nullable: false),
                    Senha = table.Column<string>(nullable: true),
                    Sindico = table.Column<bool>(nullable: false),
                    Telefone1 = table.Column<string>(nullable: true),
                    Telefone2 = table.Column<string>(nullable: true),
                    ViceSindico = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BlocoId = table.Column<int>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    DataInsercao = table.Column<DateTime>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false),
                    Numero = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartamento_Bloco_BlocoId",
                        column: x => x.BlocoId,
                        principalTable: "Bloco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apartamento_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartamento_BlocoId",
                table: "Apartamento",
                column: "BlocoId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartamento_UsuarioId",
                table: "Apartamento",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartamento");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
