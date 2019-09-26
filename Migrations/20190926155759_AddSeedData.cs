using Microsoft.EntityFrameworkCore.Migrations;

namespace azimuth_api.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name", "Visible" },
                values: new object[,]
                {
                    { 1, "Group 1", false },
                    { 2, "Group 2", false }
                });

            migrationBuilder.InsertData(
                table: "Keyword",
                columns: new[] { "Id", "Word" },
                values: new object[,]
                {
                    { 1, "Music" },
                    { 2, "Moog" },
                    { 3, "Lecture" },
                    { 4, "Construction" }
                });

            migrationBuilder.InsertData(
                table: "MapItems",
                columns: new[] { "Id", "Clickable", "FillColor", "GroupId", "ImageURL", "KeyPointId", "Label", "Name", "PageURL", "StrokeColor", "Summary", "Visible" },
                values: new object[,]
                {
                    { 1, true, "003da5", null, "https://maps.unca.edu/media/map_images/lipinsky-hall-unca.modal_rep.jpg", null, "Lipinsky Hall", "Lipinsky Hall", "https://maps.unca.edu/campus-map/lipinsky-hall", "ffffff", "Lipinsky Hall is situated on the north corner of the Quad, next to Ramsey Library. Home to the Bob Moog Electronic Music Studio, the building houses the Department of Music and Lipinsky Auditorium, a 580-seat venue for lectures, music and live performances. UNC Asheville's Office of Institutional Research, Effectiveness, and Planning is also located in Lipinsky Hall.", true },
                    { 2, true, "003da5", null, "https://maps.unca.edu/media/map_images/lipinsky-hall-unca.modal_rep.jpg", null, "Mullen & James Humanities Hall", "Mullen & James Humanities Hall", "https://maps.unca.edu/campus-map/lipinsky-hall", "ffffff", @"*Fall 2019: Under construction*
                Mullen & James Humanities Hall, adjoining Carmichael Hall, seats 330 in a semicircular auditorium-style arrangement for humanities lectures and special events. Its unusual pleated roof lines may be seen from the entrance to UNC Asheville on University Heights. Mullen & James Humanities Hall was renovated and updated in 2013.", true }
                });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "MapId", "Name" },
                values: new object[] { 1, "Demo Map" });

            migrationBuilder.InsertData(
                table: "MapGroup",
                columns: new[] { "GroupId", "MapId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "MapItemKeyword",
                columns: new[] { "KeywordId", "MapItemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Polygon",
                columns: new[] { "Id", "ItemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Coordinate",
                columns: new[] { "Id", "Lat", "Lng", "PolygonId", "PolylineId" },
                values: new object[,]
                {
                    { 1L, 35.61731f, -82.56656f, 1, null },
                    { 24L, 35.61717f, -82.56437f, 2, null },
                    { 23L, 35.61713f, -82.56441f, 2, null },
                    { 22L, 35.61709f, -82.56438f, 2, null },
                    { 21L, 35.61703f, -82.56437f, 2, null },
                    { 20L, 35.61702f, -82.56431f, 2, null },
                    { 19L, 35.61699f, -82.56426f, 2, null },
                    { 18L, 35.61701f, -82.5642f, 2, null },
                    { 17L, 35.61702f, -82.56414f, 2, null },
                    { 16L, 35.61707f, -82.56412f, 2, null },
                    { 15L, 35.61711f, -82.56408f, 2, null },
                    { 14L, 35.61716f, -82.56411f, 2, null },
                    { 13L, 35.61721f, -82.56412f, 2, null },
                    { 12L, 35.61723f, -82.56419f, 2, null },
                    { 11L, 35.61726f, -82.56424f, 2, null },
                    { 10L, 35.61716f, -82.56671f, 1, null },
                    { 9L, 35.61697f, -82.56647f, 1, null },
                    { 8L, 35.61695f, -82.56649f, 1, null },
                    { 7L, 35.61692f, -82.56648f, 1, null },
                    { 6L, 35.61688f, -82.56652f, 1, null },
                    { 5L, 35.61672f, -82.56631f, 1, null },
                    { 4L, 35.61701f, -82.56598f, 1, null },
                    { 3L, 35.61717f, -82.56619f, 1, null },
                    { 2L, 35.61711f, -82.56626f, 1, null },
                    { 25L, 35.61722f, -82.56437f, 2, null },
                    { 26L, 35.61723f, -82.56429f, 2, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Coordinate",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "MapGroup",
                keyColumns: new[] { "GroupId", "MapId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MapGroup",
                keyColumns: new[] { "GroupId", "MapId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MapItemKeyword",
                keyColumns: new[] { "KeywordId", "MapItemId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MapItemKeyword",
                keyColumns: new[] { "KeywordId", "MapItemId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MapItemKeyword",
                keyColumns: new[] { "KeywordId", "MapItemId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MapItemKeyword",
                keyColumns: new[] { "KeywordId", "MapItemId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Keyword",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Maps",
                keyColumn: "MapId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Polygon",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Polygon",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MapItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MapItems",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
