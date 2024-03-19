using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class ProductShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Earbudses",
                table: "Earbudses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Earbudses");

            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "Watchs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "Watchs",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "Phones",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "Phones",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "LEDtv",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "LEDtv",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "Laptops",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "Laptops",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "Fanses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "Fanses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "product_key",
                table: "Earbudses",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Product_Detail",
                table: "Earbudses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Product_warranty",
                table: "Earbudses",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Earbudses",
                table: "Earbudses",
                column: "product_key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Earbudses",
                table: "Earbudses");

            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "Watchs");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "Watchs");

            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "LEDtv");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "LEDtv");

            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "Laptops");

            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "Fanses");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "Fanses");

            migrationBuilder.DropColumn(
                name: "Product_Detail",
                table: "Earbudses");

            migrationBuilder.DropColumn(
                name: "Product_warranty",
                table: "Earbudses");

            migrationBuilder.AlterColumn<int>(
                name: "product_key",
                table: "Earbudses",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Earbudses",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Earbudses",
                table: "Earbudses",
                column: "Id");
        }
    }
}
