using Microsoft.EntityFrameworkCore.Migrations;

namespace SeresProducoes.Migrations
{
    public partial class AddTrack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Releases",
                columns: new[] { "Id", "Artist", "Image", "Link", "Title" },
                values: new object[] { 12, "DEMENTED SOUL", "/images/releases/12_TranscendEP.jpg", "https://www.traxsource.com/title/1321228/transcend-ep", "Transcend EP" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Releases",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
