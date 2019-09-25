using System.Collections.Generic;
using azimuth_api.Models;

namespace azimuth_api.ViewModels {
    public class GroupViewModel {
        public GroupViewModel(Group group) {
            Id = group.GroupId;
            Name = group.Name;
            Visible = group.Visible;
            Items = new List<int>();

            foreach (var item in group.MapItems) {
                Items.Add(item.Id);
            }
        }
        public int Id {get;set;}
        public string Name {get;set;}
        public bool Visible {get;set;}

        public ICollection<int> Items {get;set;}
    }
}