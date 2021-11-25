using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_api.Migrations
{
    public partial class Testing_relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idProduct",
                table: "Products",
                newName: "idProducts");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesXProductidCategoriesXProduct",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrademarksidTrademarks",
                table: "Products",
                type: "nvarchar(45)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoriesXProduct",
                columns: table => new
                {
                    idCategoriesXProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesXProduct", x => x.idCategoriesXProduct);
                });

            migrationBuilder.CreateTable(
                name: "Trademarks",
                columns: table => new
                {
                    idTrademarks = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    mark = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trademarks", x => x.idTrademarks);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    idCategory = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(45)", nullable: true),
                    CategoriesXProductidCategoriesXProduct = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.idCategory);
                    table.ForeignKey(
                        name: "FK_Categories_CategoriesXProduct_CategoriesXProductidCategoriesXProduct",
                        column: x => x.CategoriesXProductidCategoriesXProduct,
                        principalTable: "CategoriesXProduct",
                        principalColumn: "idCategoriesXProduct",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoriesXProductidCategoriesXProduct",
                table: "Products",
                column: "CategoriesXProductidCategoriesXProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TrademarksidTrademarks",
                table: "Products",
                column: "TrademarksidTrademarks");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoriesXProductidCategoriesXProduct",
                table: "Categories",
                column: "CategoriesXProductidCategoriesXProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CategoriesXProduct_CategoriesXProductidCategoriesXProduct",
                table: "Products",
                column: "CategoriesXProductidCategoriesXProduct",
                principalTable: "CategoriesXProduct",
                principalColumn: "idCategoriesXProduct",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Trademarks_TrademarksidTrademarks",
                table: "Products",
                column: "TrademarksidTrademarks",
                principalTable: "Trademarks",
                principalColumn: "idTrademarks",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoriesXProduct_CategoriesXProductidCategoriesXProduct",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Trademarks_TrademarksidTrademarks",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Trademarks");

            migrationBuilder.DropTable(
                name: "CategoriesXProduct");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoriesXProductidCategoriesXProduct",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TrademarksidTrademarks",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoriesXProductidCategoriesXProduct",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TrademarksidTrademarks",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "idProducts",
                table: "Products",
                newName: "idProduct");
        }
    }
}
