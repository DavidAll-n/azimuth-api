using System.Collections.Generic;

namespace azimuth_api.Models {
    public class Tour {
        public int TourId {get;set;}
        public string Name {get;set;}
        public ICollection<TourMapItem> TourMapItems {get;set;}
        public ICollection<MapTour> MapTours {get;set;}

    }
}