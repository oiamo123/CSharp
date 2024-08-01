using InlandMarina.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Home controller
namespace InlandMarina.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // For /Home
        public IActionResult Index()
        {
            return View();
        }

        // For /Home/Contact
        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Handle404()
        {
            Response.StatusCode = 404;
            return View();
        }
    }
}
