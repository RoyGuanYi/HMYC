using Charm.MvcExt.Result;
using Oct.Framework.Core.Cache;
using Oct.Framework.Core.Session;
using System.Web.Http;
using System.Web.Http.Controllers;
using Charm.Entity;
using Microsoft.Practices.Unity;
using Charm.MvcExt.Extisions;
using System;
using Charm.Common;

namespace Charm.MvcExt.Base
{
    public class BaseApiController : ApiController
    {
        [Dependency]
        protected ICacheHelper CacheHelper { get; set; }

        [Dependency]
        protected ISessionProvider SessionProvider { get; set; }

        protected DbContext DbContext;

        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            DbContext = new DbContext();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            DbContext.Dispose();
        }

        protected bool VerifyTokey(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return false;
            }
            var flg = false;
            var accountId = ConfigHelper.GetAppSettings("AccountId");
            var password = ConfigHelper.GetAppSettings("Password");
            var time = DateTime.Now.ToString("yyyyMMddHH");//2016051123
            var sign = Md5Encode.Encode(String.Format("{0}{1}{2}", accountId, password, time));
            if (sign==token)
            {
                return flg = true;
            }
            return flg;
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
