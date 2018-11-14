
using Senparc.Weixin;
using Senparc.Weixin.Exceptions;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.AdvancedAPIs.OAuth;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CharmAPI.Controllers
{
    public class HomeController : Controller
    {
        private string appId = ConfigurationManager.AppSettings["WeixinAppId"];
        private string secret = ConfigurationManager.AppSettings["WeixinAppSecret"];

        // GET: Home
        public ActionResult Index()
        {
           
            ViewBag.Title = "Home Page";
            if (TempData["UserInfo"]!=null)
            {
                var model = TempData["UserInfo"] as OAuthUserInfo;
                ViewBag.Content = "opinId:" + model.openid + "name:" + model.nickname;
                return View();
            }
            if (TempData["CloseAuth"] !=null&&Convert.ToBoolean(TempData["CloseAuth"]))
            {
                ViewBag.Content = "取消授权,返回普通浏览器页面";
                return View();
            }
            if (!Request.UserAgent.ToLower().Contains("micromessenger"))
            {
                ViewBag.Content = "普通浏览器的页面";
                return View();
                //string url = QRConnectAPI.GetQRConnectUrl(appId, "api.lcharm.com/Home/QRCallBack","123", new OAuthScope[] { OAuthScope.snsapi_base },"code" );
                //return Redirect(url);
            }
            else
            {
                string url = OAuthApi.GetAuthorizeUrl(appId,
              "http://api.lcharm.com/Home/UserInfoAutoCallBack",
              "123", OAuthScope.snsapi_userinfo);
                return Redirect(url);
            }
        }


        public ActionResult QRCallBack(string code,string state)
        {

            if (string.IsNullOrEmpty(code))
            {
                return Content("取消授权");
            }
              return Content("code:"+ code);
        }

        public ActionResult UserInfoAutoCallBack(string code, string state)
        {
            if (string.IsNullOrEmpty(code))
            {
                TempData["CloseAuth"] = true;
                return RedirectToAction("Index");

            }

            //if (state != Session["State"] as string)
            //{
            //    //这里的state其实是会暴露给客户端的，验证能力很弱，这里只是演示一下，
            //    //建议用完之后就清空，将其一次性使用
            //    //实际上可以存任何想传递的数据，比如用户ID，并且需要结合例如下面的Session["OAuthAccessToken"]进行验证
            //    return Content("验证失败！请从正规途径进入！");
            //}

            OAuthAccessTokenResult result = null;

            //通过，用code换取access_token
            try
            {
                result = OAuthApi.GetAccessToken(appId, secret, code);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            if (result.errcode != ReturnCode.请求成功)
            {
                return Content("错误：" + result.errmsg);
            }
            //下面2个数据也可以自己封装成一个类，储存在数据库中（建议结合缓存）
            //如果可以确保安全，可以将access_token存入用户的cookie中，每一个人的access_token是不一样的
            Session["OAuthAccessTokenStartTime"] = DateTime.Now;
            Session["OAuthAccessToken"] = result;

            //因为第一步选择的是OAuthScope.snsapi_userinfo，这里可以进一步获取用户详细信息
            try
            {
                //if (!string.IsNullOrEmpty(returnUrl)&& string.IsNullOrEmpty(code))
                //{
                //    string str = returnUrl;
                //    return RedirectToAction("Index",new { returnUrl =str});
                //}

                OAuthUserInfo userInfo = OAuthApi.GetUserInfo(result.access_token, result.openid);
                TempData["UserInfo"] = userInfo;
                return RedirectToAction("Index");
              
            }
            catch (ErrorJsonResultException ex)
            {
                return Content(ex.Message);
            }
        }
    }
}