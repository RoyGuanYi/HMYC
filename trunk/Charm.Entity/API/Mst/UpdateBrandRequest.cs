using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Mst
{
    /// <summary>
    /// 更新品牌信息请求参数
    /// </summary>
    public class UpdateBrandRequest:BaseApiRequest
    {
        /// <summary>
        /// brandId 必填
        /// </summary>
        public string BrandId { get; set; }
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
        /// 品牌网站短地址
        /// </summary>
        public string SiteShortUrl { get; set; }

        /// <summary>
        /// 品牌电话
        /// </summary>
        public string BrandPhone { get; set; }


        /// <summary>
        /// 密码 必填
        /// </summary>
        public string UserPassword { get; set; }

        /// <summary>
        /// 账号 必填
        /// </summary>
        public string UserAccount { get; set; }

    }
}
