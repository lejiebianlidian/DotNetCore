using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RouterSetting.Models;

namespace RouterSetting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //该实现方法如果每个方法都需要手动指定路由地址，太过麻烦。
        //core2.2版本之后可以进行批量统一设置(通过实现IOutboundParameterTransformer接口即可)
        //[Route("home/draf-setting")]
        public IActionResult DraftSetting()
        {
            return View();
        }

        public IActionResult DraftSetting2()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       



    }
}
