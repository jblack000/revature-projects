using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Data.Migrations
{
    public partial class entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crusts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crusts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SelectedCrustId = table.Column<int>(nullable: false),
                    SelectedSizeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bread",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CrustId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bread", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bread_Crusts_CrustId",
                        column: x => x.CrustId,
                        principalTable: "Crusts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bread_CrustId",
                table: "Bread",
                column: "CrustId");

            migrationBuilder.CreateIndex(
                name: "IX_Crusts_Name",
                table: "Crusts",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_Id",
                table: "Pizzas",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_Name",
                table: "Sizes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_Name",
                table: "Toppings",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bread");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Crusts");
        }
    }
}
