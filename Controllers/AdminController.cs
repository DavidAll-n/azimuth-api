using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using azimuth_api.Models;

namespace azimuth_api {
    [Route("admin")]
    public class AdminController : Controller {

        private readonly MapContext _context;

        public AdminController(MapContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Index() {
            ViewBag.Title = "Maps";
            var mapsList = await _context.Maps.ToListAsync();
            return View(mapsList);
        }
    }
}