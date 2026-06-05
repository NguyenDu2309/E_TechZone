using E_TechZone.Models;
using E_TechZone.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_TechZone.Controllers
{
    public class BrandController : Controller
    {
        private readonly DataContext _dataContext;
        public BrandController (DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IActionResult> Index(string Slug = "")
        {
            BrandModel brand = _dataContext.Brands
                .Where(b => b.Slug == Slug)
                .FirstOrDefault();
            if(brand == null)
            {
                return RedirectToAction("Index");
            }
            var productByBrand = _dataContext.Products
                .Where(p => p.BrandId == brand.Id);
            return View(await productByBrand.OrderByDescending(p => p.Id).ToListAsync());
        }
    }
}
