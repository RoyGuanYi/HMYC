using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiResponse
{
    public class CharmListInfoResponse
    {
        /// <summary>
        /// 魅力圈列表（分页）
        /// </summary>
        public Page<CharmInfo> ArticleListInfo { get; set; }

    }
}
