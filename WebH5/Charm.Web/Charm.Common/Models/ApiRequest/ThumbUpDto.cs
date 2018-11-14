using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    /// <summary>
    /// 魅力圈点赞
    /// </summary>
    public class ThumbUpDto
    {
        /// <summary>
        /// 魅力圈id
        /// </summary>
        public string ArticleId { get; set; }

        /// <summary>
        /// 人员id
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string Token { get; set; }

    }
}
