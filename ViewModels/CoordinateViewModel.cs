using azimuth_api.Models;

namespace azimuth_api.ViewModels {
    public class CoordinateViewModel {
        public float Lat {get;set;}
        public float Lng {get;set;}

        public CoordinateViewModel(Coordinate coord) {
            Lat = coord.Lat;
            Lng = coord.Lng;
        }
    }
}