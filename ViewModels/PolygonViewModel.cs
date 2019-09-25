using System.Collections.Generic;
using azimuth_api.Models;
using System.Linq;

namespace azimuth_api.ViewModels {
    public class PolygonViewModel {

        public PolygonViewModel(Polygon poly) {
            Id = poly.Id;
            Data = new List<CoordinateViewModel>();

            if (poly.Data != null) {
                foreach (var coord in poly.Data) {
                    Data.Add(new CoordinateViewModel(coord));
                }
            }
        }

        public int Id {get;set;}
        public ICollection<CoordinateViewModel> Data {get;set;}
    }
}