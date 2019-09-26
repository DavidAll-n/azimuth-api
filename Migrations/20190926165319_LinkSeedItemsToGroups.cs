using Microsoft.EntityFrameworkCore.Migrations;

namespace azimuth_api.Migrations
{
    public partial class LinkSeedItemsToGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "GroupId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupId",
                value: null);

            migrationBuilder.UpdateData(
                table: "MapItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "GroupId",
                value: null);
        }
    }
}
