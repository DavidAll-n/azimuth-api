using System.Collections.Generic;

namespace azimuth_api.Models {
    public class Map {
        public int MapId {get;set;}
        public string Name {get;set;}
        public ICollection<MapGroup> MapGroups {get;set;}
        public ICollection<MapTour> MapTours {get;set;}
    }
}