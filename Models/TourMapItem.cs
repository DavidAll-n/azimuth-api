namespace azimuth_api.Models {
    public class TourMapItem {
        public int TourId {get;set;}
        public Tour Tour {get;set;}

        public int MapItemId {get;set;}
        public MapItem MapItem {get;set;}

        public int Order {get;set;}
    }
}