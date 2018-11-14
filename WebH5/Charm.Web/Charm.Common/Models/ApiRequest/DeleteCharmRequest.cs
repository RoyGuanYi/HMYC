using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class DeleteCharmRequest
    {
        /// <summary>
        /// cdkey
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 人员id
        /// </summary>
        public string MemberId { get; set; }

        /// <summary>
        /// 魅力圈id
        /// </summary>
        public string ArticleId { get; set; }
    }
}
