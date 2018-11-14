using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
    /// <summary>
    /// 更新品牌响应结果
    /// </summary>
    public class UpdateBrandResponse:BaseApiReponse
    {
        /// <summary>
        /// 品牌信息
        /// </summary>
        public BrandInfo BrandInfo { get; set; }
    }
}
