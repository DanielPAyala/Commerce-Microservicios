using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description for product 1", "Product 1", 974m },
                    { 73, "Description for product 73", "Product 73", 885m },
                    { 72, "Description for product 72", "Product 72", 904m },
                    { 71, "Description for product 71", "Product 71", 359m },
                    { 70, "Description for product 70", "Product 70", 974m },
                    { 69, "Description for product 69", "Product 69", 943m },
                    { 68, "Description for product 68", "Product 68", 929m },
                    { 67, "Description for product 67", "Product 67", 326m },
                    { 66, "Description for product 66", "Product 66", 284m },
                    { 65, "Description for product 65", "Product 65", 642m },
                    { 64, "Description for product 64", "Product 64", 482m },
                    { 63, "Description for product 63", "Product 63", 548m },
                    { 62, "Description for product 62", "Product 62", 633m },
                    { 61, "Description for product 61", "Product 61", 936m },
                    { 60, "Description for product 60", "Product 60", 356m },
                    { 59, "Description for product 59", "Product 59", 180m },
                    { 58, "Description for product 58", "Product 58", 917m },
                    { 57, "Description for product 57", "Product 57", 656m },
                    { 56, "Description for product 56", "Product 56", 613m },
                    { 55, "Description for product 55", "Product 55", 305m },
                    { 54, "Description for product 54", "Product 54", 986m },
                    { 53, "Description for product 53", "Product 53", 794m },
                    { 74, "Description for product 74", "Product 74", 357m },
                    { 52, "Description for product 52", "Product 52", 693m },
                    { 75, "Description for product 75", "Product 75", 331m },
                    { 77, "Description for product 77", "Product 77", 423m },
                    { 98, "Description for product 98", "Product 98", 655m },
                    { 97, "Description for product 97", "Product 97", 397m },
                    { 96, "Description for product 96", "Product 96", 162m },
                    { 95, "Description for product 95", "Product 95", 937m },
                    { 94, "Description for product 94", "Product 94", 364m },
                    { 93, "Description for product 93", "Product 93", 680m },
                    { 92, "Description for product 92", "Product 92", 566m },
                    { 91, "Description for product 91", "Product 91", 596m },
                    { 90, "Description for product 90", "Product 90", 323m },
                    { 89, "Description for product 89", "Product 89", 470m },
                    { 88, "Description for product 88", "Product 88", 529m },
                    { 87, "Description for product 87", "Product 87", 963m },
                    { 86, "Description for product 86", "Product 86", 518m },
                    { 85, "Description for product 85", "Product 85", 179m },
                    { 84, "Description for product 84", "Product 84", 971m },
                    { 83, "Description for product 83", "Product 83", 937m },
                    { 82, "Description for product 82", "Product 82", 215m },
                    { 81, "Description for product 81", "Product 81", 701m },
                    { 80, "Description for product 80", "Product 80", 937m },
                    { 79, "Description for product 79", "Product 79", 126m },
                    { 78, "Description for product 78", "Product 78", 629m },
                    { 76, "Description for product 76", "Product 76", 533m },
                    { 51, "Description for product 51", "Product 51", 735m },
                    { 50, "Description for product 50", "Product 50", 213m },
                    { 49, "Description for product 49", "Product 49", 350m },
                    { 22, "Description for product 22", "Product 22", 461m },
                    { 21, "Description for product 21", "Product 21", 378m },
                    { 20, "Description for product 20", "Product 20", 927m },
                    { 19, "Description for product 19", "Product 19", 231m },
                    { 18, "Description for product 18", "Product 18", 506m },
                    { 17, "Description for product 17", "Product 17", 665m },
                    { 16, "Description for product 16", "Product 16", 744m },
                    { 15, "Description for product 15", "Product 15", 227m },
                    { 14, "Description for product 14", "Product 14", 780m },
                    { 13, "Description for product 13", "Product 13", 604m },
                    { 12, "Description for product 12", "Product 12", 742m },
                    { 11, "Description for product 11", "Product 11", 943m },
                    { 10, "Description for product 10", "Product 10", 754m },
                    { 9, "Description for product 9", "Product 9", 297m },
                    { 8, "Description for product 8", "Product 8", 633m },
                    { 7, "Description for product 7", "Product 7", 821m },
                    { 6, "Description for product 6", "Product 6", 857m },
                    { 5, "Description for product 5", "Product 5", 816m },
                    { 4, "Description for product 4", "Product 4", 873m },
                    { 3, "Description for product 3", "Product 3", 930m },
                    { 2, "Description for product 2", "Product 2", 531m },
                    { 23, "Description for product 23", "Product 23", 874m },
                    { 24, "Description for product 24", "Product 24", 112m },
                    { 25, "Description for product 25", "Product 25", 792m },
                    { 26, "Description for product 26", "Product 26", 560m },
                    { 48, "Description for product 48", "Product 48", 805m },
                    { 47, "Description for product 47", "Product 47", 858m },
                    { 46, "Description for product 46", "Product 46", 855m },
                    { 45, "Description for product 45", "Product 45", 985m },
                    { 44, "Description for product 44", "Product 44", 345m },
                    { 43, "Description for product 43", "Product 43", 137m },
                    { 42, "Description for product 42", "Product 42", 845m },
                    { 41, "Description for product 41", "Product 41", 696m },
                    { 40, "Description for product 40", "Product 40", 874m },
                    { 39, "Description for product 39", "Product 39", 621m },
                    { 99, "Description for product 99", "Product 99", 702m },
                    { 38, "Description for product 38", "Product 38", 760m },
                    { 36, "Description for product 36", "Product 36", 252m },
                    { 35, "Description for product 35", "Product 35", 837m },
                    { 34, "Description for product 34", "Product 34", 675m },
                    { 33, "Description for product 33", "Product 33", 516m },
                    { 32, "Description for product 32", "Product 32", 758m },
                    { 31, "Description for product 31", "Product 31", 212m },
                    { 30, "Description for product 30", "Product 30", 814m },
                    { 29, "Description for product 29", "Product 29", 184m },
                    { 28, "Description for product 28", "Product 28", 287m },
                    { 27, "Description for product 27", "Product 27", 921m },
                    { 37, "Description for product 37", "Product 37", 484m },
                    { 100, "Description for product 100", "Product 100", 800m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 28 },
                    { 73, 73, 39 },
                    { 72, 72, 48 },
                    { 71, 71, 85 },
                    { 70, 70, 19 },
                    { 69, 69, 12 },
                    { 68, 68, 65 },
                    { 67, 67, 47 },
                    { 66, 66, 71 },
                    { 65, 65, 2 },
                    { 64, 64, 4 },
                    { 63, 63, 88 },
                    { 62, 62, 12 },
                    { 61, 61, 61 },
                    { 60, 60, 40 },
                    { 59, 59, 36 },
                    { 58, 58, 97 },
                    { 57, 57, 86 },
                    { 56, 56, 7 },
                    { 55, 55, 37 },
                    { 54, 54, 17 },
                    { 53, 53, 25 },
                    { 74, 74, 15 },
                    { 52, 52, 0 },
                    { 75, 75, 5 },
                    { 77, 77, 48 },
                    { 98, 98, 67 },
                    { 97, 97, 74 },
                    { 96, 96, 77 },
                    { 95, 95, 57 },
                    { 94, 94, 55 },
                    { 93, 93, 78 },
                    { 92, 92, 21 },
                    { 91, 91, 87 },
                    { 90, 90, 1 },
                    { 89, 89, 55 },
                    { 88, 88, 94 },
                    { 87, 87, 11 },
                    { 86, 86, 85 },
                    { 85, 85, 75 },
                    { 84, 84, 69 },
                    { 83, 83, 98 },
                    { 82, 82, 90 },
                    { 81, 81, 45 },
                    { 80, 80, 8 },
                    { 79, 79, 68 },
                    { 78, 78, 80 },
                    { 76, 76, 83 },
                    { 51, 51, 55 },
                    { 50, 50, 65 },
                    { 49, 49, 3 },
                    { 22, 22, 20 },
                    { 21, 21, 46 },
                    { 20, 20, 96 },
                    { 19, 19, 35 },
                    { 18, 18, 34 },
                    { 17, 17, 63 },
                    { 16, 16, 4 },
                    { 15, 15, 93 },
                    { 14, 14, 22 },
                    { 13, 13, 58 },
                    { 12, 12, 60 },
                    { 11, 11, 8 },
                    { 10, 10, 88 },
                    { 9, 9, 35 },
                    { 8, 8, 23 },
                    { 7, 7, 15 },
                    { 6, 6, 81 },
                    { 5, 5, 77 },
                    { 4, 4, 74 },
                    { 3, 3, 86 },
                    { 2, 2, 44 },
                    { 23, 23, 57 },
                    { 24, 24, 88 },
                    { 25, 25, 37 },
                    { 26, 26, 37 },
                    { 48, 48, 28 },
                    { 47, 47, 91 },
                    { 46, 46, 29 },
                    { 45, 45, 20 },
                    { 44, 44, 77 },
                    { 43, 43, 72 },
                    { 42, 42, 63 },
                    { 41, 41, 90 },
                    { 40, 40, 19 },
                    { 39, 39, 95 },
                    { 99, 99, 74 },
                    { 38, 38, 15 },
                    { 36, 36, 73 },
                    { 35, 35, 9 },
                    { 34, 34, 93 },
                    { 33, 33, 12 },
                    { 32, 32, 37 },
                    { 31, 31, 86 },
                    { 30, 30, 31 },
                    { 29, 29, 34 },
                    { 28, 28, 2 },
                    { 27, 27, 19 },
                    { 37, 37, 18 },
                    { 100, 100, 48 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductInStockId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductInStockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
