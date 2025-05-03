using System.Web.Mvc;
using CTUClassroomReservation.Models;

namespace YourProjectName.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard");
            }

            return View(model);
        }

        public ActionResult Dashboard()
        {
            return View();
        }
    }
}
