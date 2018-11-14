using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class NewsInfoRequestById:ApiRequestBase
    {
        /// <summary>
        /// 新闻Id
        /// </summary>
        public String newId { get; set; }


        /// <summary>
        /// 每页条数
        /// </summary>
        public long pageSize { get; set; }
    }
}
