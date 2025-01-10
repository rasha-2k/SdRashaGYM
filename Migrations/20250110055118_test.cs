using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdRashaGYMV2.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SelectedDays",
                table: "Packages",
                newName: "Days");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Days",
                table: "Packages",
                newName: "SelectedDays");
        }
    }
}
