using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
    /// <summary>
    /// 类别请求参数
    /// </summary>
    public  class CategoryInfoRequest:BaseApiRequest
    {
        /// <summary>
        /// 类别id 
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 父类id
        /// </summary>
        public string ParentId { get; set; }
    }
}
