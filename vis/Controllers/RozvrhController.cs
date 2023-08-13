using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace vis.Controllers
{
    public class RozvrhController : Controller
    {
        public IActionResult Index()
        {
            return View(timetable.GetFakeList);

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Rozvrh rozvrh)
        {
            if (ModelState.IsValid)
            {
                timetable.GetFakeList.Add(rozvrh);
            }
            else
            {
                return View("Create", rozvrh);
            }


            return RedirectToAction("Index");
        }
    }
}
