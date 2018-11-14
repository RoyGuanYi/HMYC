using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Charm.Common;
using System.Configuration;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using Senparc.Weixin;
using Senparc.Weixin.RegisterServices;
using Senparc.Weixin.MP;
using Senparc.Weixin.Exceptions;
using Senparc.Weixin.Entities.TemplateMessage;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;

namespace Charm.NewWapApp
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            #region 微信
            /* 微信配置开始*/
            //注册开始
            RegisterService.Start() //这里没有 ; 下面接着写         

            #region 注册日志（按需）

            .RegisterTraceLog(ConfigWeixinTraceLog)//配置TraceLog

            #endregion



            #region 注册公众号或小程序（按需）

            //注册公众号
            .RegisterMpAccount(
                ConfigurationManager.AppSettings["WeixinAppId"],
                ConfigurationManager.AppSettings["WeixinAppSecret"],
                "【盛派网络小助手】公众号");


            #endregion
            /* 微信配置结束 */
            #endregion

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError().GetBaseException();
            LogHelper.Error(ex);
        }

        #region Session

        public void Session_Start()
        {

        }

        public void Session_End()
        {
            LoginHelper.Instance.LogOut();
        }


        /// <summary>
        /// 配置微信跟踪日志
        /// </summary>
        private void ConfigWeixinTraceLog()
        {
            //这里设为Debug状态时，/App_Data/WeixinTraceLog/目录下会生成日志文件记录所有的API请求日志，正式发布版本建议关闭
            Senparc.Weixin.Config.IsDebug = true;
            Senparc.Weixin.WeixinTrace.SendCustomLog("系统日志", "系统启动");//只在Senparc.Weixin.Config.IsDebug = true的情况下生效

            //自定义日志记录回调
            Senparc.Weixin.WeixinTrace.OnLogFunc = () =>
            {
                //加入每次触发Log后需要执行的代码
            };

            //当发生基于WeixinException的异常时触发
            Senparc.Weixin.WeixinTrace.OnWeixinExceptionFunc = ex =>
            {
                //加入每次触发WeixinExceptionLog后需要执行的代码

                //发送模板消息给管理员
                var eventService = new EventService();
                eventService.ConfigOnWeixinExceptionFunc(ex);
            };
        }
        #endregion
    }

    public class EventService
    {
        public void ConfigOnWeixinExceptionFunc(WeixinException ex)
        {
            try
            {
                Task.Factory.StartNew(async () =>
                {
                    var appId = ConfigurationManager.AppSettings["WeixinAppId"];


                    string openId = "";//收到通知的管理员OpenId
                    var host = "A1 / AccessTokenOrAppId：" + (ex.AccessTokenOrAppId ?? "null");
                    string service = null;
                    string message = ex.Message;
                    var status = ex.GetType().Name;
                    var remark = "\r\n这是一条通过OnWeixinExceptionFunc事件发送的异步模板消息";
                    string url = "https://github.com/JeffreySu/WeiXinMPSDK/blob/24aca11630bf833f6a4b6d36dce80c5b171281d3/src/Senparc.Weixin.MP.Sample/Senparc.Weixin.MP.Sample/Global.asax.cs#L246";//需要点击打开的URL

                    var sendTemplateMessage = true;

                    if (ex is ErrorJsonResultException)
                    {
                        var jsonEx = (ErrorJsonResultException)ex;
                        service = jsonEx.Url;
                        message = jsonEx.Message;

                        //需要忽略的类型
                        var ignoreErrorCodes = new[]
                        {
                                ReturnCode.获取access_token时AppSecret错误或者access_token无效,
                                ReturnCode.template_id不正确,
                                ReturnCode.缺少access_token参数,
                                ReturnCode.api功能未授权,
                                ReturnCode.用户未授权该api,
                                ReturnCode.参数错误invalid_parameter,
                                ReturnCode.接口调用超过限制,
                                ReturnCode.需要接收者关注,//43004

                                //其他更多可能的情况
                            };
                        if (ignoreErrorCodes.Contains(jsonEx.JsonResult.errcode))
                        {
                            sendTemplateMessage = false;//防止无限递归，这种请款那个下不发送消息
                        }

                        //TODO:防止更多的接口自身错误导致的无限递归。
                    }
                    else
                    {
                        if (ex.Message.StartsWith("openid:"))
                        {
                            openId = ex.Message.Split(':')[1];//发送给指定OpenId
                        }
                        service = "WeixinException";
                        message = ex.Message;
                    }

                    if (sendTemplateMessage)
                    {
                        int sleepSeconds = 3;
                        Thread.Sleep(sleepSeconds * 1000);
                        var data = new WeixinTemplate_ExceptionAlert(string.Format("微信发生异常（延时{0}秒）", sleepSeconds), host, service, status, message, remark);

                        //修改OpenId、启用以下代码后即可收到模板消息
                        if (!string.IsNullOrEmpty(openId))
                        {
                            var result = await Senparc.Weixin.MP.AdvancedAPIs.TemplateApi.SendTemplateMessageAsync(appId, openId, data.TemplateId,
                              url, data);
                        }
                    }
                });
            }
            catch (Exception e)
            {
                Senparc.Weixin.WeixinTrace.SendCustomLog("OnWeixinExceptionFunc过程错误", e.Message);
            }
        }
    }

    /*
      {{first.DATA}}
       Time：{{keyword1.DATA}}
       Host：{{keyword2.DATA}}
       Service：{{keyword3.DATA}}
       Status：{{keyword4.DATA}}
       Message：{{keyword5.DATA}}
       {{remark.DATA}}
     */

    public class WeixinTemplate_ExceptionAlert : TemplateMessageBase
    {
        const string TEMPLATE_ID = "ur6TqESOo-32FEUk4qJxeWZZVt4KEOPjqbAFDGWw6gg";//每个公众号都不同，需要根据实际情况修改

        public TemplateDataItem first { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        public TemplateDataItem keyword1 { get; set; }
        /// <summary>
        /// Host
        /// </summary>
        public TemplateDataItem keyword2 { get; set; }
        /// <summary>
        /// Service
        /// </summary>
        public TemplateDataItem keyword3 { get; set; }
        /// <summary>
        /// Status
        /// </summary>
        public TemplateDataItem keyword4 { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        public TemplateDataItem keyword5 { get; set; }

        public TemplateDataItem remark { get; set; }

        public WeixinTemplate_ExceptionAlert(string _first, string host, string service, string status, string message,
            string _remark, string url = null, string templateId = TEMPLATE_ID)
            : base(templateId, url, "系统异常告警通知")
        {
            first = new TemplateDataItem(_first);
            keyword1 = new TemplateDataItem(DateTime.Now.ToString());
            keyword2 = new TemplateDataItem(host);
            keyword3 = new TemplateDataItem(service);
            keyword4 = new TemplateDataItem(status);
            keyword5 = new TemplateDataItem(message);
            remark = new TemplateDataItem(_remark);
        }
    }
}