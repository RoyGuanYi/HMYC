using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
   public class CategoryInfoRequest
    {

        //魅力圈名称
        public string ArticleName { get; set; }

        //会员id
        public string MemberId { get; set; }

        //魅力圈图片地址list集合
        public List<string> ImageUrlList { get; set; }

        //魅力圈内容
        public string ArticleContent { get; set; }

        /// <summary>
        /// 加密协议
        /// </summary>
        public string Token { get; set; }
    }
}
