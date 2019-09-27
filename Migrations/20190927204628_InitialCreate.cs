using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace azimuth_api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Visible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Keyword",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Word = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    MapId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.MapId);
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.TourId);
                });

            migrationBuilder.CreateTable(
                name: "MapGroup",
                columns: table => new
                {
                    MapId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapGroup", x => new { x.GroupId, x.MapId });
                    table.ForeignKey(
                        name: "FK_MapGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapGroup_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "MapId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapTour",
                columns: table => new
                {
                    MapId = table.Column<int>(nullable: false),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapTour", x => new { x.TourId, x.MapId });
                    table.ForeignKey(
                        name: "FK_MapTour_Maps_MapId",
                        column: x => x.MapId,
                        principalTable: "Maps",
                        principalColumn: "MapId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapTour_Tour_TourId",
                        column: x => x.TourId,
                        principalTable: "Tour",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MapItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true),
                    Visible = table.Column<bool>(nullable: false),
                    Clickable = table.Column<bool>(nullable: false),
                    KeyPointId = table.Column<long>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    PageURL = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    StrokeColor = table.Column<string>(nullable: true),
                    FillColor = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MapItems_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MapItemKeyword",
                columns: table => new
                {
                    MapItemId = table.Column<int>(nullable: false),
                    KeywordId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapItemKeyword", x => new { x.KeywordId, x.MapItemId });
                    table.ForeignKey(
                        name: "FK_MapItemKeyword_Keyword_KeywordId",
                        column: x => x.KeywordId,
                        principalTable: "Keyword",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MapItemKeyword_MapItems_MapItemId",
                        column: x => x.MapItemId,
                        principalTable: "MapItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Polygon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polygon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polygon_MapItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "MapItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Polyline",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polyline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polyline_MapItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "MapItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TourMapItem",
                columns: table => new
                {
                    TourId = table.Column<int>(nullable: false),
                    MapItemId = table.Column<int>(nullable: false),
                    Order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourMapItem", x => new { x.TourId, x.MapItemId });
                    table.ForeignKey(
                        name: "FK_TourMapItem_MapItems_MapItemId",
                        column: x => x.MapItemId,
                        principalTable: "MapItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourMapItem_Tour_TourId",
                        column: x => x.TourId,
                        principalTable: "Tour",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coordinate",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Lat = table.Column<decimal>(nullable: false),
                    Lng = table.Column<decimal>(nullable: false),
                    PolygonId = table.Column<int>(nullable: true),
                    PolylineId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coordinate_Polygon_PolygonId",
                        column: x => x.PolygonId,
                        principalTable: "Polygon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Coordinate_Polyline_PolylineId",
                        column: x => x.PolylineId,
                        principalTable: "Polyline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataId = table.Column<long>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    ItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marker", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marker_Coordinate_DataId",
                        column: x => x.DataId,
                        principalTable: "Coordinate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Marker_MapItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "MapItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                table: "MapItems",
                columns: new[] { "Id", "Clickable", "FillColor", "GroupId", "ImageURL", "KeyPointId", "Label", "Name", "PageURL", "StrokeColor", "Summary", "Visible" },
                values: new object[,]
                {
                    { 1, true, "003da5", 1, "https://maps.unca.edu/media/map_images/lipinsky-hall-unca.modal_rep.jpg", null, "Lipinsky Hall", "Lipinsky Hall", "https://maps.unca.edu/campus-map/lipinsky-hall", "ffffff", "Lipinsky Hall is situated on the north corner of the Quad, next to Ramsey Library. Home to the Bob Moog Electronic Music Studio, the building houses the Department of Music and Lipinsky Auditorium, a 580-seat venue for lectures, music and live performances. UNC Asheville's Office of Institutional Research, Effectiveness, and Planning is also located in Lipinsky Hall.", true },
                    { 2, true, "003da5", 2, "https://maps.unca.edu/media/map_images/lipinsky-hall-unca.modal_rep.jpg", null, "Mullen & James Humanities Hall", "Mullen & James Humanities Hall", "https://maps.unca.edu/campus-map/lipinsky-hall", "ffffff", @"*Fall 2019: Under construction*
                Mullen & James Humanities Hall, adjoining Carmichael Hall, seats 330 in a semicircular auditorium-style arrangement for humanities lectures and special events. Its unusual pleated roof lines may be seen from the entrance to UNC Asheville on University Heights. Mullen & James Humanities Hall was renovated and updated in 2013.", true }
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
                    { 1L, 35.61731m, -82.56656m, 1, null },
                    { 24L, 35.61717m, -82.56437m, 2, null },
                    { 23L, 35.61713m, -82.56441m, 2, null },
                    { 22L, 35.61709m, -82.56438m, 2, null },
                    { 21L, 35.61703m, -82.56437m, 2, null },
                    { 20L, 35.61702m, -82.56431m, 2, null },
                    { 19L, 35.61699m, -82.56426m, 2, null },
                    { 18L, 35.61701m, -82.5642m, 2, null },
                    { 17L, 35.61702m, -82.56414m, 2, null },
                    { 16L, 35.61707m, -82.56412m, 2, null },
                    { 15L, 35.61711m, -82.56408m, 2, null },
                    { 14L, 35.61716m, -82.56411m, 2, null },
                    { 13L, 35.61721m, -82.56412m, 2, null },
                    { 12L, 35.61723m, -82.56419m, 2, null },
                    { 11L, 35.61726m, -82.56424m, 2, null },
                    { 10L, 35.61716m, -82.56671m, 1, null },
                    { 9L, 35.61697m, -82.56647m, 1, null },
                    { 8L, 35.61695m, -82.56649m, 1, null },
                    { 7L, 35.61692m, -82.56648m, 1, null },
                    { 6L, 35.61688m, -82.56652m, 1, null },
                    { 5L, 35.61672m, -82.56631m, 1, null },
                    { 4L, 35.61701m, -82.56598m, 1, null },
                    { 3L, 35.61717m, -82.56619m, 1, null },
                    { 2L, 35.61711m, -82.56626m, 1, null },
                    { 25L, 35.61722m, -82.56437m, 2, null },
                    { 26L, 35.61723m, -82.56429m, 2, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coordinate_PolygonId",
                table: "Coordinate",
                column: "PolygonId");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinate_PolylineId",
                table: "Coordinate",
                column: "PolylineId");

            migrationBuilder.CreateIndex(
                name: "IX_MapGroup_MapId",
                table: "MapGroup",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_MapItemKeyword_MapItemId",
                table: "MapItemKeyword",
                column: "MapItemId");

            migrationBuilder.CreateIndex(
                name: "IX_MapItems_GroupId",
                table: "MapItems",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MapItems_KeyPointId",
                table: "MapItems",
                column: "KeyPointId");

            migrationBuilder.CreateIndex(
                name: "IX_MapTour_MapId",
                table: "MapTour",
                column: "MapId");

            migrationBuilder.CreateIndex(
                name: "IX_Marker_DataId",
                table: "Marker",
                column: "DataId");

            migrationBuilder.CreateIndex(
                name: "IX_Marker_ItemId",
                table: "Marker",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Polygon_ItemId",
                table: "Polygon",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Polyline_ItemId",
                table: "Polyline",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TourMapItem_MapItemId",
                table: "TourMapItem",
                column: "MapItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_MapItems_Coordinate_KeyPointId",
                table: "MapItems",
                column: "KeyPointId",
                principalTable: "Coordinate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordinate_Polygon_PolygonId",
                table: "Coordinate");

            migrationBuilder.DropForeignKey(
                name: "FK_Coordinate_Polyline_PolylineId",
                table: "Coordinate");

            migrationBuilder.DropTable(
                name: "MapGroup");

            migrationBuilder.DropTable(
                name: "MapItemKeyword");

            migrationBuilder.DropTable(
                name: "MapTour");

            migrationBuilder.DropTable(
                name: "Marker");

            migrationBuilder.DropTable(
                name: "TourMapItem");

            migrationBuilder.DropTable(
                name: "Keyword");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "Polygon");

            migrationBuilder.DropTable(
                name: "Polyline");

            migrationBuilder.DropTable(
                name: "MapItems");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Coordinate");
        }
    }
}
