using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class Product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fanses");

            migrationBuilder.DropTable(
                name: "LEDtv");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Customer_Name = table.Column<string>(type: "text", nullable: false),
                    Number = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_warranty = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcuctBills",
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
                    table.PrimaryKey("PK_ProcuctBills", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProcuctBills");

            migrationBuilder.CreateTable(
                name: "Fanses",
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
                    table.PrimaryKey("PK_Fanses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LEDtv",
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
                    table.PrimaryKey("PK_LEDtv", x => x.Id);
                });
        }
    }
}
