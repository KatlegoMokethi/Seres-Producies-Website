using Microsoft.EntityFrameworkCore.Migrations;

namespace SeresProducoes.Migrations
{
    public partial class SomeMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Artist", "Title" },
                values: new object[] { "GREG, BRUCE, DANIEL...", "BLACK CURSE..." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Artist", "Title" },
                values: new object[] { "ALEXANDROS DJKEVINGR, GREG IGNATOVICH...", "BLACK CURSE OF SARAPAST" });
        }
    }
}
