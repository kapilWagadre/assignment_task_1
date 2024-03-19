using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class ass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "product_key",
                table: "Watchs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_key",
                table: "Phones",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_key",
                table: "LEDtv",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_key",
                table: "Laptops",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_key",
                table: "Fanses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "product_key",
                table: "Earbudses",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "product_key",
                table: "Watchs");

            migrationBuilder.DropColumn(
                name: "product_key",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "product_key",
                table: "LEDtv");

            migrationBuilder.DropColumn(
                name: "product_key",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "product_key",
                table: "Fanses");

            migrationBuilder.DropColumn(
                name: "product_key",
                table: "Earbudses");
        }
    }
}
