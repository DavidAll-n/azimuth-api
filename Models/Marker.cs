namespace azimuth_api.Models {
    public class Marker {
        public int Id {get;set;}
        public Coordinate Data {get;set;}
        public string Icon {get;set;}
        public MapItem Item {get;set;}
    }
}