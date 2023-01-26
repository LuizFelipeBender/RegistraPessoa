using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistraPessoa.Api.Migrations
{
    public partial class Dataset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tabela_Pessoa",
                keyColumn: "URL_IMAGEM_PERFIL",
                keyValue: null,
                column: "URL_IMAGEM_PERFIL",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "URL_IMAGEM_PERFIL",
                table: "Tabela_Pessoa",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_DA_CRIACAO",
                table: "Tabela_Pessoa",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "URL_IMAGEM_PERFIL",
                table: "Tabela_Pessoa",
                type: "varchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(500)",
                oldMaxLength: 500)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DATA_DA_CRIACAO",
                table: "Tabela_Pessoa",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);
        }
    }
}
