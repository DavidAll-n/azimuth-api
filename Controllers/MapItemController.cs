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
    public class MapItemController : ControllerBase {
        private readonly MapContext _context;

        public MapItemController(MapContext context) {
            _context = context;
        }

        [HttpGet]
        [EnableCors("star")]
        [Route("details/{id}")]
        public async Task<ActionResult<MapItemDetailsViewModel>> GetMapItemDetails(int id) {
            var result = await _context.MapItems
                // .Select(s => new {
                //     Summary = s.Summary,
                //     PageUrl = s.PageURL,
                //     ImageUrl = s.ImageURL,
                //     Id = s.Id
                // })
                .Where(item => item.Id == id)
                .FirstOrDefaultAsync();
            return new MapItemDetailsViewModel(result);
        }
    }
}