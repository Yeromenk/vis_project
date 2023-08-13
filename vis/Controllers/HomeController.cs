using System.Diagnostics;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;
using vis.Models;

namespace vis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Rozvrh()
        {
            return View();
        }
        public IActionResult DomUkol()
        {
            return View();
        }
        public IActionResult Kontakty()
        {
            return View();
        }
        public IActionResult Znamky()
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