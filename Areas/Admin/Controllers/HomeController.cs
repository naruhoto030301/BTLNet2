using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BTLNet2_Nhom11.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
