using System.Collections.Generic;

namespace Charm.Common.Models.ApiResponse
{
    public class NewsInfo:ApiResponseBase
    {
        /// <summary>
        /// 新闻数量
        /// </summary>
        public int NewsCount { get; set; }
        /// <summary>
        /// 新闻集合
        /// </summary>
        public List<NewsList> NewsList;

        /// <summary>
        /// 总页数
        /// </summary>
        public long TotalPages { get; set; }
    }


    public class NewsList
    {
        /// <summary>
        /// 新闻ID
        /// </summary>
        public string NewsId { get; set; }
        /// <summary>
        /// 新闻名称
        /// </summary>
        public string NewsName { get; set; }
        /// <summary>
        /// 标题图片地址
        /// </summary>
        public string TitleUrl { get; set; }

        /// <summary>
        ///新闻内容
        /// </summary>
        public string NewsContent { get; set; }
    }

}
