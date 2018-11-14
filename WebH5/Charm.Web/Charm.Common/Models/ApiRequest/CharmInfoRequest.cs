using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class CharmInfoRequest:ApiRequestBase
    {
        /// <summary>
        /// 指定魅力圈列表条数
        /// </summary>
        public long topNum { get; set; }
    }
}
