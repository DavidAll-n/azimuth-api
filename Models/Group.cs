using System.Collections.Generic;

namespace azimuth_api.Models {
    public class Group {
        public int GroupId {get;set;}
        public string Name {get;set;}
        public bool Visible {get;set;}
        public ICollection<MapItem> MapItems {get;set;}
        public ICollection<MapGroup> MapGroups {get;set;}
    }
}