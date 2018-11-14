namespace Charm.Common.Models.ApiRequest
{
    /// <summary>
    /// 发表评论
    /// </summary>
    public class CommentDTO
    {
        /// <summary>
        /// 魅力圈id
        /// </summary>
        public string ArticleId { get; set; }

        /// <summary>
        ///子评论
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 人员id
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string CommentContent { get; set; }

        /// <summary>
        /// 评论类型0客服1会员2教练
        /// </summary>
        public int CommentType { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string Token { get; set; }
    }
}