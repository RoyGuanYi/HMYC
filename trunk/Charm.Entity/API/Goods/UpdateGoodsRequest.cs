using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Goods
{
    /// <summary>
    /// 更新商品请求信息
    /// </summary>
    public class UpdateGoodsRequest:BaseApiRequest
    {
        /// <summary>
        /// 商品
        /// </summary>
        public GoodsInfo Goods { get; set; }
    }
}
