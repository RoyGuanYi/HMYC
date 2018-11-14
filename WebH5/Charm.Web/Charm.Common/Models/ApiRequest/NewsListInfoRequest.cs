using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class NewsListInfoRequest:ApiRequestBase
    {
        /// <summary>
        /// 每页条数
        /// </summary>
        public long pageSize { get; set; }
    }
}
