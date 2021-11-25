using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_api.Migrations
{
    public partial class testing_with_controllers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoriesXProduct_CategoriesXProductidCategoriesXProduct",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_CategoriesXProduct_CategoriesXProductidCategoriesXProduct",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Trademarks_TrademarksidTrademarks",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trademarks",
                table: "Trademarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoriesXProductidCategoriesXProduct",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TrademarksidTrademarks",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoriesXProductidCategoriesXProduct",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoriesXProductidCategoriesXProduct",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TrademarksidTrademarks",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoriesXProductidCategoriesXProduct",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Trademarks",
                newName: "TrademarkList");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductList");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryList");

            migrationBuilder.AlterColumn<string>(
                name: "idCategoriesXProduct",
                table: "CategoriesXProduct",
                type: "nvarchar(45)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CategoriesXProductID",
                table: "ProductList",
                type: "nvarchar(45)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrademarksID",
                table: "ProductList",
                type: "nvarchar(45)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CategoriesXProductID",
                table: "CategoryList",
                type: "nvarchar(45)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrademarkList",
                table: "TrademarkList",
                column: "idTrademarks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductList",
                table: "ProductList",
                column: "idProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryList",
                table: "CategoryList",
                column: "idCategory");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_CategoriesXProductID",
                table: "ProductList",
                column: "CategoriesXProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductList_TrademarksID",
                table: "ProductList",
                column: "TrademarksID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryList_CategoriesXProductID",
                table: "CategoryList",
                column: "CategoriesXProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryList_CategoriesXProduct_CategoriesXProductID",
                table: "CategoryList",
                column: "CategoriesXProductID",
                principalTable: "CategoriesXProduct",
                principalColumn: "idCategoriesXProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductList_CategoriesXProduct_CategoriesXProductID",
                table: "ProductList",
                column: "CategoriesXProductID",
                principalTable: "CategoriesXProduct",
                principalColumn: "idCategoriesXProduct",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductList_TrademarkList_TrademarksID",
                table: "ProductList",
                column: "TrademarksID",
                principalTable: "TrademarkList",
                principalColumn: "idTrademarks",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryList_CategoriesXProduct_CategoriesXProductID",
                table: "CategoryList");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductList_CategoriesXProduct_CategoriesXProductID",
                table: "ProductList");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductList_TrademarkList_TrademarksID",
                table: "ProductList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrademarkList",
                table: "TrademarkList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductList",
                table: "ProductList");

            migrationBuilder.DropIndex(
                name: "IX_ProductList_CategoriesXProductID",
                table: "ProductList");

            migrationBuilder.DropIndex(
                name: "IX_ProductList_TrademarksID",
                table: "ProductList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryList",
                table: "CategoryList");

            migrationBuilder.DropIndex(
                name: "IX_CategoryList_CategoriesXProductID",
                table: "CategoryList");

            migrationBuilder.DropColumn(
                name: "CategoriesXProductID",
                table: "ProductList");

            migrationBuilder.DropColumn(
                name: "TrademarksID",
                table: "ProductList");

            migrationBuilder.DropColumn(
                name: "CategoriesXProductID",
                table: "CategoryList");

            migrationBuilder.RenameTable(
                name: "TrademarkList",
                newName: "Trademarks");

            migrationBuilder.RenameTable(
                name: "ProductList",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "CategoryList",
                newName: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "idCategoriesXProduct",
                table: "CategoriesXProduct",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)")
                .Annotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.AddColumn<int>(
                name: "CategoriesXProductidCategoriesXProduct",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trademarks",
                table: "Trademarks",
                column: "idTrademarks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "idProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "idCategory");

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
                name: "FK_Categories_CategoriesXProduct_CategoriesXProductidCategoriesXProduct",
                table: "Categories",
                column: "CategoriesXProductidCategoriesXProduct",
                principalTable: "CategoriesXProduct",
                principalColumn: "idCategoriesXProduct",
                onDelete: ReferentialAction.Restrict);

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
    }
}
