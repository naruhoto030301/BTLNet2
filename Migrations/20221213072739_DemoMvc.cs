using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLNet2_Nhom11.Migrations
{
    public partial class DemoMvc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_LocationId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LocationId",
                table: "Customers",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_LocationId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LocationId",
                table: "Customers",
                column: "LocationId",
                unique: true,
                filter: "[LocationId] IS NOT NULL");
        }
    }
}
