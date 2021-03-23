using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace ProductsAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Category = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Accessories", "The DualSense wireless controller offers immersive haptic feedback, dynamic adaptive triggers and a built-in microphone.", "Playstation DualSense Wireless Controller" },
                    { 2, "Accessories", "Experience the modernized design of the Xbox Wireless Controller, featuring sculpted surfaces for enhanced comfort during gameplay.", "Xbox Core Controller - Carbon Black" },
                    { 3, "Accessories", "Take your game sessions up a notch with the Nintendo Switch Pro Controller. Includes motion controls, HD rumble, built-in amiibo functionality, and more.", "Nintendo Switch Pro Controller" },
                    { 4, "Games", "Lead epic Viking raids against Saxon troops and fortresses", "Assassin’s Creed Valhalla PlayStation 5" },
                    { 5, "Games", "Black Ops Cold War will drop fans into the depths of the Cold War’s volatile geopolitical battle of the early 1980s.", "Call of Duty: Black Ops Cold War - Xbox One" },
                    { 6, "Games", "Hit the road with the definitive version of Mario Kart 8 and play anytime, anywhere!", "Mario Kart 8 Deluxe - Nintendo Switch" },
                    { 7, "Consoles", "Harness the power of a custom CPU, GPU, and SSD with Integrated I/O that rewrite the rules of what a PlayStation console can do.", "PlayStation 5 Console" },
                    { 8, "Consoles", "Play with friends and family near and far—sitting together on the sofa or around the world on Xbox Live, the fastest, most reliable gaming network", "Xbox Series S" },
                    { 9, "Consoles", "Play your way with the Nintendo Switch gaming system. Whether you’re at home or on the go, solo or with friends", "Nintendo Switch – Neon Red and Neon Blue Joy-Con" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
