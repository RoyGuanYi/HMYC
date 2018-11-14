using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API
{
    /// <summary>
    /// api请求基础参数
    /// </summary>
    public class BaseApiRequest
    {
        /// <summary>
        /// Token 必填
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public string CurrentPage { get; set; }


        /// <summary>
        /// 总页数
        /// </summary>
        public string TotalPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        public string  PageSize { get; set; }

        /// <summary>
        /// 是否需要分页
        /// </summary>
        public bool IsNeedPage { get; set; }
    }
}
