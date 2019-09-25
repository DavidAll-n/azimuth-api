namespace azimuth_api.Models {
    public class MapTour {
        public int MapId {get;set;}
        public Map Map {get;set;}

        public int TourId {get;set;}
        public Tour Tour {get;set;}
    }
}