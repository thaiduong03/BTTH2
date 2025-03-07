using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class GradeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(GradeModel model)
        {
            ViewBag.FinalGrade = model.CalculateFinalGrade();
            return View(model);
        }
    }
}
