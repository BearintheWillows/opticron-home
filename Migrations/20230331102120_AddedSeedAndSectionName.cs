using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace optricon_home.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedAndSectionName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SectionName",
                table: "Content",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "SectionName", "Text" },
                values: new object[] { "1", "section1-headings", "Heading 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DropColumn(
                name: "SectionName",
                table: "Content");
        }
    }
}
