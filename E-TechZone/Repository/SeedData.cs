using E_TechZone.Models;
using Microsoft.EntityFrameworkCore;

namespace E_TechZone.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context)
        {
            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                CategoryModel macbook = new CategoryModel { Name = "Macbook", Slug = "macbook", Description = "Latest Macbook products", Status = 1 };
                CategoryModel pc = new CategoryModel { Name = "Pc", Slug = "pc", Description = "Latest Pc products", Status = 1 };
                BrandModel dell = new BrandModel { Name = "Apple", Slug = "apple", Description = "Latest Apple products", Status = 1 };
                BrandModel hp = new BrandModel { Name = "Samsung", Slug = "samsung", Description = "Latest Samsung products", Status = 1 };
                _context.Products.AddRange(
                    new ProductModel { Name = "Macbook", Slug = "macbook", Description = "The latest Macbook with advanced features.", Price = 1099.99m, Image = "https://example.com/images/macbook.jpg", Category = macbook, Brand = dell },
                    new ProductModel { Name = "Pc", Slug = "pc", Description = "The latest Pc with advanced features.", Price = 1199.99m, Image = "https://example.com/images/pc.jpg", Category = pc, Brand = hp }
                );
                _context.SaveChanges();
            }
        }
    }
}
