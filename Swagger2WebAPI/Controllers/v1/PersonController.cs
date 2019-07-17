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
    /// 人员 v1版本
    /// </summary>
    [RouteAttributeSetting(ApiVersionsEnum.v1)]
    //[Route("api/[controller]")]
    public class PersonController : Controller
    {
        /// <summary>
        /// 查询数据列表信息
        /// </summary>
        /// <returns></returns>
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 根据Id查询信息
        /// </summary>
        /// <param name="id">Id主键</param>
        /// <returns></returns>
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 新增信息
        /// </summary>
        /// <param name="value">新增数据信息</param>
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// 根据Id修改特定数据
        /// </summary>
        /// <param name="id">要修改数据的主键Id</param>
        /// <param name="value">要修改数据的值</param>
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 根据id删除指定数据
        /// </summary>
        /// <param name="id">要删除数据的Id</param>
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
