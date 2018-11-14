using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiResponse
{
    public class NewsInfoById:ApiResponseBase
    {
           
        /// <summary>
        /// 新闻ID
        /// </summary>
        public string NewsId { get; set; }
        /// <summary>
        /// 新闻名称
        /// </summary>
        public string NewsName { get; set; }
        /// <summary>
        /// 标题图片地址
        /// </summary>
        public string TitleUrl { get; set; }
        /// <summary>
        ///新闻内容
        /// </summary>
        public string NewsContent { get; set; }


        /// <summary>
        /// 评论列表
        /// </summary>
        public List<NewsComment> Comments { get; set; }

        /// <summary>
        /// 评论总数
        /// </summary>
        public long CommentsCount { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public long CurrentPage { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        public long TotalRecords { get; set; }
    }

    /// <summary>
    /// 评论model
    /// </summary>
    public class NewsComment
    {

        /// <summary>
        /// 新闻评论主键id
        /// </summary>
        public string NewsCommentId { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 评论人
        /// </summary>
        public string CreateBy { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// 新闻id
        /// </summary>
        public string NewsId { get; set; }

        /// <summary>
        /// cd key
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 会员头像图片地址
        /// </summary>
        public string HeadImageUrl { get; set; }

        /// <summary>
        /// 会员昵称
        /// </summary>
        public string NickName { get; set; }

    }
}
