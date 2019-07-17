using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Swagger2WebAPI.Controllers
{
    /// <summary>
    /// 默认控制器内容-无版本控制
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /// <summary>
        /// 获取列表数据
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //return new string[] { "value1", "value2" };
            return new string[] { "张三", "男", "李思", "女","王武","男" };
        }
        /// <summary>
        /// 查询数据啊
        /// </summary>
        /// <param name="id">要查询数据的Id</param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return id+"执行成功";
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="value">新增加数据内容</param>
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id">要提交修改数据的Id</param>
        /// <param name="value">要修改的数据内容</param>
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">要删除数据的主键id</param>
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
