namespace azimuth_api.Models {
    public class MapItemKeyword {
        public int MapItemId {get;set;}
        public MapItem MapItem {get;set;}

        public int KeywordId {get;set;}
        public Keyword Keyword {get;set;}
    }
}