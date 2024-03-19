using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Earbudses");

            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Price",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "cid",
                table: "Products",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_cid",
                table: "Products",
                column: "cid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_cid",
                table: "Products",
                column: "cid",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_cid",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Products_cid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "cid",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "Earbudses",
                columns: table => new
                {
                    product_key = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Detail = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_warranty = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Earbudses", x => x.product_key);
                });
        }
    }
}
