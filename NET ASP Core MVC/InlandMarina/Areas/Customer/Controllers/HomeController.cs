using InlandMarinaData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InlandMarina.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("/Customer/[action]/")]
    public class HomeController : Controller
    {
        private InlandMarinaContext _context;

        public HomeController(InlandMarinaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home", new { area = "" });

            var leases = _context.Leases.Include(l => l.Slip).ThenInclude(s => s.Dock).Where(l => l.CustomerID == _context.Users.Where(u => u.Email == User.Identity.Name).FirstOrDefault().Id);

            return View(leases);
        }

        [Route("/Customer/Remove/{id?}")]
        public IActionResult Remove(int? id = 0)
        {
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home", new { area = "" });

            if (id == null)
            {
                return NotFound();
            }

            var lease = _context.Leases.Where(l => l.ID == id).FirstOrDefault();
            var slip = _context.Slips.Where(s => s.ID == lease.SlipID).FirstOrDefault();
            var user = _context.Customers.Where(u => u.Id == lease.CustomerID).FirstOrDefault();

            slip.Leases.Remove(lease);
            user.Leases.Remove(lease);

            _context.Leases.Remove(lease);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("/Customer/Confirmation/{id?}")]
        public IActionResult Confirmation(int? id = 0)
        {
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home", new { area = "" });

            ViewBag.Id = id;
            return View();
        }
    }
}
