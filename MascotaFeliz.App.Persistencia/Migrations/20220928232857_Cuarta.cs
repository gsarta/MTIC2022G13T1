using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Cuarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdVeterinario",
                table: "VisitasPyP");

            migrationBuilder.AddColumn<string>(
                name: "CedulaVeterinario",
                table: "VisitasPyP",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CedulaVeterinario",
                table: "VisitasPyP");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "IdVeterinario",
                table: "VisitasPyP",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
