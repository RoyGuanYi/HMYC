using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
    /// <summary>
    /// 获取商家请求参数
    /// </summary>
    public  class GetBrandRequest: BaseApiRequest
    {
        /// <summary>
        /// 用户账户 BrandId为空时必填
        /// </summary>
        public string UserAccount { get; set; }

        /// <summary>
        /// 用户密码 BrandId为空时必填
        /// </summary>
        public string UserPassword { get; set; }

        /// <summary>
        /// 商品id 选填
        /// </summary>
        public string BrandId { get; set; }

       
    }
}
