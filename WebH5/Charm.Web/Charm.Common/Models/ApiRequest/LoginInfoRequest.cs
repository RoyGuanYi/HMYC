using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiRequest
{
    public class LoginInfoRequest
    {
        // <summary>
        /// 加密协议
        /// </summary>
        public string Token { get; set; }

        // <summary>
        /// 会员账号
        /// </summary>
        public string MemberAccount { get; set; }


        public string IP { get; set; }
    }
}
