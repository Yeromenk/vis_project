using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace vis.Controllers
{
    public class DomUkolController : Controller
    {
        public IActionResult Index()
        {
            return View(ukoly.GetFakeList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DomUkol domUkol)
        {
            if (ModelState.IsValid)
            {
                ukoly.GetFakeList.Add(domUkol);
            }
            else
            {
                return View("Create", domUkol);
            }

            return RedirectToAction("Index");
        }
    }
}
