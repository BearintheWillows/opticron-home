using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace optricon_home.Migrations
{
    /// <inheritdoc />
    public partial class AddedSpecialOffers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpecialOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageAlt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOffers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SpecialOffers",
                columns: new[] { "Id", "ImageAlt", "ImagePath", "ItemTitle", "Text" },
                values: new object[,]
                {
                    { 1, "Money", "/images/Money.png", "Discovery WP PC", "£20 Cashback" },
                    { 2, "Olympus Camera", "/images/Olympus.png", "HR ED Fieldscopes", "Free Digiscoping Kit" },
                    { 3, "Otricon Camera", "/images/Otricon_Cam.png", "IS 60 WP FieldScope Kits", "Save 25%" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecialOffers");
        }
    }
}
