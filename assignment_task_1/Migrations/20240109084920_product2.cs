using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class product2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "ProcuctBills");

            migrationBuilder.DropTable(
                name: "Watchs");

            migrationBuilder.CreateTable(
                name: "ProcductBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Customer_Name = table.Column<string>(type: "text", nullable: false),
                    Contact = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_warranty = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcductBills", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcductBills");

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Detail = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_warranty = table.Column<string>(type: "text", nullable: false),
                    product_key = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Detail = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_warranty = table.Column<string>(type: "text", nullable: false),
                    product_key = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcuctBills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Contact = table.Column<string>(type: "text", nullable: false),
                    Customer_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_warranty = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcuctBills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Watchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Detail = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_warranty = table.Column<string>(type: "text", nullable: false),
                    product_key = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watchs", x => x.Id);
                });
        }
    }
}
