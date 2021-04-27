using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShopApi.Migrations
{
    public partial class BikeShops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "BikeShops");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "BikeShops",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
