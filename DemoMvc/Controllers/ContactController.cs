using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class ContactController : Controller
    {
        // Hiển thị form liên hệ
        public IActionResult Contact()
        {
            return View();
        }

        // Nhận dữ liệu từ form gửi lên
        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Message = message;

            return View();
        }
    }
}
