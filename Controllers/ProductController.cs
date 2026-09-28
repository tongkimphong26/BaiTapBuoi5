using Microsoft.AspNetCore.Mvc;
using BuoiThu5.Models;

namespace BuoiThu5.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 15000000
                },

                new Product
                {
                    Id = 2,
                    Name = "Điện thoại",
                    Price = 8000000
                },

                new Product
                {
                    Id = 3,
                    Name = "Tai nghe",
                    Price = 1000000
                }
            };

            return View(products);
        }
    }
}