using AspNetCoreHero.ToastNotification.Abstractions;
using BTLNet2_Nhom11.Data;
using BTLNet2_Nhom11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTLNet2_Nhom11.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _context;
        public INotyfService _notyfService { get; }
        public SearchController(ApplicationDbContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length <1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls = _context.Products.AsNoTracking()
                                  .Include(a => a.Cat)
                                  .Where(x => x.ProductName.Contains(keyword))
                                  .OrderByDescending(x => x.ProductName)
                                  .Take(10)
                                  .ToList();
            if (ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }
        }
    }
}
