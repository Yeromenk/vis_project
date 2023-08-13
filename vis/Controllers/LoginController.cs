using DataAccess.Model;
using Microsoft.AspNetCore.Mvc;

namespace vis.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
            // return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(Account account)
        {
            if (ModelState.IsValid)
            {
                ucet.GetFakeList.Add(account);
            }
            else
            {
                return View("Index", account);
            }


            return RedirectToAction("Index");
        }


    }
}
