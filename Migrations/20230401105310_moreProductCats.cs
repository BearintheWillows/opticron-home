using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace optricon_home.Migrations
{
    /// <inheritdoc />
    public partial class moreProductCats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryTitle", "ImageAlt", "ImagePath" },
                values: new object[,]
                {
                    { 5, "Binoculars", "Binocula 1", "/images/Binocula_1.png" },
                    { 6, "Compact Binoculars", "Binocula 2", "/images/Binocula_2.png" },
                    { 7, "Telescopes & Eyepieces", "Binocula 3", "/images/Binocula_3.png" },
                    { 8, "Observation & Marine", "Binocula 4", "/images/Binocula_4.png" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
