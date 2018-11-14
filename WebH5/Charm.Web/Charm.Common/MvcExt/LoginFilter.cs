using System;
using System.Web.Mvc;

namespace Charm.Common.MvcExt
{
    public class LoginFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.HttpContext == null)
                throw new ArgumentNullException("httpContext");
            var hasuser = LoginHelper.Instance.IsLogin();

            //注册页面
            bool  isRegeristUrl = filterContext.HttpContext.Request.FilePath=="/Personal/Setting";

            if (isRegeristUrl)
            {
                hasuser = true;
            }
            if (!hasuser)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}
