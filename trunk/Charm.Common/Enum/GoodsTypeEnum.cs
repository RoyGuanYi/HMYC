using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Enum
{
    public enum GoodsTypeEnum
    {
        /// <summary>
        ///虚物
        /// </summary>
        [Description("虚物")]
        UnReal =0,
        /// <summary>
        ///实物
        /// </summary>
        [Description("实物")]
        Real =1
    }
}
