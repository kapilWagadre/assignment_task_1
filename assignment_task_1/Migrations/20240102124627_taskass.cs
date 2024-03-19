using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class taskass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "LEDtv",
                newName: "Product_Price");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "LEDtv",
                newName: "Product_Name");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Fanses",
                newName: "Product_Price");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "Fanses",
                newName: "Product_Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product_Price",
                table: "LEDtv",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Product_Name",
                table: "LEDtv",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "Product_Price",
                table: "Fanses",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Product_Name",
                table: "Fanses",
                newName: "Model");
        }
    }
}
