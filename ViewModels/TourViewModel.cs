using System.Collections.Generic;
using azimuth_api.Models;
using System.Linq;

namespace azimuth_api.ViewModels {
    public class TourViewModel {
        public TourViewModel(Tour tour) {
            Id = tour.TourId;
            Name = tour.Name;
            Items = new List<int>();

            foreach (var tourMapItems in tour.TourMapItems.OrderBy(ord => ord.Order)) {
                Items.Add(tourMapItems.MapItemId);
            }
        }
        public int Id {get;set;}
        public string Name {get;set;}

        public ICollection<int> Items {get;set;}
    }
}