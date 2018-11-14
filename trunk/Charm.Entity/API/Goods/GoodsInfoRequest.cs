using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Goods
{
    /// <summary>
    /// 商品信息请求参数
    /// </summary>
    public class GoodsInfoRequest:BaseApiRequest
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        public string BrandId { get; set; }

        /// <summary>
        /// 类别id
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public string GoodsId { get; set; }
       
    }
}
