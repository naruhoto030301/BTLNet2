using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLNet2_Nhom11.Migrations
{
    public partial class Create_Table_Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Customers_LocationId",
                table: "Customers",
                column: "LocationId",
                unique: true,
                filter: "[LocationId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Locations_LocationId",
                table: "Customers",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Locations_LocationId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_LocationId",
                table: "Customers");
        }
    }
}
