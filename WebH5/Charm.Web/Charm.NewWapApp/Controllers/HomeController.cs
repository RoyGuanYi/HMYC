using System.Configuration;
using System.Net;
using Charm.Common;
using Charm.Common.Models;
using Charm.Common.Models.ApiRequest;
using Charm.Common.Models.ApiResponse;
using Charm.Common.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Compilation;
using System.Web.Mvc;
using Charm.NewWapApp.Models;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;
using Charm.Entity.API.Mst;
using Charm.Entity.API;

namespace Charm.NewWapApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        /// <summary>
        /// 首页（获取魅力圈列表）
        /// </summary>
        /// <returns></returns>

        public ActionResult Index()
        {
            var model = new CharmInfoRequest
            {
                Token = RestServiceProxy.GetToken(),
                topNum = 5,
                CurrentPage = 1
            };
            string url = GlobalClientConfig.BaseURI + "/Article/GetArticleList";
            var result = RestServiceProxy.Get<CharmListResponse, CharmInfoRequest>(model, url);
            return View(result);
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        public JsonResult SendVCode(string phone)
        {
            var appkey = "23362594";
            var url = "http://gw.api.taobao.com/router/rest";
            var secret = "e145c1763fec7c47fa206057b8bc7641";
            //  生成随机数
            var rand = new Random();
            var code = rand.Next(1000, 10000);
            ITopClient client = new DefaultTopClient(url, appkey, secret);
            AlibabaAliqinFcSmsNumSendRequest req = new AlibabaAliqinFcSmsNumSendRequest();
            req.Extend = "123456";
            req.SmsType = "normal";
            req.SmsFreeSignName = "Charm登录";
            req.SmsParam = "{\"code\":\""+code+"\",\"product\":\"用户\"}";
            req.RecNum = phone;
            req.SmsTemplateCode = "SMS_9765033";
            AlibabaAliqinFcSmsNumSendResponse rsp = client.Execute(req);
            if (rsp.IsError)
            {
                LogHelper.Error(rsp.ErrMsg + "-" + phone);
                return Json(new { msg = rsp.ErrMsg, isSuccess = false });
            }
            var msg = rsp.Result.Msg;
            var isSuccess = rsp.Result.Success;
            if (isSuccess)
            {
                var session = new SysSessionProvider();
                session.AddSession("userVcode", code, 5);
            }
            return Json(new {msg = msg, isSuccess = isSuccess});
        }

        /// <summary>
        /// 登录页面
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        
        /// <summary>
        /// 登录提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(LoginModel model, string returnUrl)
        {

            if (string.IsNullOrWhiteSpace(model.UserId))
            {
                TempData["ejs"] = "手机号码不能为空";
                return View(model);
            }
            if (string.IsNullOrWhiteSpace(model.UserPassword))
            {
                TempData["ejs"] = "验证码不能为空";
                return View(model);
            }
            #region 手机验证码
            //  判断验证码是否正确
            // bug test no code


            //if (model.UserPassword != "1234")
            //{

            //    int code = 0;
            //    var vCode = session.GetSession("userVcode");
            //    if (vCode != null)
            //    {
            //        code = Convert.ToInt32(vCode);
            //    }
            //    if (code == 0)
            //    {
            //        TempData["ejs"] = "验证码已超过5分钟，请重新获取。";
            //        return View(model);
            //    }
            //    else
            //    {
            //        if (model.UserPassword != vCode.ToString())
            //        {
            //            TempData["ejs"] = "验证码错误请重新填写。";
            //            return View(model);
            //        }
            //    }
            //}
            #endregion
            //登录
            GetBrandRequest request = new GetBrandRequest();
            request.Token = RestServiceProxy.GetToken();
            request.UserAccount = model.UserId;
            request.UserPassword = model.UserPassword;
            string demourl = GlobalClientConfig.BaseURI + "/BasicData/GetBrandInfo";
            GetBrandResponse response = RestServiceProxy.Post<GetBrandResponse, GetBrandRequest>(request, demourl);
            if (response != null && response.RspCode == ReponseCode.Success.GetHashCode())
            {
                var session = new SysSessionProvider();
                BrandInfo brandModel = null;
                if (response.BrandInfo != null)
                {
                    brandModel = response.BrandInfo;
                    //if (session.GetSession("userVcode") != null) //手机登陆验证 使用 注释
                    //{
                    //    session.Clear("userVcode");
                    //}
                    LoginHelper.Instance.Login(() => new UserInfo()
                    {
                        Account = brandModel.UserAccount,
                        UserName = brandModel.BrandName,
                        Avatar = "",
                        Phone = brandModel.BrandPhone,
                        BrandId = brandModel.BrandId,
                        UserType=UserTypeEnum.Brand
                    });
                    //跳转至首页
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        return this.RedirectToAction("Index", "Home");
                    }
                    var appName = ConfigurationManager.AppSettings["AppName"];
                    appName = string.IsNullOrEmpty(appName) ? "/" : string.Format("/{0}/", appName);
                    //根目录
                    var root = this.ControllerContext.RequestContext.HttpContext.Request.ApplicationPath;
                    returnUrl = (root + returnUrl.Replace(appName, "/")).Replace("//", "/");
                    LogHelper.Error(returnUrl == null ? "；另外一种retrnUrl" : returnUrl);
                    //跳转至指定页
                    return this.Redirect(returnUrl);
                }
                else
                {
                    brandModel = new BrandInfo();
                    TempData["ejs"] = "商家信息异常为空";
                }

            }
            else
            {
                if (response != null && response.RspCode != ReponseCode.Success.GetHashCode())
                {
                    TempData["ejs"] = response.RspDesc;
                }
                else
                {
                    TempData["ejs"] = "获取品牌信息异常";
                }
              
            }
            return View(model);
        }


      
        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOut()
        {
            LoginHelper.Instance.LogOut();
            return RedirectToAction("Index");
        }


    

        /// <summary>
        /// 微信OAUTH2接口登录
        /// </summary>
        /// <returns></returns>
        public ActionResult WeiXinOauth2(string code, string state)
        {
            //LogHelper.Info(string.Format("code:{0}state:{1}",code,state));
            if (string.IsNullOrEmpty(code))
            {
                return RedirectToAction("Index");
            }
            state = RestServiceProxy.GetToken();
            var dto = new WeiXinOauth2Dto
            {
                Code = code,
                State = state
            };
            //  post给后台的微信接口
            string url = "http://manager.lcharm.com/OAuth2/UserInfoCallBack/";
            var result = RestServiceProxy.Post<LoginInfoResponse, WeiXinOauth2Dto>(dto, url);
            //  回传不为空
            if (result != null && result.RspCode == 0)
            {
                LoginHelper.Instance.Login(() => new UserInfo()
                {
                    Account = result.MemberId,
                    UserName = result.MemberNickName,
                    Avatar = result.HeadImageUrl,
                    //Phone = loginInfo.MemberAccount
                });
                //跳转至首页
                return this.RedirectToAction("MIndex", "Personal");

            }
            else
            {
                TempData["ejs"] = "系统异常";
                LogHelper.Error(result == null ? "返回对象为空" : result.RspErrorMsg);
                return RedirectToAction("Index", "Home");
            }
        }


    }
}
