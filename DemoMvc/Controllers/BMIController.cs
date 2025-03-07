using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BMIModel model)
        {
            ViewBag.BMI = model.CalculateBMI();
            ViewBag.Category = model.GetBMICategory();
            return View(model);
        }
    }
}
