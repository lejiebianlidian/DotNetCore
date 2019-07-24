using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RuiQuan.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// 从指定表中获取符合条件的一条实体数据
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public async Task<T> GetSingleDataAsync(Expression<Func<T,bool>> predicate)
        {

            using (var  db=new SqlDbContext())
            {
                if (predicate==null)
                {
                    return null;
                }

                return await db.Set<T>().Where(predicate).FirstOrDefaultAsync<T>();
            }

        }



    }
}
