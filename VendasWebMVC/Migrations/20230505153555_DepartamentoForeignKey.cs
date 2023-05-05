using Microsoft.EntityFrameworkCore.Migrations;

namespace VendasWebMVC.Migrations
{
    public partial class DepartamentoForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentoId",
                table: "Vendedor",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentoId",
                table: "Vendedor");
        }
    }
}
