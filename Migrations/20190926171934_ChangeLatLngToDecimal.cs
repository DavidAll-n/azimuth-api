using Microsoft.EntityFrameworkCore.Migrations;

namespace azimuth_api.Migrations
{
    public partial class ChangeLatLngToDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Lng",
                table: "Coordinate",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<decimal>(
                name: "Lat",
                table: "Coordinate",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61731m, -82.56656m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61711m, -82.56626m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61717m, -82.56619m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61701m, -82.56598m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61672m, -82.56631m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61688m, -82.56652m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61692m, -82.56648m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61695m, -82.56649m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61697m, -82.56647m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61716m, -82.56671m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61726m, -82.56424m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61723m, -82.56419m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61721m, -82.56412m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61716m, -82.56411m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61711m, -82.56408m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61707m, -82.56412m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61702m, -82.56414m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61701m, -82.5642m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61699m, -82.56426m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61702m, -82.56431m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61703m, -82.56437m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61709m, -82.56438m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61713m, -82.56441m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61717m, -82.56437m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61722m, -82.56437m });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61723m, -82.56429m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Lng",
                table: "Coordinate",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "Lat",
                table: "Coordinate",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61731f, -82.56656f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61711f, -82.56626f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61717f, -82.56619f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61701f, -82.56598f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61672f, -82.56631f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61688f, -82.56652f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61692f, -82.56648f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61695f, -82.56649f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61697f, -82.56647f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61716f, -82.56671f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61726f, -82.56424f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61723f, -82.56419f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61721f, -82.56412f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61716f, -82.56411f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61711f, -82.56408f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61707f, -82.56412f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61702f, -82.56414f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61701f, -82.5642f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61699f, -82.56426f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61702f, -82.56431f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61703f, -82.56437f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61709f, -82.56438f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61713f, -82.56441f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61717f, -82.56437f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61722f, -82.56437f });

            migrationBuilder.UpdateData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "Lat", "Lng" },
                values: new object[] { 35.61723f, -82.56429f });
        }
    }
}
