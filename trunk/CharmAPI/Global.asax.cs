using AutoMapper;
using Charm.Entity.Role;
using Charm.MvcExt;
using CharmAPI.App_Start;
using CharmAPI.Controllers.WeiXin.Base;
using Senparc.Weixin;
using Senparc.Weixin.MP;
using Senparc.Weixin.RegisterServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace CharmAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            CreateMapper();
            //#region 微信
            ///* 微信配置开始*/
            ////注册开始
            //RegisterService.Start() //这里没有 ; 下面接着写         

            //#region 注册日志（按需）

            //.RegisterTraceLog(ConfigWeixinTraceLog)//配置TraceLog

            //#endregion



            //#region 注册公众号或小程序（按需）

            ////注册公众号
            //.RegisterMpAccount(
            //    ConfigurationManager.AppSettings["WeixinAppId"],
            //    ConfigurationManager.AppSettings["WeixinAppSecret"],
            //    "【盛派网络小助手】公众号");


            //#endregion
            ///* 微信配置结束 */
            //#endregion
        }

        private void CreateMapper()
        {
           
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
    }
}
