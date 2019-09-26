using azimuth_api.Models;

namespace azimuth_api.ViewModels {
    public class CoordinateViewModel {
        public decimal Lat {get;set;}
        public decimal Lng {get;set;}

        public CoordinateViewModel(Coordinate coord) {
            Lat = coord.Lat;
            Lng = coord.Lng;
        }
    }
}