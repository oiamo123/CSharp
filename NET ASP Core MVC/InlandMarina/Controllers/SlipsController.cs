using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InlandMarinaData;

namespace InlandMarina.Controllers
{
    public class SlipsController : Controller
    {
        private readonly InlandMarinaContext _context;

        public SlipsController(InlandMarinaContext context)
        {
            _context = context;
        }

        // For /Slips
        public IActionResult Index(int id = 1, int filter = 0)
        {
            var inlandMarinaContext = _context.Slips.Include(s => s.Dock).Include(s => s.Leases).Where(s => s.DockID == id);

            var numDocks = _context.Docks.Count();

            if (filter == 1)
            {
               inlandMarinaContext = inlandMarinaContext.OrderByDescending(s => s.Length);
            }
            else if (filter == 2)
            {
                inlandMarinaContext = inlandMarinaContext.OrderBy(s => s.Length);
            }
            else if (filter == 3)
            {
                inlandMarinaContext = inlandMarinaContext.OrderByDescending(s => s.Width);
            }
            else if (filter == 4)
            {
                inlandMarinaContext = inlandMarinaContext.OrderBy(s => s.Width);
            }

            ViewBag.DockID = id;
            ViewBag.CurrentFilter = filter;
            ViewBag.numDocks = numDocks;

            List<Slip> availableSlips = new List<Slip>();
            foreach (var item in inlandMarinaContext.ToList())
            {
                if (item.isAvailable)
                {
                    availableSlips.Add(item);
                }
            }

            return View(!User.IsInRole("Admin") ? availableSlips: inlandMarinaContext.ToList());
        }

        // For Slips/Details/{id}
        public async Task<IActionResult> Details(int? id)
        {
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");

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

            return View(slip);
        }

        public IActionResult AddSlip(int? id)
        {
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");

            if (id == null)
            {
                return NotFound();
            }

            var slip = _context.Slips.Where(s => s.ID == id).FirstOrDefault();

            var user = _context.Customers.Where(u => u.Email == User.Identity.Name).FirstOrDefault();

            var lease = new Lease()
            {
                SlipID = slip.ID,
                CustomerID = user.Id,
                Customer = user,
                Slip = slip
            };

            _context.Leases.Add(lease);

            _context.SaveChanges();

            var addedLease = _context.Leases.Where(s => s.SlipID == lease.SlipID).FirstOrDefault();

            slip.Leases.Add(addedLease);

            _context.SaveChanges();

            return View();
        }

        private bool SlipExists(int id)
        {
            return _context.Slips.Any(e => e.ID == id);
        }
    }
}
