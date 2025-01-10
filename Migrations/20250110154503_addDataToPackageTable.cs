using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SdRashaGYMV2.Migrations
{
    /// <inheritdoc />
    public partial class addDataToPackageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "Days", "Description", "Duration", "PackageName", "Price" },
                values: new object[,]
                {
                    { 1, "Sunday, Monday", null, "30", "Test Package", 100m },
                    { 2, "Tuesday, Wednesdsy", null, "60", "Test2 Package", 200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Packages",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
