using FutureValueMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FutureValueMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // perform calculation of the future value
        // by default it is HttpGet
        // display form for the user to enter data
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FVModel data)
        {
            if(ModelState.IsValid) // all validation attributes are OK
            {
                ViewBag.FV = data.CalculateFV();
            }
            else
            {
                ViewBag.FV = 0;
            }
            return View (data);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
