using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace API.Migrations
{
    public partial class v04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FarmaciaId",
                table: "Medicamentos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Farmacia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Endereço = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmacia", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_FarmaciaId",
                table: "Medicamentos",
                column: "FarmaciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicamentos_Farmacia_FarmaciaId",
                table: "Medicamentos",
                column: "FarmaciaId",
                principalTable: "Farmacia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicamentos_Farmacia_FarmaciaId",
                table: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Farmacia");

            migrationBuilder.DropIndex(
                name: "IX_Medicamentos_FarmaciaId",
                table: "Medicamentos");

            migrationBuilder.DropColumn(
                name: "FarmaciaId",
                table: "Medicamentos");
        }
    }
}
