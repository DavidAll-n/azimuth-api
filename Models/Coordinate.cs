using System.ComponentModel.DataAnnotations;

namespace azimuth_api.Models {
    public class Coordinate {
        [Key]
        public long Id {get;set;}
        public float Lat {get;set;}
        public float Lng {get;set;}
    }
}