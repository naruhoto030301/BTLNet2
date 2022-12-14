using AspNetCoreHero.ToastNotification.Abstractions;
using BTLNet2_Nhom11.Data;
using BTLNet2_Nhom11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;

namespace BTLNet2_Nhom11.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;
        public INotyfService _notyfService { get; }
        public BlogController(ApplicationDbContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        [Route("blogs.html", Name = ("Blog"))]
        public IActionResult Index(int? page)
        {
            var pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var pageSize = 10;
            var lsTinDangs = _context.TinDangs
                .AsNoTracking()
                .OrderBy(x => x.PostId);
            PagedList<TinDang> models = new PagedList<TinDang>(lsTinDangs, pageNumber, pageSize);

            ViewBag.CurrentPage = pageNumber;
            return View(models);
        
        }
        [Route("/tin-tuc/{Alias}-{id}.html", Name = "TinChiTiet")]
        public IActionResult Details(int id)
        {
            var tindang = _context.TinDangs.AsNoTracking().SingleOrDefault(x => x.PostId == id);
            if (tindang == null)
            {
                return RedirectToAction("Index");
            }
            var lsBaivietlienquan = _context.TinDangs
                .AsNoTracking()
                .Where(x => x.Published == true && x.PostId != id)
                .Take(3)
                .OrderByDescending(x => x.CreatedDate).ToList();
            ViewBag.Baivietlienquan = lsBaivietlienquan;
            return View(tindang);
        }
    }
}
