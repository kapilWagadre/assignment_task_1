using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class init1114 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "CustomerUPIPayments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Name",
                table: "CustomerUPIPayments",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "CustomerUPIPayments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "CustomerUPIPayments");

            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "CustomerUPIPayments");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "CustomerUPIPayments");
        }
    }
}
