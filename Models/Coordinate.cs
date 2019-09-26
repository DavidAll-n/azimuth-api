using System.ComponentModel.DataAnnotations;

namespace azimuth_api.Models {
    public class Coordinate {
        [Key]
        public long Id {get;set;}
        public decimal Lat {get;set;}
        public decimal Lng {get;set;}
    }
}