using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Enum
{
    /// <summary>
    /// 会员来源
    /// </summary>
    public enum MemberSourceEnum
    {
        /// <summary>
        ///普通
        /// </summary>
        [Description("普通")]
        General =0,
        /// <summary>
        /// 微信
        /// </summary>
        [Description("微信")]
        Wechat =1
    }
}
