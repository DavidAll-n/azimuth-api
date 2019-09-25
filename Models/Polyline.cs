using System.Collections.Generic;

namespace azimuth_api.Models {
    public class Polyline {
        public int Id {get;set;}
        public List<Coordinate> Data {get;set;}
        public MapItem Item {get;set;}
    }
}