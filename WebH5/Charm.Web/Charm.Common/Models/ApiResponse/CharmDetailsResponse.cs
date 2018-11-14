using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiResponse
{
    /// <summary>
    /// 魅力圈详情接口返回实体
    /// </summary>
    public class CharmDetailsResponse : ApiResponseBase
    {
        /// <summary>
        /// 魅力圈id
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 魅力圈名称
        /// </summary>
        public string ArticleName { get; set; }

        /// <summary>
        /// 魅力圈内容
        /// </summary>
        public string ArticleContent { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public List<string> ImageUrlList { get; set; }


        /// <summary>
        /// 魅力圈点赞数
        /// </summary>
        public int Likes { get; set; }

        /// <summary>
        /// 魅力圈点赞的详细信息
        /// </summary>
        public List<CharmLikeDetails> ArticleLikeDetails { get; set; }


        /// <summary>
        /// cdkey
        /// </summary>
        public string Token { get; set; }


        /// <summary>
        /// 会员评论
        /// </summary>
        public Page<ArticleComment> MemberComment { get; set; }

        /// <summary>
        /// 总评论数
        /// </summary>
        public long CommentCounts { get; set; }



    }


    

   
}
