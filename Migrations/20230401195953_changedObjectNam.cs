using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace optricon_home.Migrations
{
    /// <inheritdoc />
    public partial class changedObjectNam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOffers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MediaObjects",
                columns: new[] { "Id", "ButtonText", "ImageAlt", "ImagePath", "Text", "Title" },
                values: new object[,]
                {
                    { 1, "New Products", "Bird catching fish from River", "/images/Bird.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.", "New Products" },
                    { 2, "View Events", "Group of Photographers with Long-lens", "/images/Photographers.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.", "Field Events" },
                    { 3, "Read Article", "Landscape with Mountains", "/images/Landscape.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.", "Latest News" },
                    { 4, "View Gallery", "Bird in tree", "/images/Bird.png", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.", "Gallery" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryTitle", "ImageAlt", "ImagePath" },
                values: new object[,]
                {
                    { 1, "Binoculars", "Binocula 1", "/images/Binocula_1.png" },
                    { 2, "Compact Binoculars", "Binocula 2", "/images/Binocula_2.png" },
                    { 3, "Telescopes & Eyepieces", "Binocula 3", "/images/Binocula_3.png" },
                    { 4, "Observation & Marine", "Binocula 4", "/images/Binocula_4.png" },
                    { 5, "Binoculars", "Binocula 1", "/images/Binocula_1.png" },
                    { 6, "Compact Binoculars", "Binocula 2", "/images/Binocula_2.png" },
                    { 7, "Telescopes & Eyepieces", "Binocula 3", "/images/Binocula_3.png" },
                    { 8, "Observation & Marine", "Binocula 4", "/images/Binocula_4.png" }
                });

            migrationBuilder.InsertData(
                table: "SpecialOffers",
                columns: new[] { "Id", "ImageAlt", "ImagePath", "ItemText", "ItemTitle" },
                values: new object[,]
                {
                    { 1, "Money", "/images/Money.png", "£20 Cashback", "Discovery WP PC" },
                    { 2, "Olympus Camera", "/images/Olympus.png", "Free Digiscoping Kit", "HR ED Fieldscopes" },
                    { 3, "Otricon Camera", "/images/Otricon_Cam.png", "Save 25%", "IS 60 WP FieldScope Kits" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaObjects");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "SpecialOffers");
        }
    }
}
