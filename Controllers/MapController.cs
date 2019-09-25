using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using azimuth_api.Models;
using azimuth_api.ViewModels;

namespace azimuth_api.Controllers {
    
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase {
        private readonly MapContext _context;

        public MapController(MapContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MapViewModel>>> GetMaps() {
            var result = new List<MapViewModel>();
            var maps = await _context.Maps
                .Include(map => map.MapGroups)
                .ThenInclude(group => group.Group)
                .ThenInclude(group => group.MapItems)
                .Include(map => map.MapTours)
                .ThenInclude(tour => tour.Tour)
                .ThenInclude(tour => tour.TourMapItems)
                .ThenInclude(item => item.MapItem)
                .ToListAsync();
            foreach(var map in maps) {
                result.Add(new MapViewModel(map));
            }

            return result;
        }

        [HttpGet]
        [EnableCors("star")]
        [Route("{id}")]
        public async Task<ActionResult<MapViewModel>> GetMap(int id) {
            var result = await _context.Maps
                .Where(map => map.MapId == id)
                .Include(mapp => mapp.MapGroups)
                    .ThenInclude(group => group.Group)
                    .ThenInclude(group => group.MapItems)
                    .ThenInclude(item => item.Polygons)
                    .ThenInclude(poly => poly.Data)
                .Include(mapp => mapp.MapGroups)
                    .ThenInclude(group => group.Group)
                    .ThenInclude(group => group.MapItems)
                    .ThenInclude(item => item.Polylines)
                    .ThenInclude(poly => poly.Data)
                .Include(mapp => mapp.MapGroups)
                    .ThenInclude(group => group.Group)
                    .ThenInclude(group => group.MapItems)
                    .ThenInclude(item => item.MapItemKeywords)
                    .ThenInclude(mapItemKeyword => mapItemKeyword.Keyword)
                .FirstOrDefaultAsync();
            return new MapViewModel(result);
        }
    }
}