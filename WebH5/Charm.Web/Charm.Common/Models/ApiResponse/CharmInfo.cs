using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charm.Common.Models.ApiResponse
{
    public class CharmInfo
    {

        /// <summary>
        /// 魅力圈主键id
        /// </summary>
        public string ArticleId { get; set; }

        /// <summary>
        /// 魅力圈名称
        /// </summary>
        public string ArticleName { get; set; }

        /// <summary>
        /// 魅力圈首页图片
        /// </summary>
        public List<string> ArticleImageUrlList { get; set; }

        /// <summary>
        /// 魅力圈创建人
        /// </summary>
        public string CreateBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public string UpdateOn { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateBy { get; set; }

        /// <summary>
        /// cdkey
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadImageUrl { get; set; }

        /// <summary>
        /// 会员评论
        /// </summary>
        public Page<ArticleComment> MemberComment { get; set; }
    }
}
