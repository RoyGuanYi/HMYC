using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiResponse
{
    public class LoginInfoResponse : ApiResponseBase
    {
        /// <summary>
        /// 会员昵称
        /// </summary>
        public string MemberNickName { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        public string MemberId { get; set; }


        /// <summary>
        /// 头像
        /// </summary>
        public string HeadImageUrl { get; set; }

        /// <summary>
        /// 会员账号
        /// </summary>

        public string MemberAccount { get; set; }

    }
}
