using Microsoft.EntityFrameworkCore.Migrations;

namespace UrnaAngular.Data.Migrations
{
    public partial class correcaoBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Partido",
                table: "Candidatos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Partido",
                table: "Candidatos");
        }
    }
}
