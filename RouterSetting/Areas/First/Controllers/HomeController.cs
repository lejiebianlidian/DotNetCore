using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RouterSetting.Areas.First.Controllers
{
    //注释跟Startup中路由areas配合使用
    [Area("First")]
    public class HomeController : Controller
    {
        //[Route("first/home/areas-first-index")]
        public IActionResult AreasFirstIndex()
        {
            return View();
        }

        public IActionResult AreasFirstDraftSetting()
        {
            return View();
        }
    }
}