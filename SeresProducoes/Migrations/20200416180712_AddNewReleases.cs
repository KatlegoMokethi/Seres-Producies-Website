using Microsoft.EntityFrameworkCore.Migrations;

namespace SeresProducoes.Migrations
{
    public partial class AddNewReleases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Releases",
                columns: new[] { "Id", "Artist", "Image", "Link", "Title" },
                values: new object[] { 9, "DJ SATELITE", "/images/releases/9_KedumaRemixes.jpg", "https://www.traxsource.com/title/1330792/kemuda-remixes", "KEMUDA REMIXES" });

            migrationBuilder.InsertData(
                table: "Releases",
                columns: new[] { "Id", "Artist", "Image", "Link", "Title" },
                values: new object[] { 10, "EuphoriQsoul", "/images/releases/10_MamboEP.jpg", "https://www.traxsource.com/title/1297704/mambo-ep", "MAMBO EP" });

            migrationBuilder.InsertData(
                table: "Releases",
                columns: new[] { "Id", "Artist", "Image", "Link", "Title" },
                values: new object[] { 11, "DJ SATELITE", "/images/releases/11_KANDONGUEIRO2000.jpg", "https://www.traxsource.com/title/1311959/kandongueiro-2000", "Kandongueiro 2000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
