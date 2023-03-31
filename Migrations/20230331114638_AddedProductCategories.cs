using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace optricon_home.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryTitle", "ImageAlt", "ImagePath" },
                values: new object[,]
                {
                    { 1, "Binoculars", "Binocula 1", "/images/Binocula_1.png" },
                    { 2, "Compact Binoculars", "Binocula 2", "/images/Binocula_2.png" },
                    { 3, "Telescopes & Eyepieces", "Binocula 3", "/images/Binocula_3.png" },
                    { 4, "Observation & Marine", "Binocula 4", "/images/Binocula_4.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
