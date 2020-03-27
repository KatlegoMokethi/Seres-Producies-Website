using Microsoft.EntityFrameworkCore.Migrations;

namespace SeresProducoes.Migrations
{
    public partial class MinorUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "/images/artists/DANYKAS.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Bio",
                value: "Rosario, born in Luanda, Angola. Made his debut in the world of House Music in 2011 posting sets of Afro House on soundcloud by the Mbambu Records group ( with Dj Nax and Braga Havaiana). Later in 2012 he joined “Tainted House Records”, based in South Africa, where he released several projects such as “Kalunga Kianda” with Braga Havaina and “Destiny” with Jackie Queens.And several remixes on tracks like “Roots” and “Tyityimba” authored by Rune Sibiya, and “You Don’t Deserve Me” by Reel Skaps(Global Deep Recordings). Currently in Mbambu Records group known as the author of the hits songs “Me Mata” (with Dj Jesus) and “Tatau” (with Bebucho Q Kuia), and other projects that are having a high impact on today’s african house scene. Later he meets with Dj Satelite on the record label ”Seres Produções” from Angola, becoming a member on the label, releasing tracks in collaboration with South African artists like Jackie Queens and Lebo Snookums with whom he released the single ‘Silly Of Me” and other projects.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 5,
                column: "Bio",
                value: "Rosario, born in Luanda, Angola. Made his debut in the world of House Music in 2011 posting sets of Afro House on soundcloud by the Mbambu Records group ( with Dj Nax and Braga Havaiana). Later in 2012 he joined “Tainted House Records”, based in South Africa, where he released several projects such as “Kalunga Kianda” with Braga Havaina and “Destiny” with Jackie Queens.And several remixes on tracks like “Roots” and “Tyityimba” authored by Rune Sibiya, and “You Don’t Deserve Me” by Reel Skaps(Global Deep Recordings). Currently in Mbambu Records group known as the author of the hits songs “Me Mata” (with Dj Jesus) and “Tatau” (with Bebucho Q Kuia), and other projects that are having a high impact on today’s african house scene. Later he meets with Dj Satelite on the record label ”Seres Produções” from Angola, becoming a member on the label, releasing tracks in collaboration with South African artists like Jackie Queens and Lebo Snookums with whom he released the single ‘Silly Of Me”and other projects.");
        }
    }
}
