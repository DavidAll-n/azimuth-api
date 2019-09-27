using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using azimuth_api.Models;

namespace azimuth_api {
    [Route("admin/map")]
    public class MapAdminController : Controller {

        private readonly MapContext _context;

        public MapAdminController(MapContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        [Route("edit/{id}")]
        public async Task<IActionResult> Edit(int id) {
            ViewBag.Title = "Maps";
            var map = await _context.Maps.FindAsync(id);

            if (map == null) {
                return NotFound();
            }

            return View(map);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit/{id}")]
        public async Task<ActionResult> PostEdit(int id, [Bind("MapId,Name")] Map map) {
            if (id != map.MapId) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(map);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!MapExists(map.MapId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index","Admin");
            }
            return View(map);
        }

        private bool MapExists(int id)
        {
            return _context.Maps.Any(e => e.MapId == id);
        }
    }
}