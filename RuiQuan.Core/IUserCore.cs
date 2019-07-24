using System.Threading.Tasks;

namespace RuiQuan.Core
{
    public interface IUserCore
    {
        /// <summary>
        /// 根据账号密码判断用户是否拥有合法登录权限
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        Task<MobiResult> Login(string email, string pwd);



    }
}