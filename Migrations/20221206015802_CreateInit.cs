using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLNet2_Nhom11.Migrations
{
    public partial class CreateInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributesPrices_Product_ProductId",
                table: "AttributesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Product_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CatId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_ProductHomeVMs_ProductHomeVMId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ProductHomeVMId",
                table: "Products",
                newName: "IX_Products_ProductHomeVMId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CatId",
                table: "Products",
                newName: "IX_Products_CatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributesPrices_Products_ProductId",
                table: "AttributesPrices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CatId",
                table: "Products",
                column: "CatId",
                principalTable: "Categories",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductHomeVMs_ProductHomeVMId",
                table: "Products",
                column: "ProductHomeVMId",
                principalTable: "ProductHomeVMs",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributesPrices_Products_ProductId",
                table: "AttributesPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CatId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductHomeVMs_ProductHomeVMId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductHomeVMId",
                table: "Product",
                newName: "IX_Product_ProductHomeVMId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CatId",
                table: "Product",
                newName: "IX_Product_CatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributesPrices_Product_ProductId",
                table: "AttributesPrices",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Product_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Product_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CatId",
                table: "Product",
                column: "CatId",
                principalTable: "Categories",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ProductHomeVMs_ProductHomeVMId",
                table: "Product",
                column: "ProductHomeVMId",
                principalTable: "ProductHomeVMs",
                principalColumn: "Id");
        }
    }
}
