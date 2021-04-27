using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShopApi.Migrations
{
    public partial class Bikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeShops_BikeShopLocationId",
                table: "Bikes");

            migrationBuilder.DropIndex(
                name: "IX_Bikes_BikeShopLocationId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "BikeShopLocationId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "CurrentStoreId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "HomeStoreId",
                table: "Bikes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BikeShopLocationId",
                table: "Bikes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrentStoreId",
                table: "Bikes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeStoreId",
                table: "Bikes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_BikeShopLocationId",
                table: "Bikes",
                column: "BikeShopLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeShops_BikeShopLocationId",
                table: "Bikes",
                column: "BikeShopLocationId",
                principalTable: "BikeShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
