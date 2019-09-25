using System.Collections.Generic;

namespace azimuth_api.Models {
    public class MapItem {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Label {get;set;}
        public bool Visible {get;set;}
        public bool Clickable {get;set;}
        public Coordinate KeyPoint {get;set;}
        public string Summary {get;set;}
        public string PageURL {get;set;}
        public string ImageURL {get;set;}
        public string StrokeColor {get;set;}
        public string FillColor {get;set;}
        public List<Polygon> Polygons {get;set;}
        public List<Polyline> Polylines {get;set;}
        public List<Marker> Markers {get;set;}

        public ICollection<TourMapItem> TourMapItems {get;set;}
        public ICollection<MapItemKeyword> MapItemKeywords {get;set;}
    }
}