using AspNetCoreHero.ToastNotification.Abstractions;
using BTLNet2_Nhom11.Data;
using BTLNet2_Nhom11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace BTLNet2_Nhom11.Controllers
{
    public class PageController : Controller
    {
        private readonly ApplicationDbContext _context;
        public INotyfService _notyfService { get; }
        public PageController(ApplicationDbContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [Route("/page/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            if (string.IsNullOrEmpty(Alias)) return RedirectToAction("Index","Home");
            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (page == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(page);
        }
    }
}
