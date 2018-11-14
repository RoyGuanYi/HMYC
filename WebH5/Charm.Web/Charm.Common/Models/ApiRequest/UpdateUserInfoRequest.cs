using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class UpdateUserInfoRequest
    {
        //会员昵称
        public string MemberNickName { get; set; }

        //会员id
        public string MemberId { get; set; }

        //魅力圈图片地址list集合
        public string HeadImageUrl { get; set; }

        //账号
        public string MemberAccount { get; set; }

        /// <summary>
        /// 加密协议
        /// </summary>
        public string Token { get; set; }
    }
}
