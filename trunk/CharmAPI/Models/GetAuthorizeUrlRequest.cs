using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CharmAPI.Models
{
    public class GetAuthorizeUrlRequest
    {
        /// <summary>
        /// 返回url
        /// </summary>
        public string ReturnUrl { get; set; }
        /// <summary>
        /// 请求类型
        /// </summary>
        public int OAuthScope { get; set; }


    }
}