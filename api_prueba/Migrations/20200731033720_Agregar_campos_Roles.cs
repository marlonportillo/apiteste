using Microsoft.EntityFrameworkCore.Migrations;

namespace api_prueba.Migrations
{
    public partial class Agregar_campos_Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rol",
                schema: "ADM",
                table: "Roles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rol",
                schema: "ADM",
                table: "Roles");
        }
    }
}
