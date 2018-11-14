using System.Web.Mvc;
using Charm.Common.Models;
using MvcExt.Result;

namespace Charm.Common.MvcExt
{
    [LoginFilter]
    public class BaseController : Controller
    {
        //[Dependency]
        //protected ICacheHelper CacheHelper { get; set; }

        //[Dependency]
        //protected ISessionProvider SessionProvider { get; set; }

        private UserInfo _currentUser;

        /// <summary>
        /// 获取当前用户
        /// </summary>
        protected UserInfo CurrentUser
        {
            get
            {
                if (_currentUser == null)
                {
                    _currentUser = LoginHelper.Instance.GetLoginUser<UserInfo>();
                }

                return _currentUser;
            }
        }


        /// <summary>
        /// 返回xml对象
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        protected XmlResult Xml(string xml)
        {
            return new XmlResult(xml);
        }

        /// <summary>
        /// 返回xml对象
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        protected XmlResult Xml(object xml)
        {
            return new XmlResult(xml);
        }
    }
}
