using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models
{
    public class UserInfo
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string UserName { get; set; }

        public int Sex { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        public string IpAddress { get; set; }

        //手机号
        public string Phone { get; set; }

        //品牌id
        public string BrandId { get; set; }

        public UserTypeEnum UserType { get; set; }


    }

    public enum UserTypeEnum
    {
        /// <summary>
        /// 未知
        /// </summary>
        Other=0,
        /// <summary>
        /// 商家
        /// </summary>
        Brand=1,
        /// <summary>
        /// 用户
        /// </summary>
        User=2
    }
}
