using Microsoft.EntityFrameworkCore.Migrations;

namespace api_prueba.Migrations
{
    public partial class Agregar_campos_Usuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                schema: "ADM",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Correo",
                schema: "ADM",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                schema: "ADM",
                table: "Usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                schema: "ADM",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Correo",
                schema: "ADM",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Nombre",
                schema: "ADM",
                table: "Usuarios");
        }
    }
}
