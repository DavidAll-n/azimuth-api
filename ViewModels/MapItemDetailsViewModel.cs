using azimuth_api.Models;

namespace azimuth_api.ViewModels {
    public class MapItemDetailsViewModel {
        public string Summary {get;set;}
        public string ImageURL {get;set;}
        public string PageURL {get;set;}

        public MapItemDetailsViewModel(MapItem item) {
            Summary = item.Summary;
            ImageURL = item.ImageURL;
            PageURL = item.PageURL;
        }
    }
}