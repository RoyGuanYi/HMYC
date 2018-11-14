using System.Collections.Generic;
using System.Web.Mvc;
using Charm.Entity;
using Charm.MvcExt.Extisions;
using Charm.MvcExt.Result;
using Charm.MvcExt.User;
using Microsoft.Practices.Unity;
using Oct.Framework.Core.Cache;
using Oct.Framework.Core.Session;

namespace Charm.MvcExt.Base
{
    public class BaseController : Controller
    {
        //[Dependency]
        //protected ICacheHelper CacheHelper { get; set; }

        [Dependency]
        protected ISessionProvider SessionProvider { get; set; }

        private UserBase _currentUser;

        /// <summary>
        /// 获取当前用户
        /// </summary>
        protected UserBase CurrentUser
        {
            get
            {
                if (_currentUser == null)
                {
                    _currentUser = LoginHelper.Instance.GetLoginUser<UserBase>();
                }

                return _currentUser;
            }
        }

        protected IKernel Kernel { get; private set; }

        public BaseController()
        {
            Kernel = new Kernel(this);
        }

        protected DbContext DbContext;

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            DbContext = new DbContext();
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            DbContext.Dispose();
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

        /// <summary>
        /// 成功提示
        /// </summary>
        /// <param name="msg"></param>
        protected void TipS(string msg = "保存成功")
        {
            this.ViewBag.sjs = msg;

            this.TempData["sjs"] = msg;
        }

        /// <summary>
        /// 失败提示
        /// </summary>
        /// <param name="msg"></param>
        protected void TipE(string msg)
        {
            this.ViewBag.ejs = msg;

            this.TempData["ejs"] = msg;
        }

        /// <summary>
        /// 执行前
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (CurrentUser != null)
            {
                string controllerName = filterContext.RouteData.Values["controller"].ToString();
                string actionName = filterContext.RouteData.Values["action"].ToString();
                var url = "/" + controllerName.ToLower() + "/" + actionName.ToLower();

                //  获取用户菜单
                var menu = LoginHelper.Instance.GetLoginUserMenus();
                if (menu != null && menu.MeunItem != null && menu.MeunItem.Count > 0)
                {
                    foreach (KeyValuePair<string, List<MeunItem>> item in menu.MeunItem)
                    {
                        foreach (var action in item.Value)
                        {
                            if (action.Url.ToLower() == url)
                            {
                                ViewBag.MenuName = item.Key;
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
