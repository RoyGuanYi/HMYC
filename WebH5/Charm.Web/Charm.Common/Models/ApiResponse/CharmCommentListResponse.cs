using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiResponse
{
    public class CharmCommentListResponse : ApiResponseBase
    {

        /// <summary>
        /// 会员评论
        /// </summary>
        public Page<ArticleComment> MemberComments { get; set; }

        /// <summary>
        /// 总评论数
        /// </summary>
        public long CommentCounts { get; set; }

    }

    //public class ArticleComment
    //{

    //    /// <summary>
    //    /// 魅力圈评论主键id
    //    /// </summary>
    //    public string Id { get; set; }

    //    /// <summary>
    //    ///子评论
    //    /// </summary>
    //    public string ParentId { get; set; }

    //    /// <summary>
    //    /// 评论内容
    //    /// </summary>
    //    public string CommentContent { get; set; }

    //    /// <summary>
    //    /// 魅力圈id
    //    /// </summary>
    //    public string ArticleId { get; set; }

    //    /// <summary>
    //    ///修改人
    //    /// </summary>
    //    public string UpdateBy { get; set; }

    //    /// <summary>
    //    /// 修改时间
    //    /// </summary>
    //    public DateTime UpdateOn { get; set; }

    //    /// <summary>
    //    /// 昵称
    //    /// </summary>
    //    public string NickName { get; set; }

    //    /// <summary>
    //    /// 头像
    //    /// </summary>
    //    public string HeadImageUrl { get; set; }


    //}
}
