using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Enum
{
    public enum OnSaleEnum
    {
        /// <summary>
        ///未售
        /// </summary>
        [Description("未售")]
        UnSale =0,
        /// <summary>
        ///在售
        /// </summary>
        [Description("在售")]
        Sale =1
    }
}
