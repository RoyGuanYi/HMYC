using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.API.Goods
{
    public class GoodsInfo
    {
        /// <summary>
        ///商品id 新增 不填 编辑必填
        /// </summary>
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
        public string IsRealGoods { get; set; }

        /// <summary>
        /// 是否在售 是：true 否 false 必填
        /// </summary>
        public string IsOnSale { get; set; }

        /// <summary>
        /// 商品排序
        /// </summary>
        public string SortOrder { get; set; }

        /// <summary>
        /// 类别id 必填
        /// </summary>
        public string  CategoryId { get; set; }

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
        /// 品牌logo
        /// </summary>
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商品修改时间
        /// </summary>
        public string GoodsModifyTime { get; set; }

        /// <summary>
        /// 商品图片集合
        /// </summary>
        public List<GoodsImage> Images { get; set; }


    }

  
    public class GoodsImage {
        /// <summary>
        /// 图片id
        /// </summary>
        public string GoodsImageId { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品缩略图
        /// </summary>
        public string GoodsThumbImg { get; set; }

        /// <summary>
        /// 商品实际图片大小
        /// </summary>
        public string GoodsRealImg { get; set; }

        /// <summary>
        /// 商家上传图片
        /// </summary>
        public string GoodsOriginalImg { get; set; }

    }
}
