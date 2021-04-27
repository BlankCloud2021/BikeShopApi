using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShopApi.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_BikeShopId",
                table: "Employees",
                column: "BikeShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_BikeShops_BikeShopId",
                table: "Employees",
                column: "BikeShopId",
                principalTable: "BikeShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_BikeShops_BikeShopId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_BikeShopId",
                table: "Employees");
        }
    }
}
