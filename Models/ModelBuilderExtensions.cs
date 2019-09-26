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
                    Lat = 35.61731M,
                    Lng = -82.56656M,
                    PolygonId = 1,
                    MapItemId = 1
                },
                new {
                    Id = 2L,
                    Lat = 35.61711M,
                    Lng = -82.56626M,
                    PolygonId = 1
                },
                new {
                    Id = 3L,
                    Lat = 35.61717M,
                    Lng = -82.56619M,
                    PolygonId = 1
                },
                new {
                    Id = 4L,
                    Lat = 35.61701M,
                    Lng = -82.56598M,
                    PolygonId = 1
                },
                new {
                    Id = 5L,
                    Lat = 35.61672M,
                    Lng = -82.56631M,
                    PolygonId = 1
                },
                new {
                    Id = 6L,
                    Lat = 35.61688M,
                    Lng = -82.56652M,
                    PolygonId = 1
                },
                new {
                    Id = 7L,
                    Lat = 35.61692M,
                    Lng = -82.56648M,
                    PolygonId = 1
                },
                new {
                    Id = 8L,
                    Lat = 35.61695M,
                    Lng = -82.56649M,
                    PolygonId = 1
                },
                new {
                    Id = 9L,
                    Lat = 35.61697M,
                    Lng = -82.56647M,
                    PolygonId = 1
                },
                new {
                    Id = 10L,
                    Lat = 35.61716M,
                    Lng = -82.56671M,
                    PolygonId = 1
                },
                new {
                    Id = 11L,
                    Lat = 35.61726M,
                    Lng = -82.56424M,
                    PolygonId = 2
                },
                new {
                    Id = 12L,
                    Lat = 35.61723M,
                    Lng = -82.56419M,
                    PolygonId = 2,
                    MapItemId = 2
                },
                new {
                    Id = 13L,
                    Lat = 35.61721M,
                    Lng = -82.56412M,
                    PolygonId = 2
                },
                new {
                    Id = 14L,
                    Lat = 35.61716M,
                    Lng = -82.56411M,
                    PolygonId = 2
                },
                new {
                    Id = 15L,
                    Lat = 35.61711M,
                    Lng = -82.56408M,
                    PolygonId = 2
                },
                new {
                    Id = 16L,
                    Lat = 35.61707M,
                    Lng = -82.56412M,
                    PolygonId = 2
                },
                new {
                    Id = 17L,
                    Lat = 35.61702M,
                    Lng = -82.56414M,
                    PolygonId = 2
                },
                new {
                    Id = 18L,
                    Lat = 35.61701M,
                    Lng = -82.5642M,
                    PolygonId = 2
                },
                new {
                    Id = 19L,
                    Lat = 35.61699M,
                    Lng = -82.56426M,
                    PolygonId = 2
                },
                new {
                    Id = 20L,
                    Lat = 35.61702M,
                    Lng = -82.56431M,
                    PolygonId = 2
                },
                new {
                    Id = 21L,
                    Lat = 35.61703M,
                    Lng = -82.56437M,
                    PolygonId = 2
                },
                new {
                    Id = 22L,
                    Lat = 35.61709M,
                    Lng = -82.56438M,
                    PolygonId = 2
                },
                new {
                    Id = 23L,
                    Lat = 35.61713M,
                    Lng = -82.56441M,
                    PolygonId = 2
                },
                new {
                    Id = 24L,
                    Lat = 35.61717M,
                    Lng = -82.56437M,
                    PolygonId = 2
                },
                new {
                    Id = 25L,
                    Lat = 35.61722M,
                    Lng = -82.56437M,
                    PolygonId = 2
                },
                new {
                    Id = 26L,
                    Lat = 35.61723M,
                    Lng = -82.56429M,
                    PolygonId = 2
                }
            );
        }
    }
}