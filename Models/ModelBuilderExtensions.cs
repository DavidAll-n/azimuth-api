using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace azimuth_api.Models {
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Map>().HasData(
                new Map
                {
                    MapId = 1,
                    Name = "Demo Map"
                }
            );

            modelBuilder.Entity<Group>().HasData(
                new Group { GroupId = 1, Name = "Group 1"},
                new Group { GroupId = 2, Name = "Group 2"}
            );
            modelBuilder.Entity<MapGroup>().HasData(
                new MapGroup { MapId = 1, GroupId = 1 },
                new MapGroup {MapId = 1, GroupId = 2}
            );

            modelBuilder.Entity<MapItem>().HasData(
                new {
                    Id = 1,
                    Name = "Lipinsky Hall",
                    Label = "Lipinsky Hall",
                    Visible = true,
                    Clickable = true,
                    Summary = "Lipinsky Hall is situated on the north corner of the Quad, next to Ramsey Library. Home to the Bob Moog Electronic Music Studio, the building houses the Department of Music and Lipinsky Auditorium, a 580-seat venue for lectures, music and live performances. UNC Asheville's Office of Institutional Research, Effectiveness, and Planning is also located in Lipinsky Hall.",
                    PageURL = "https://maps.unca.edu/campus-map/lipinsky-hall",
                    ImageURL = "https://maps.unca.edu/media/map_images/lipinsky-hall-unca.modal_rep.jpg",
                    StrokeColor = "ffffff",
                    FillColor = "003da5",
                    GroupId = 1
                },
                new {
                    Id = 2,
                    Name = "Mullen & James Humanities Hall",
                    Label = "Mullen & James Humanities Hall",
                    Visible = true,
                    Clickable = true,
                    Summary = "*Fall 2019: Under construction*\nMullen & James Humanities Hall, adjoining Carmichael Hall, seats 330 in a semicircular auditorium-style arrangement for humanities lectures and special events. Its unusual pleated roof lines may be seen from the entrance to UNC Asheville on University Heights. Mullen & James Humanities Hall was renovated and updated in 2013.",
                    PageURL = "https://maps.unca.edu/campus-map/lipinsky-hall",
                    ImageURL = "https://maps.unca.edu/media/map_images/lipinsky-hall-unca.modal_rep.jpg",
                    StrokeColor = "ffffff",
                    FillColor = "003da5",
                    GroupId = 2
                }
            );

            modelBuilder.Entity<Keyword>().HasData(
                new Keyword {
                    Id = 1,
                    Word = "Music"
                },
                new Keyword {
                    Id = 2,
                    Word = "Moog"
                },
                new Keyword {
                    Id = 3,
                    Word = "Lecture"
                },
                new Keyword {
                    Id = 4,
                    Word = "Construction"
                }
            );

            modelBuilder.Entity<MapItemKeyword>().HasData(
                new MapItemKeyword {
                    KeywordId = 1,
                    MapItemId = 1
                },
                new MapItemKeyword {
                    KeywordId = 2,
                    MapItemId = 1
                },
                new MapItemKeyword {
                    KeywordId = 3,
                    MapItemId = 2
                },
                new MapItemKeyword {
                    KeywordId = 4,
                    MapItemId = 2
                }
            );

            modelBuilder.Entity<Polygon>().HasData(
                new {
                    Id = 1,
                    ItemId = 1
                },
                new {
                    Id = 2,
                    ItemId = 2
                }
            );

            modelBuilder.Entity<Coordinate>().HasData(
                new {
                    Id = 1L,
                    Lat = 35.61731f,
                    Lng = -82.56656f,
                    PolygonId = 1,
                    MapItemId = 1
                },
                new {
                    Id = 2L,
                    Lat = 35.61711f,
                    Lng = -82.56626f,
                    PolygonId = 1
                },
                new {
                    Id = 3L,
                    Lat = 35.61717f,
                    Lng = -82.56619f,
                    PolygonId = 1
                },
                new {
                    Id = 4L,
                    Lat = 35.61701f,
                    Lng = -82.56598f,
                    PolygonId = 1
                },
                new {
                    Id = 5L,
                    Lat = 35.61672f,
                    Lng = -82.56631f,
                    PolygonId = 1
                },
                new {
                    Id = 6L,
                    Lat = 35.61688f,
                    Lng = -82.56652f,
                    PolygonId = 1
                },
                new {
                    Id = 7L,
                    Lat = 35.61692f,
                    Lng = -82.56648f,
                    PolygonId = 1
                },
                new {
                    Id = 8L,
                    Lat = 35.61695f,
                    Lng = -82.56649f,
                    PolygonId = 1
                },
                new {
                    Id = 9L,
                    Lat = 35.61697f,
                    Lng = -82.56647f,
                    PolygonId = 1
                },
                new {
                    Id = 10L,
                    Lat = 35.61716f,
                    Lng = -82.56671f,
                    PolygonId = 1
                },
                new {
                    Id = 11L,
                    Lat = 35.61726f,
                    Lng = -82.56424f,
                    PolygonId = 2
                },
                new {
                    Id = 12L,
                    Lat = 35.61723f,
                    Lng = -82.56419f,
                    PolygonId = 2,
                    MapItemId = 2
                },
                new {
                    Id = 13L,
                    Lat = 35.61721f,
                    Lng = -82.56412f,
                    PolygonId = 2
                },
                new {
                    Id = 14L,
                    Lat = 35.61716f,
                    Lng = -82.56411f,
                    PolygonId = 2
                },
                new {
                    Id = 15L,
                    Lat = 35.61711f,
                    Lng = -82.56408f,
                    PolygonId = 2
                },
                new {
                    Id = 16L,
                    Lat = 35.61707f,
                    Lng = -82.56412f,
                    PolygonId = 2
                },
                new {
                    Id = 17L,
                    Lat = 35.61702f,
                    Lng = -82.56414f,
                    PolygonId = 2
                },
                new {
                    Id = 18L,
                    Lat = 35.61701f,
                    Lng = -82.5642f,
                    PolygonId = 2
                },
                new {
                    Id = 19L,
                    Lat = 35.61699f,
                    Lng = -82.56426f,
                    PolygonId = 2
                },
                new {
                    Id = 20L,
                    Lat = 35.61702f,
                    Lng = -82.56431f,
                    PolygonId = 2
                },
                new {
                    Id = 21L,
                    Lat = 35.61703f,
                    Lng = -82.56437f,
                    PolygonId = 2
                },
                new {
                    Id = 22L,
                    Lat = 35.61709f,
                    Lng = -82.56438f,
                    PolygonId = 2
                },
                new {
                    Id = 23L,
                    Lat = 35.61713f,
                    Lng = -82.56441f,
                    PolygonId = 2
                },
                new {
                    Id = 24L,
                    Lat = 35.61717f,
                    Lng = -82.56437f,
                    PolygonId = 2
                },
                new {
                    Id = 25L,
                    Lat = 35.61722f,
                    Lng = -82.56437f,
                    PolygonId = 2
                },
                new {
                    Id = 26L,
                    Lat = 35.61723f,
                    Lng = -82.56429f,
                    PolygonId = 2
                }
            );
        }
    }
}