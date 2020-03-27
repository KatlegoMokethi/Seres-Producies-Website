using Microsoft.EntityFrameworkCore.Migrations;

namespace SeresProducoes.Migrations
{
    public partial class SomeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 3,
                column: "Artist",
                value: "ALEXANDROS DJKEVINGR, GREG IGNATOVICH...");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 3,
                column: "Artist",
                value: "ALEXANDROS DJKEVINGR & GREG IGNATOVICH, BRUCE LEROYS, DANIEL RATEUK");
        }
    }
}
