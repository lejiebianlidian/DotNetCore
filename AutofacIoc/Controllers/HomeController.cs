using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Mvc;
using AutofacIoc.Models;
using Service;

namespace AutofacIoc.Controllers
{
    public class HomeController : Controller
    {
        private IPersonService _personService;
        //一个接口多个实现Demo
        //private IPayService _payService;//这样只能获取一个
        private IPayService _wxPayService;
        private IPayService _alPayService;
        private IComponentContext _componentContext;
        /// <summary>
        /// 通过构造函数注入Service
        /// </summary>
        /// <param name="personService"></param>
        //public HomeController(IPersonService personService,IPayService payService) //这样只能获取一个
        public HomeController(IPersonService personService,IComponentContext componentContext)
        {
            this._personService = personService;
            //this._payService = payService;
            this._componentContext = componentContext;
            //解释组件
            _alPayService = _componentContext.ResolveNamed<IPayService>(typeof(AliPayService).Name);
            _wxPayService = _componentContext.ResolveNamed<IPayService>(typeof(WxPayService).Name);
        }


        public IActionResult Index()
        {
            ViewBag.eat = _personService.Eat();
            //ViewBag.pay = _payService.Pay();//这样只能获取一个
            ViewBag.alipay = _alPayService.Pay();
            ViewBag.wxpay = _wxPayService.Pay();

            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.Burn = _personService.Burn();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
