using Senparc.Weixin;
using Senparc.Weixin.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace CharmAPI.Controllers.WeiXin.Base
{
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
}