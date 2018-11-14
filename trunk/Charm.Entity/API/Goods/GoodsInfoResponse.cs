using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Goods
{
    /// <summary>
    /// 商品响应参数
    /// </summary>
    public  class GoodsInfoResponse:BaseApiReponse
    {
        public List<GoodsInfo> Goods { get; set; }
    }
}
