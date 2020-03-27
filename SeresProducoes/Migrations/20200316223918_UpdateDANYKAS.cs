using Microsoft.EntityFrameworkCore.Migrations;

namespace SeresProducoes.Migrations
{
    public partial class UpdateDANYKAS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "Image" },
                values: new object[] { "Danykas Dj was born in Lisbon, Portugal. The love of music has always been a constant in her life, atmosphere felt early on in their home. A musical spirit cultivated by her father, a passion that exists in the whole family. Never leaving the corners of her room, in 2015 comes the first invitation to expose itself to the public in the Room System Project at Casa Independente, Lisbon ,held by Seres Producoes where she's working currently. Was the place where she could express her vibes through the simbiose of Afro Electronic Music and Deep House. The desire was increasing, the willingness to take the aspect of music more 'serious' as well, which allowed her to go through places like Lux Frágil, Festival Musa Cascais, Douro Rock Festival, Maus Hábitos, Musicbox Lisboa, two clubs in UK and host a Show at Quântica Rádio invited by Violet.", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "Image" },
                values: new object[] { "DANYKAS DJ was born in Lisbon, Portugal. The love of music has always been a constant in her life.  A musical spirit cultivated by her father, a passion that exists in the whole family. At 11 years, she began to have her interest in the world of DJ’ing when they got to watch the festivities that were held by the group’s DJ Black Project, where two of her brothers in-laws were participating. These approaches to parties shaped her musical background and made this adventure in dj’ing a reality. Since 2012, she was increasing the willingness to take the aspect of music to seriously, dedicating it longer, and Dj Satelite's invitation came in for her to join the Room System project, an opportunity to expose all this feeling through music, to get to the spirits of the people.", "/images/artists/DANYKAS.jpg" });
        }
    }
}
