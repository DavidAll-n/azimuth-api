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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
                        .Annotation("Sqlite:Autoincrement", true),
                    Lat = table.Column<float>(nullable: false),
                    Lng = table.Column<float>(nullable: false),
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
                        .Annotation("Sqlite:Autoincrement", true),
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
