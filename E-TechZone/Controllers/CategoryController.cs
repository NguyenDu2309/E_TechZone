using Microsoft.AspNetCore.Mvc;

namespace E_TechZone.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
