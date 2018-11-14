using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class CharmListInfoRequest:ApiRequestBase
    {
        /// <summary>
        /// 魅力圈列表（分页）每页条数
        /// </summary>
        public long pageSize { get; set; }

        /// <summary>
        /// 魅力圈评论当前页
        /// </summary>
        public long commentCurrentPage { get; set; }

        /// <summary>
        /// 魅力圈评论每页条数
        /// </summary>
        public long commentPageSize { get; set; }

        /// <summary>
        /// 会员id 
        /// </summary>
        public string memberId { get; set; }

    }
}
