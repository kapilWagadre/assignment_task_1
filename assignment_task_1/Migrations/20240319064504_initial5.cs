using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "UPIPayments");

            migrationBuilder.DropColumn(
                name: "Product_Price",
                table: "UPIPayments");

            migrationBuilder.RenameColumn(
                name: "Product_warranty",
                table: "UPIPayments",
                newName: "TotalPrice");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "UPIPayments",
                newName: "Product_warranty");

            migrationBuilder.AddColumn<string>(
                name: "Product_Name",
                table: "UPIPayments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Price",
                table: "UPIPayments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
