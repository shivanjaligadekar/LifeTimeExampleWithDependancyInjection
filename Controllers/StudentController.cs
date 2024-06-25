using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeTimeExampleWithDependancyInjection.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Rollno", 11);
            HttpContext.Session.SetString("StudentName", "Vishnu");

            //ViewBag.Rollno = HttpContext.Session.GetInt32("Rollno");
            //ViewBag.Sname = HttpContext.Session.GetString("StudentName");
            return RedirectToAction("ShowValues");
        }

        public ActionResult ShowValues()
        {
            ViewBag.Rollno = HttpContext.Session.GetInt32("Rollno");
            ViewBag.Sname = HttpContext.Session.GetString("StudentName");
            return View();
        }


    }
}
