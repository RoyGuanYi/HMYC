using Charm.Entity.API.Goods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charm.NewWapApp.Models
{
    public class CharmModel
    {
        //魅力圈名称
        public string ArticleName { get; set; }

        //会员id
        public string MemberId { get; set; }

        //产品图片地址list集合
        public List<string> filePath { get; set; }

        //魅力圈内容
        public string ArticleContent { get; set; }

        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品点击次数
        /// </summary>
        public string ClickCount { get; set; }

        /// <summary>
        /// 市场价
        /// </summary>
        public string MarketPrice { get; set; }

        /// <summary>
        /// 门市价
        /// </summary>
        public string ShopPrice { get; set; }

        /// <summary>
        /// 商品关键词
        /// </summary>
        public string GoodsKeyWords { get; set; }

        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsBrief { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        public string GoodsDesc { get; set; }

        /// <summary>
        /// 是否实物 是：true 否 false
        /// </summary>
        public bool IsRealGoods { get; set; }

        /// <summary>
        /// 是否在售 是：1 否 0 必填
        /// </summary>
        public int IsOnSale { get; set; }

        /// <summary>
        /// 商品排序
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// 类别id 必填
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 品牌id 必填
        /// </summary>
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 点赞次数
        /// </summary>
        public string CollectionCount { get; set; }

        /// <summary>
        /// 商品图片集合
        /// </summary>
        public List<GoodsImage> Images { get; set; }

        public string ImageListJsonStr { get; set; }


    }
}