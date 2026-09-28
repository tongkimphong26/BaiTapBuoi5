using Microsoft.AspNetCore.Mvc;
using BuoiThu5.Models;

namespace BuoiThu5.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _context;

        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();

            return View(products);
        }
    }
}