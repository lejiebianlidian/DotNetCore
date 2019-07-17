using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swagger2WebAPI.SwaggerHepler;
using static Swagger2WebAPI.SwaggerHepler.ApiVersionSetting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Swagger2WebAPI.Controllers.v1
{
    /// <summary>
    /// 类别 v1版本
    /// </summary>
    [RouteAttributeSetting(ApiVersionsEnum.v1)]
    //[Route("api/[controller]")]
    public class CategoryController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET api/<controller>/5
        //[HttpGet("{id}")]
        //[RouteAttributeSetting(ApiVersionsEnum.v1, "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //[HttpPost]
        //[RouteAttributeSetting(ApiVersionsEnum.v1, "Post")]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //[RouteAttributeSetting(ApiVersionsEnum.v1, "Put")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //[RouteAttributeSetting(ApiVersionsEnum.v1, "Delete")]
        //public void Delete(int id)
        //{
        //}
    }
}
