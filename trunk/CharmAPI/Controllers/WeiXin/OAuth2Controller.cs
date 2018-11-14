using Charm.MvcExt.Base;
using CharmAPI.Models;
using Senparc.Weixin.HttpUtility;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AdvancedAPIs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CharmAPI.Controllers.WeiXin
{
    /// <summary>
    /// 验证地址控制器
    /// </summary>
    public class OAuth2Controller : BaseApiController
    {
        //下面换成账号对应的信息，也可以放入web.config等地方方便配置和更换
        private string appId = ConfigurationManager.AppSettings["WeixinAppId"];
        private string secret = ConfigurationManager.AppSettings["WeixinAppSecret"];
        /// <summary>
        /// 获取验证地址
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //[HttpGet,Route("OAuth2/GetAuthorizeUrl")]
        //public string GetAuthorizeUrl([FromUri] GetAuthorizeUrlRequest request)
        //{
        //    string url = "返回地址失败";
        //    var state = "Charm" + DateTime.Now.Millisecond;//随机数，用于识别请求可靠性
        //    if (request.OAuthScope == OAuthScope.snsapi_userinfo.GetHashCode())
        //    {
        //        url= OAuthApi.GetAuthorizeUrl(appId,
        //      "http://sdk.weixin.senparc.com/oauth2/UserInfoCallback?returnUrl=" + request.ReturnUrl.UrlEncode(),
        //      state, OAuthScope.snsapi_userinfo);
        //    }
        //    else if (request.OAuthScope == OAuthScope.snsapi_base.GetHashCode())
        //    {
        //        OAuthApi.GetAuthorizeUrl(appId,
        //    url= "http://sdk.weixin.senparc.com/oauth2/UserInfoCallback?returnUrl=" + request.ReturnUrl.UrlEncode(),
        //      state, OAuthScope.snsapi_userinfo);
        //    }
        //    return url;
        //}

    }
}
