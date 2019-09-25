using System.Collections.Generic;
using azimuth_api.Models;

namespace azimuth_api.ViewModels {
    public class MapItemViewModel {
        public MapItemViewModel(MapItem item) {
            Id = item.Id;
            Name = item.Name;
            Polygons = new List<PolygonViewModel>();
            Polylines = new List<PolylineViewModel>();
            FillColor = item.FillColor;
            StrokeColor = item.StrokeColor;
            Keywords = new List<string>();

            if (item.MapItemKeywords != null) {
                foreach(var keyword in item.MapItemKeywords) {
                    Keywords.Add(keyword.Keyword.Word);
                }
            }

            if (item.Polygons != null) {
                foreach (var poly in item.Polygons) {
                    Polygons.Add(new PolygonViewModel(poly));
                }
            }

            if (item.Polylines != null) {
                foreach (var poly in item.Polylines) {
                    Polylines.Add(new PolylineViewModel(poly));
                }
            }
        }
        public int Id {get;set;}
        public string Name {get;set;}
        public bool Visible {get;set;}
        public string FillColor {get;set;}
        public string StrokeColor {get;set;}
        public List<PolygonViewModel> Polygons {get;set;}
        public List<PolylineViewModel> Polylines {get;set;}
        public List<string> Keywords {get;set;}
    }
}