using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charm.Common.Models.ApiResponse
{
    public class Page<T>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public long CurrentPage { get; set; }
        /// <summary>
        /// 总分页数
        /// </summary>
        public long TotalPages { get; set; }
        /// <summary>
        /// 总记录数
        /// </summary>
        public long TotalRecords { get; set; }
        /// <summary>
        /// 每页记录数
        /// </summary>
        public long PageSize { get; set; }
        /// <summary>
        /// 记录集
        /// </summary>
        public List<T> Items { get; set; }
        public object Context { get; set; }
    }
}
