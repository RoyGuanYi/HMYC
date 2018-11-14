using System;

namespace Charm.Common.Models.ApiResponse
{
    public class ApiResponseBase
    {
        /// <summary>
        /// 响应码
        /// </summary>
        public int RspCode { get; set; }
        /// <summary>
        /// 响应描述
        /// </summary>
        public string RspDesc { get; set; }
        /// <summary>
        /// 响应错误信息
        /// </summary>
        public string RspErrorMsg { get; set; }

        /// <summary>
        /// 响应时间    
        /// </summary>
        public DateTime RspTime { get; set; }

    }
}
