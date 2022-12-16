using Microsoft.AspNetCore.Mvc;

namespace EFWebMVC.Controllers
{
    public class MVCProductController : Controller
    {
        public IActionResult MVCHome()
        {
            return View();
        }

        public IActionResult ShowProduct()
        {
            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
    }
}
