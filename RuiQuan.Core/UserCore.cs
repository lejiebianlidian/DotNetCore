using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using RuiQuan.Data;

namespace RuiQuan.Core
{
    public class UserCore
    {
        private readonly IRepository<EB_User> _repository;

        public UserCore(IRepository<EB_User> repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// 根据账号密码判断用户是否拥有合法登录权限
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pwd"></param>
        /// <returns>100成功，101账号错误，102密码错误，103参数不合法</returns>
        public async Task<MobiResult> Login(string email, string pwd)
        {
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(pwd))
            {
                return new MobiResult(103);
            }
            else
            {
                //到Data层去取指定用户的数据
                var model = await _repository.GetSingleDataAsync(p => p.Email.Equals(email) && p.IsDelete != 99);
                if (model == null)
                {
                    return new MobiResult(101);

                }

                if (!model.Pwd.Equals(pwd))
                {
                    return new MobiResult(102);
                }
                return new MobiResult(100);

            }
        }







    }
}