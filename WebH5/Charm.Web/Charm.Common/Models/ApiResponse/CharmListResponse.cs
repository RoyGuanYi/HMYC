using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.ApiResponse
{

    public class CharmListResponse : ApiResponseBase
    {
        
        /// <summary>
        /// 魅力圈集合
        /// </summary>
        public List<CharmInfo> ArticleList;
    }




    //public class CharmInfo
    //{
    //    /// <summary>
    //    /// 魅力圈主键id
    //    /// </summary>
    //    public string ArticleId { get; set; }

    //    /// <summary>
    //    /// 魅力圈名称
    //    /// </summary>
    //    public string ArticleName { get; set; }

    //    /// <summary>
    //    /// 魅力圈首页图片
    //    /// </summary>
    //    public string ArticleImageUrl { get; set; }

    //    /// <summary>
    //    /// 魅力圈创建人
    //    /// </summary>
    //    public string CreateBy { get; set; }

    //    /// <summary>
    //    /// 修改人
    //    /// </summary>
    //    public string UpdateBy { get; set; }

    //    /// <summary>
    //    /// cdkey
    //    /// </summary>
    //    public string Token { get; set; }
    //}
}
