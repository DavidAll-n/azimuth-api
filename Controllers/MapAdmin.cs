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
        [Route("create")]
        public IActionResult Create() {
            ViewBag.Title = "New Map";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public async Task<IActionResult> Create([Bind("MapId, Name")] Map map) {
            if (ModelState.IsValid)
            {
                _context.Add(map);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Admin");
            }
            return View(map);
        }
        
        [HttpGet]
        [Route("edit/{id}")]
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }
            
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