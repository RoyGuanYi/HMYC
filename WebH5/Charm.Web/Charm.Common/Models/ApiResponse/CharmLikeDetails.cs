using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiResponse
{
    public class CharmLikeDetails
    {
        /// <summary>
        /// 魅力圈id
        /// </summary>
        public string ArticleId { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        ///是否取消点赞0 可以点赞 1不可以点赞
        /// </summary>
        public int IsDelete { get; set; }

        /// <summary>
        /// 会员昵称
        /// </summary>
        public string MemberNickName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadImageUrl { get; set; }

    }
}
