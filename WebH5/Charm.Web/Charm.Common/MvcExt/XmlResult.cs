﻿using System;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MvcExt.Result
{
    public class XmlResult : ActionResult
    {
        // 被序列化的内容
        string Data { get; set; }

        // 构造器
        public XmlResult(string data)
        {
            Data = data;
        }

        // 构造器
        public XmlResult(object data)
        {
            Data = JsonConvert.SerializeObject(data);
        }

        // 主要是重写这个方法
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            HttpResponseBase response = context.HttpContext.Response;

            // 设置 HTTP Header 的 ContentType
            response.ContentType = "text/xml";

            if (Data != null)
            {
                response.Write(Data);
            }
        }
    }
}
