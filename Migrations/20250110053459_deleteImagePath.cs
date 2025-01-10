using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SdRashaGYMV2.Migrations
{
    /// <inheritdoc />
    public partial class deleteImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Packages");

            migrationBuilder.RenameColumn(
                name: "Days",
                table: "Packages",
                newName: "SelectedDays");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Packages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SelectedDays",
                table: "Packages",
                newName: "Days");

            migrationBuilder.AlterColumn<string>(
                name: "Duration",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Packages",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
