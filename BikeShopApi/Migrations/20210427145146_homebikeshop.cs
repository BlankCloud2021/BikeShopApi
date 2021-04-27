using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShopApi.Migrations
{
    public partial class homebikeshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeShops_HomeBikeShopId",
                table: "Bikes");

            migrationBuilder.AlterColumn<int>(
                name: "HomeBikeShopId",
                table: "Bikes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeShops_HomeBikeShopId",
                table: "Bikes",
                column: "HomeBikeShopId",
                principalTable: "BikeShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_BikeShops_HomeBikeShopId",
                table: "Bikes");

            migrationBuilder.AlterColumn<int>(
                name: "HomeBikeShopId",
                table: "Bikes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_BikeShops_HomeBikeShopId",
                table: "Bikes",
                column: "HomeBikeShopId",
                principalTable: "BikeShops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
