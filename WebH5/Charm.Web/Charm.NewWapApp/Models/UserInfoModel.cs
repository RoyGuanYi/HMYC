using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charm.NewWapApp.Models
{
    public class UserInfoModel
    {
        //会员昵称
        public string MemberNickName { get; set; }

        //头像地址
        public string HeadImageUrl { get; set; }

        //账号（手机号）
        public string MemberAccount { get; set; }

        //会员ID
        public string MemberId { get; set; }

    }
}