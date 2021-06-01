using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UrnaAngular.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePresidente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomeVice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Partido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Legenda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Votos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatoId = table.Column<int>(type: "int", nullable: true),
                    QtdVotos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votos_Candidatos_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Candidatos",
                columns: new[] { "Id", "DataCadastro", "Legenda", "NomePresidente", "NomeVice", "Partido" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 31, 8, 54, 58, 355, DateTimeKind.Local).AddTicks(6406), 0, "Branco", "Branco", "Branco" },
                    { 2, new DateTime(2021, 5, 31, 8, 54, 58, 357, DateTimeKind.Local).AddTicks(7814), 99, "Nulo", "Nulo", "Nulo" },
                    { 3, new DateTime(2021, 5, 31, 8, 54, 58, 357, DateTimeKind.Local).AddTicks(7858), 12, "Lula", "Madona", "PT" },
                    { 4, new DateTime(2021, 5, 31, 8, 54, 58, 357, DateTimeKind.Local).AddTicks(7862), 45, "FHC", "Mickey", "PSDB" },
                    { 5, new DateTime(2021, 5, 31, 8, 54, 58, 357, DateTimeKind.Local).AddTicks(7864), 17, "Jumento", "Capitao Jegue", "PSL" }
                });

            migrationBuilder.InsertData(
                table: "Votos",
                columns: new[] { "Id", "CandidatoId", "QtdVotos" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 11, 2, 1 },
                    { 4, 3, 1 },
                    { 5, 3, 1 },
                    { 8, 3, 1 },
                    { 10, 3, 1 },
                    { 12, 3, 1 },
                    { 6, 4, 1 },
                    { 7, 4, 1 },
                    { 3, 5, 1 },
                    { 9, 5, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Votos_CandidatoId",
                table: "Votos",
                column: "CandidatoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votos");

            migrationBuilder.DropTable(
                name: "Candidatos");
        }
    }
}
