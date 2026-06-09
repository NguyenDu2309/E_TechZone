using E_TechZone.Models;
using E_TechZone.Models.ViewModels;
using E_TechZone.Repository;
using Microsoft.AspNetCore.Mvc;

namespace E_TechZone.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _dataContext;
        public CartController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IActionResult Index()
        {
            List<CartItemModel> cartsItems = HttpContext.Session.GetJson<List<CartItemModel>>("Cart") ?? new List<CartItemModel>();
            CartItemViewModel cartVM = new()
            {
                CartItems = cartsItems,
                GrandTotal = cartsItems.Sum(x => x.Quantity * x.Price)
            };
            return View(cartVM);
        }
        public IActionResult Checkout()
        {
            return View("~/Views/Checkout/Index.cshtml");
        }
    }
}
