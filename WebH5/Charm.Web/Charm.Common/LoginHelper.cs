using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using Charm.Common.Models;

namespace Charm.Common
{
    public class LoginHelper : SingleTon<LoginHelper>
    {
        protected SysSessionProvider SessionProvider { get; set; }

        public LoginHelper()
        {
            SessionProvider = new SysSessionProvider();
        }

        /// <summary>
        /// 创建登录对象
        /// </summary>
        /// <param name="func"></param>
        public void Login(Func<UserInfo> func)
        {
            var user = func();
            SessionProvider.AddSession("UserSession", user);
            FormsAuthentication.SetAuthCookie(user.Account, false);
        }


        /// <summary>
        /// 获取登录对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetLoginUser<T>() where T : UserInfo
        {
            return SessionProvider.GetSession<T>("UserSession");
        }

        /// <summary>
        /// 判断是否登录了
        /// </summary>
        /// <returns></returns>
        public bool IsLogin()
        {
            return SessionProvider.GetSession<UserInfo>("UserSession") != null;
        }

        /// <summary>
        /// 退出
        /// </summary>
        public void LogOut()
        {
            if (HttpContext.Current != null)
            {
                FormsAuthentication.SignOut();
            }
            SessionProvider.Clear("UserSession");
            SessionProvider.ClearAll();
        }
    }
}
