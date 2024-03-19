using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class product1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Singin",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Singin");
        }
    }
}
