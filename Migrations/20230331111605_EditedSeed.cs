using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace optricon_home.Migrations
{
    /// <inheritdoc />
    public partial class EditedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MediaObjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/Bird.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MediaObjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/images/Birds.png");
        }
    }
}
