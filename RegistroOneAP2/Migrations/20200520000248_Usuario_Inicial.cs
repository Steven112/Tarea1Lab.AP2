using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroOneAP2.Migrations
{
    public partial class Usuario_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Nacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
