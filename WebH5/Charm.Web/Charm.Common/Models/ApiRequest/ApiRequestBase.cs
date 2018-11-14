using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class ApiRequestBase
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public long CurrentPage { get; set; }

        /// <summary>
        /// 加密协议
        /// </summary>
        public string Token { get; set; }


        ///// <summary>
        /////（分页）每页条数
        ///// </summary>
        //public long PageSize { get; set; }

    }
}
