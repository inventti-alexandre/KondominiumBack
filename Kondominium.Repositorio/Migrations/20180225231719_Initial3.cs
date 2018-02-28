using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Kondominium.RepositoryBase.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCondominio",
                table: "Bloco");

            migrationBuilder.AddColumn<int>(
                name: "CondominioId",
                table: "Bloco",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "Bloco",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInsercao",
                table: "Bloco",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Excluido",
                table: "Bloco",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Condominio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(nullable: true),
                    Cidade = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: false),
                    DataInsercao = table.Column<DateTime>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    Excluido = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominio", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bloco_CondominioId",
                table: "Bloco",
                column: "CondominioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bloco_Condominio_CondominioId",
                table: "Bloco",
                column: "CondominioId",
                principalTable: "Condominio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bloco_Condominio_CondominioId",
                table: "Bloco");

            migrationBuilder.DropTable(
                name: "Condominio");

            migrationBuilder.DropIndex(
                name: "IX_Bloco_CondominioId",
                table: "Bloco");

            migrationBuilder.DropColumn(
                name: "CondominioId",
                table: "Bloco");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "Bloco");

            migrationBuilder.DropColumn(
                name: "DataInsercao",
                table: "Bloco");

            migrationBuilder.DropColumn(
                name: "Excluido",
                table: "Bloco");

            migrationBuilder.AddColumn<int>(
                name: "IdCondominio",
                table: "Bloco",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
