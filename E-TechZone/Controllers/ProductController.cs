using Microsoft.AspNetCore.Mvc;

namespace E_TechZone.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

    }
}
