using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperTest.Enity;
using Microsoft.AspNetCore.Mvc;
using AutoMapperTest.Models;

namespace AutoMapperTest.Controllers
{
    public class HomeController : Controller
    {
        private IMapper _mapper;

        public HomeController([FromServices]IMapper mapper)
        {
            this._mapper = mapper;
        }
        public IActionResult Index()
        {
            Users user = new Users()
            {
                Id = "1",
                Name = "张三",
                Address = "山东省济南市",
                Gender = "男",
                CreateTime = Convert.ToDateTime(DateTime.Now.ToString("G"))
            };
            List<Users> userliList = new List<Users>()
            {
                 new Users()
                 {
                     Id = "1",
                     Name = "张三",
                     Gender = "男",
                     Address = "山东济南",
                     CreateTime =Convert.ToDateTime( DateTime.Now.ToString("G"))
                 },
                 new Users()
                 {
                     Id = "2",
                     Name = "李思",
                     Gender = "女",
                     Address = "山东淄博",
                     CreateTime =Convert.ToDateTime( DateTime.Now.ToString("G"))
                 },new Users()
                 {
                     Id = "3",
                     Name = "李思3",
                     Gender = "男",
                     Address = "山东泰安",
                     CreateTime =Convert.ToDateTime( DateTime.Now.ToString("G"))
                 },new Users()
                 {
                     Id = "4",
                     Name = "李思4",
                     Gender = "女",
                     Address = "山东临沂",
                     CreateTime =Convert.ToDateTime( DateTime.Now.ToString("G"))

                 },new Users()
                 {
                     Id = "5",
                     Name = "李思5",
                     Gender = "男",
                     Address = "山东潍坊",
                     CreateTime =Convert.ToDateTime( DateTime.Now.ToString("G"))

                 },new Users()
                 {
                     Id = "6",
                     Name = "李思6",
                     Gender = "女",
                     Address = "山东聊城",
                     CreateTime =Convert.ToDateTime( DateTime.Now.ToString("G"))
                 }


            };
            var userDto = _mapper.Map<Users, UserDTO>(user);
            var userDtoList = _mapper.Map<List<Users>, List<UserDTO>>(userliList);
            ViewBag.userList = userDtoList;
            ViewData["userList"] = userDtoList;

            UserDTO uDto = new UserDTO()
            {
                Id = "125",
                UserName = "张三三",
                Address = "山东济南高新",
                Gender = "男啊",
                CreateTime = Convert.ToDateTime(DateTime.Now.ToString("G"))
            };

            var users = _mapper.Map<Users>(uDto);
            var users2 = _mapper.Map<UserDTO, Users>(uDto);



            return View(userDto);
        }

        public IActionResult Privacy()
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
