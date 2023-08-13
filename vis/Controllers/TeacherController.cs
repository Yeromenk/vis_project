using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace vis.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {

            return View(ucitel.GetFakeList);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Znamky znamky)
        {
            if (ModelState.IsValid)
            {
                znamkies.GetFakeList.Add(znamky);
            }
            else
            {
                return View("Create", znamky);
            }


            return RedirectToAction("Index");
        }



    }
}
