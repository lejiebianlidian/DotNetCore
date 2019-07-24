using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RuiQuan.Data
{
   public interface IRepository<T> where T:class
   {
       /// <summary>
       /// 从指定表中获取符合条件的一条实体数据
       /// </summary>
       /// <param name="predicate"></param>
       /// <returns></returns>
       Task<T> GetSingleDataAsync(Expression<Func<T, bool>> predicate);



   }
}
