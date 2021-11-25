using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_api.Migrations
{
    public partial class db_creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    idProduct = table.Column<string>(type: "nvarchar(45)", nullable: false),
                    nameProduct = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    expirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    barCode = table.Column<string>(type: "nvarchar(300)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.idProduct);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
