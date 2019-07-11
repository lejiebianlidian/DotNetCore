using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RouterSetting.Controllers
{
    public class PostController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        //[Route("post/draft-setting")]
        public IActionResult DraftSetting()
        {
            return View();
        }

    }
}