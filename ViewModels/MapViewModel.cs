using System.Collections.Generic;
using azimuth_api.Models;

namespace azimuth_api.ViewModels {
    public class MapViewModel {

        public MapViewModel(Map map) {
            Id = map.MapId;
            Name = map.Name;
            Groups = new List<GroupViewModel>();
            Tours = new List<TourViewModel>();
            Items = new Dictionary<int, MapItemViewModel>(); 

            if (map.MapGroups != null) {
                foreach (var mapGroup in map.MapGroups) {
                    Groups.Add(new GroupViewModel(mapGroup.Group));
                    foreach (var item in mapGroup.Group.MapItems) {
                        Items[item.Id] = new MapItemViewModel(item);
                    }
                }
            }
            
            if (map.MapTours != null) {
                foreach (var mapTour in map.MapTours) {
                    Tours.Add(new TourViewModel(mapTour.Tour));
                    foreach (var item in mapTour.Tour.TourMapItems) {
                        Items[item.MapItemId] = new MapItemViewModel(item.MapItem);
                    }
                }
            }
            

        }
        
        public int Id {get;set;}
        public string Name {get;set;}
        
        public ICollection<GroupViewModel> Groups {get;set;}

        public ICollection<TourViewModel> Tours {get;set;}

        public Dictionary<int, MapItemViewModel> Items {get;set;}

    }
}