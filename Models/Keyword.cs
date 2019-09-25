using System.Collections.Generic;

namespace azimuth_api.Models {
    public class Keyword {
        public int Id {get;set;}
        public string Word {get;set;}

        public ICollection<MapItemKeyword> MapItemKeywords {get;set;}
    }
}