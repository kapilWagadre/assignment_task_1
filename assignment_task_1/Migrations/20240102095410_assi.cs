using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace assignment_task_1.Migrations
{
    /// <inheritdoc />
    public partial class assi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Earbudses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Earbudses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fanses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fanses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LEDtv",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LEDtv", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Singin",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    contact = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Singin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Watchs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Product_Name = table.Column<string>(type: "text", nullable: false),
                    Product_Price = table.Column<string>(type: "text", nullable: false),
                    Product_Image = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watchs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Earbudses");

            migrationBuilder.DropTable(
                name: "Fanses");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "LEDtv");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Singin");

            migrationBuilder.DropTable(
                name: "Watchs");
        }
    }
}
