using InlandMarinaData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace InlandMarina.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/[action]/")]
    public class HomeController : Controller
    {
        private readonly InlandMarinaContext _context;

        public HomeController(InlandMarinaContext context)
        {
            _context = context;
        }

        [Route("/Admin/Create")]
        public IActionResult Create()
        {
            if (!User.IsInRole("Admin")) return RedirectToAction("Index", "Home", new { area = "" });
            ViewData["DockID"] = new SelectList(_context.Docks, "ID", "Name");
            return View("Areas/Admin/Views/Home/Create.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slip slip)
        {
            if (!User.IsInRole("Admin")) return RedirectToAction("Index", "Home", new { area = "" });

            var newSlip = new Slip()
            {
                Width = slip.Width,
                Length = slip.Length,
                DockID = slip.DockID,
            };

            var dock = _context.Docks.Where(d => d.ID == slip.DockID).Include(d => d.Slips).FirstOrDefault();

            newSlip.Dock = dock;

            if (ModelState.IsValid)
            {
                dock.Slips.Add(newSlip);
                _context.Slips.Add(slip);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Slips", new { area = "" });
            }

            ViewData["DockID"] = new SelectList(_context.Docks, "ID", "Name", slip.DockID);
            return View("Areas/Admin/Views/Home/Create.cshtml", slip);
        }

        [Route("/Admin/Edit/{id?}")]
        public async Task<IActionResult> Edit(int? id = 0)
        {
            if (!User.IsInRole("Admin")) return RedirectToAction("Index", "Home", new { area = "" });
            if (id == null)
            {
                return NotFound();
            }

            var slip = await _context.Slips.FindAsync(id);
            if (slip == null)
            {
                return NotFound();
            }
            ViewData["DockID"] = new SelectList(_context.Docks, "ID", "Name", slip.DockID);
            return View("Areas/Admin/Views/Home/Edit.cshtml", slip);
        }

        [HttpPost]
        [Route("/Admin/Home/Edit/{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Width,Length,DockID")] Slip slip)
        {
            if (!User.IsInRole("Admin")) return RedirectToAction("Index", "Home", new { area = "" });
            if (id != slip.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlipExists(slip.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Slips", new { area="" });
            }
            ViewData["DockID"] = new SelectList(_context.Docks, "ID", "Name", slip.DockID);
            return View("Areas/Admin/Views/Home/Edit.cshtml", slip);
        }

        [Route("/Admin/Delete/{id?}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (!User.IsInRole("Admin")) return RedirectToAction("Index", "Home", new { area = "" });
            if (id == null)
            {
                return NotFound();
            }

            var slip = await _context.Slips
                .Include(s => s.Dock)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (slip == null)
            {
                return NotFound();
            }

            return View("Areas/Admin/Views/Home/Delete.cshtml", slip);
        }

        [HttpPost]
        [Route("/Admin/Home/DeleteConfirmed/{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!User.IsInRole("Admin")) return RedirectToAction("Index", "Home", new { area = "" });

            var slip = await _context.Slips.FindAsync(id);
            var dock = _context.Docks.Where(d => d.ID == slip.DockID).Include(d => d.Slips).FirstOrDefault();
            if (slip != null)
            {
                dock.Slips.Remove(slip);
                _context.Slips.Remove(slip);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Slips", new { area="" });
        }

        private bool SlipExists(int id)
        {
            return _context.Slips.Any(e => e.ID == id);
        }
    }
}
