using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
    /// <summary>
    /// 创建品牌
    /// </summary>
    public class CreateBrandRequest:BaseApiRequest
    {  

        /// <summary>
        /// 品牌名字必填
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 品牌logo 必填
        /// </summary>
        public string BrandLogo { get; set; }
        /// <summary>
        /// 品牌描述
        /// </summary>
        public string BrandDesc { get; set; }

        /// <summary>
        /// 品牌网站全地址
        /// </summary>
        public string SiteUrl { get; set; }

      
        /// <summary>
        /// 品牌电话
        /// </summary>
        public string BrandPhone { get; set; }


        /// <summary>
        /// /账户
        /// </summary>
        public string UserAccount { get; set; }

        /// <summary>
        /// 密码 必填
        /// </summary>
        public string UserPassword { get; set; }


    }
}
