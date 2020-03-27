using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeresProducoes.Migrations
{
    public partial class AddImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImagePath" },
                values: new object[,]
                {
                    { 1, "/images/gallery/1.jpg" },
                    { 29, "/images/gallery/29.jpg" },
                    { 28, "/images/gallery/28.png" },
                    { 27, "/images/gallery/27.jpg" },
                    { 26, "/images/gallery/26.jpg" },
                    { 25, "/images/gallery/25.jpg" },
                    { 24, "/images/gallery/24.jpg" },
                    { 23, "/images/gallery/23.png" },
                    { 22, "/images/gallery/22.jpg" },
                    { 21, "/images/gallery/21.jpg" },
                    { 20, "/images/gallery/20.png" },
                    { 19, "/images/gallery/19.png" },
                    { 18, "/images/gallery/18.jpg" },
                    { 17, "/images/gallery/17.jpg" },
                    { 30, "/images/gallery/30.jpg" },
                    { 16, "/images/gallery/16.jpg" },
                    { 14, "/images/gallery/14.jpg" },
                    { 13, "/images/gallery/13.jpg" },
                    { 12, "/images/gallery/12.jpg" },
                    { 11, "/images/gallery/11.png" },
                    { 10, "/images/gallery/10.jpg" },
                    { 9, "/images/gallery/9.jpg" },
                    { 8, "/images/gallery/8.jpg" },
                    { 7, "/images/gallery/7.jpg" },
                    { 6, "/images/gallery/6.jpg" },
                    { 5, "/images/gallery/5.jpg" },
                    { 4, "/images/gallery/4.jpg" },
                    { 3, "/images/gallery/3.jpg" },
                    { 2, "/images/gallery/2.jpg" },
                    { 15, "/images/gallery/15.jpg" },
                    { 31, "/images/gallery/31.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
