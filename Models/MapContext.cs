using Microsoft.EntityFrameworkCore;

namespace azimuth_api.Models {
    public class MapContext : DbContext {
        public MapContext (DbContextOptions<MapContext> options) : base(options) {

        }

        public DbSet<Map> Maps {get;set;}
        public DbSet<Group> Groups {get;set;}
        public DbSet<MapItem> MapItems {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
            // Map Group Many-To-Many
            modelBuilder.Entity<MapGroup>()
                .HasKey(mapGroup => new { mapGroup.GroupId, mapGroup.MapId });

            modelBuilder.Entity<MapGroup>()
                .HasOne(mapGroup => mapGroup.Map)
                .WithMany(map => map.MapGroups)
                .HasForeignKey(mapGroup => mapGroup.MapId);

            modelBuilder.Entity<MapGroup>()
                .HasOne(mapGroup => mapGroup.Group)
                .WithMany(group => group.MapGroups)
                .HasForeignKey(mapGroup => mapGroup.GroupId);

            // Map Tour Many-To-Many
            modelBuilder.Entity<MapTour>()
                .HasKey(mapTour => new { mapTour.TourId, mapTour.MapId });

            modelBuilder.Entity<MapTour>()
                .HasOne(mapTour => mapTour.Map)
                .WithMany(map => map.MapTours)
                .HasForeignKey(mapTour => mapTour.MapId);

            modelBuilder.Entity<MapTour>()
                .HasOne(mapTour => mapTour.Tour)
                .WithMany(tour => tour.MapTours)
                .HasForeignKey(mapTour => mapTour.TourId);

            // Tour MapItem Many-To-Many
            modelBuilder.Entity<TourMapItem>()
                .HasKey(tourMapItem => new { tourMapItem.TourId, tourMapItem.MapItemId });

            modelBuilder.Entity<TourMapItem>()
                .HasOne(tourMapItem => tourMapItem.Tour)
                .WithMany(tour => tour.TourMapItems)
                .HasForeignKey(tourMapItem => tourMapItem.TourId);

            modelBuilder.Entity<TourMapItem>()
                .HasOne(tourMapItem => tourMapItem.MapItem)
                .WithMany(item => item.TourMapItems)
                .HasForeignKey(tourMapItem => tourMapItem.MapItemId);
            
            // Keyword MapItem Many-To-Many
            modelBuilder.Entity<MapItemKeyword>()
                .HasKey(mapItemKeyword => new { mapItemKeyword.KeywordId, mapItemKeyword.MapItemId });
            
            modelBuilder.Entity<MapItemKeyword>()
                .HasOne(mapItemKeyword => mapItemKeyword.Keyword)
                .WithMany( keyword => keyword.MapItemKeywords )
                .HasForeignKey(mapItemKeyword => mapItemKeyword.KeywordId);

            modelBuilder.Entity<MapItemKeyword>()
                .HasOne(mapItemKeyword => mapItemKeyword.MapItem)
                .WithMany( item => item.MapItemKeywords )
                .HasForeignKey(mapItemKeyword => mapItemKeyword.MapItemId);
        }
    }
}