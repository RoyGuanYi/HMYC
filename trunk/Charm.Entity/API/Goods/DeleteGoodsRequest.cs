using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Goods
{
    public class DeleteGoodsRequest:BaseApiRequest
    {
        /// <summary>
        /// 商品id 必填
        /// </summary>
        public string  GoodsId{ get; set; }
    }
}
