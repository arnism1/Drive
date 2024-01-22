using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Drive.Migrations
{
    /// <inheritdoc />
    public partial class upd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdometerEnd",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OdometerStart",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OdometerEnd",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "OdometerStart",
                table: "Tours");
        }
    }
}
