using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class product3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_Name",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Product_warranty",
                table: "Customers",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "Product_warranty");

            migrationBuilder.AddColumn<string>(
                name: "Product_Name",
                table: "Customers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
