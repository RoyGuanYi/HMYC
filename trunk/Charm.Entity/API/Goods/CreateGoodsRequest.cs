using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Goods
{
    /// <summary>
    /// 新建商品请求参数
    /// </summary>
    public class CreateGoodsRequest:BaseApiRequest
    {
        public GoodsInfo Goods { get; set;}


    }
}
