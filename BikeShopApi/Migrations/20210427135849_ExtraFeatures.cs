using Microsoft.EntityFrameworkCore.Migrations;

namespace BikeShopApi.Migrations
{
    public partial class ExtraFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bikes_ExtraFeatures_ExtraFeatureId",
                table: "Bikes");

            migrationBuilder.DropIndex(
                name: "IX_Bikes_ExtraFeatureId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "ExtraFeatureId",
                table: "Bikes");

            migrationBuilder.DropColumn(
                name: "ExtraFeaturesId",
                table: "Bikes");

            migrationBuilder.CreateTable(
                name: "BikeExtraFeature",
                columns: table => new
                {
                    BikesId = table.Column<int>(type: "int", nullable: false),
                    ExtraFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeExtraFeature", x => new { x.BikesId, x.ExtraFeaturesId });
                    table.ForeignKey(
                        name: "FK_BikeExtraFeature_Bikes_BikesId",
                        column: x => x.BikesId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BikeExtraFeature_ExtraFeatures_ExtraFeaturesId",
                        column: x => x.ExtraFeaturesId,
                        principalTable: "ExtraFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BikeExtraFeature_ExtraFeaturesId",
                table: "BikeExtraFeature",
                column: "ExtraFeaturesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BikeExtraFeature");

            migrationBuilder.AddColumn<int>(
                name: "ExtraFeatureId",
                table: "Bikes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExtraFeaturesId",
                table: "Bikes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bikes_ExtraFeatureId",
                table: "Bikes",
                column: "ExtraFeatureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bikes_ExtraFeatures_ExtraFeatureId",
                table: "Bikes",
                column: "ExtraFeatureId",
                principalTable: "ExtraFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
