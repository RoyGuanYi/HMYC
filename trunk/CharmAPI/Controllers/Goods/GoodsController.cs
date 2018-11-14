using Charm.Common.Enum;
using Charm.Entity.API;
using Charm.Entity.API.Goods;
using Charm.Entity.Business;
using Charm.MvcExt.Base;
using Charm.Services.GenServices.Business;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Unity.Attributes;

namespace CharmAPI.Controllers.Goods
{
    /// <summary>
    /// 商品
    /// </summary>
    public class GoodsController : BaseApiController
    {
        /// <summary>
        /// 商品查询
        /// </summary>
        [Dependency]
        public  ICharmGoodsInfoQueryService CharmGoodsInfoQueryService { get; set; }

        /// <summary>
        /// 商品图片服务
        /// </summary>
        [Dependency]
        public ICharmMstGoodsImageService CharmMstGoodsImageService { get; set; }

        /// <summary>
        /// 商品服务
        /// </summary>
        [Dependency]
        public ICharmMstGoodsService CharmMstGoodsService { get; set; }

        /// <summary>
        /// 类别服务
        /// </summary>
        [Dependency]
        public ICharmMstCategoryService CharmMstCategoryService { get; set; }

        /// <summary>
        /// 品牌服务
        /// </summary>
        [Dependency]
        public ICharmBusinessBrandService CharmBusinessBrandService { get; set; }



        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("api/Goods/GetGoodsInfo")]
        public GoodsInfoResponse GetGoodsInfo([FromUri] GoodsInfoRequest request)
        {
            GoodsInfoResponse response = new GoodsInfoResponse();
            int pageIndex = 1;
            int pageSize = 1;
            string GoodsIds = string.Empty;
            if (string.IsNullOrWhiteSpace(request.Token) || !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }

            if ((string.IsNullOrWhiteSpace(request.CurrentPage) || string.IsNullOrWhiteSpace(request.PageSize)) && request.IsNeedPage)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "分页参数必填";
                return response;
            }
            else
            {
                pageIndex = Convert.ToInt32(request.CurrentPage);
                pageSize = Convert.ToInt32(request.PageSize);
            }

            var where = new StringBuilder();
            var paras = new List<object>();

            if (!string.IsNullOrEmpty(request.BrandId))
            {
                paras.Add(new Guid(request.BrandId));
                where.Append(" AND good.Brand_Id=? ");
            }
            if (!string.IsNullOrEmpty(request.CategoryId))
            {
                paras.Add(request.CategoryId);
                where.Append(" AND good.Category_Id=? ");
            }
            if (!string.IsNullOrEmpty(request.GoodsId))
            {
                paras.Add(new Guid(request.GoodsId));
                where.Append(" AND good.Goods_id=? ");
            }

            if (request.IsNeedPage)
            {
                var models = CharmGoodsInfoQueryService.GetModels(pageIndex, pageSize, where.ToString(), "Sort_Order desc", paras.ToArray());
                if (models != null && models.Models != null && models.Models.Count > 0)
                {
                    response.Goods = new List<GoodsInfo>();
                    foreach (var item in models.Models)
                    {
                        var model = new GoodsInfo()
                        {
                            GoodsId = item.Goods_id.ToString(),
                            BrandId = item.Brand_Id.ToString(),
                            BrandName = item.Brand_Name,
                            GoodsName = item.Goods_Name,
                            ClickCount = item.Click_Count.ToString(),
                            MarketPrice = item.Market_Price.ToString(),
                            ShopPrice = item.Shop_Price.ToString(),
                            GoodsKeyWords = item.Goods_Keywords,
                            GoodsBrief = item.Goods_Brief,
                            GoodsDesc = item.Goods_Desc,
                            IsRealGoods = item.Is_Real_Goods.ToString(),
                            IsOnSale = item.Is_OnSale.ToString(),
                            SortOrder = item.Sort_Order.ToString(),
                            CategoryId = item.Category_Id.ToString(),
                            CategoryName = item.Category_Name,
                            CollectionCount = item.Collection_Count.ToString(),
                            BrandLogo=item.Brand_Logo
                        };
                        response.Goods.Add(model);
                    }
                    response.CurrentPage = pageIndex;
                    response.PageSize = pageSize;
                    response.TotalPage = (models.TotalCount % pageSize == 0 ? models.TotalCount / pageSize : models.TotalCount / pageSize + 1);
                }
            }
            else
            {
                var models= CharmGoodsInfoQueryService.GetModels(where.ToString(), "Sort_Order desc", paras.ToArray());
                if (models != null&&  models.Count > 0)
                {
                    response.Goods = new List<GoodsInfo>();
                    foreach (var item in models)
                    {
                        var model = new GoodsInfo()
                        {
                            GoodsId = item.Goods_id.ToString(),
                            BrandId = item.Brand_Id.ToString(),
                            BrandName = item.Brand_Name,
                            GoodsName = item.Goods_Name,
                            ClickCount = item.Click_Count.ToString(),
                            MarketPrice = item.Market_Price.ToString(),
                            ShopPrice = item.Shop_Price.ToString(),
                            GoodsKeyWords = item.Goods_Keywords,
                            GoodsBrief = item.Goods_Brief,
                            GoodsDesc = item.Goods_Desc,
                            IsRealGoods = item.Is_Real_Goods.ToString(),
                            IsOnSale = item.Is_OnSale.ToString(),
                            SortOrder = item.Sort_Order.ToString(),
                            CategoryId = item.Category_Id.ToString(),
                            CategoryName = item.Category_Name,
                            CollectionCount = item.Collection_Count.ToString(),
                            BrandLogo = item.Brand_Logo,
                            GoodsModifyTime = item.Modify_Time.ToString()
                        };
                        response.Goods.Add(model);
                    }
                }
            }
            //图片
            if (response.Goods != null && response.Goods.Count > 0)
            {
                var imgparas = new List<object>();
                var imgStr = string.Empty;
                for (int i = 0; i < response.Goods.Count; i++)
                {
                    imgStr += "?"+",";
                    imgparas.Add(new Guid(response.Goods[i].GoodsId));
                }
                var imgwhere = string.Format(@" AND Goods_Id in ({0})", imgStr.Trim(','));
                var imgModels = CharmMstGoodsImageService.GetModels(imgwhere, string.Empty, imgparas.ToArray());
                if (imgModels != null && imgModels.Count > 0)
                {
                    foreach (var item in response.Goods)
                    {
                        item.Images = new List<GoodsImage>();
                        foreach (var itemImge in imgModels)
                        {
                            if (item.GoodsId == itemImge.Goods_Id.ToString())
                            {
                                item.Images.Add(new GoodsImage()
                                {
                                    GoodsImageId = itemImge.Goods_Image_Id.ToString(),
                                    GoodsId = itemImge.Goods_Id.ToString(),
                                    GoodsOriginalImg = itemImge.Goods_Original_Img,
                                    GoodsRealImg = itemImge.Goods_Real_Img,
                                    GoodsThumbImg = itemImge.Goods_Thumb_Img
                                });
                            }
                        }
                    }
                }

            }
            response.RspCode = ReponseCode.Success.GetHashCode();
            response.RspDesc = "商品查询成功";
            return response;         
        }

        /// <summary>
        /// 创建商品
        /// </summary>
        /// <param name="request">商品创建参数</param>
        /// <returns></returns>
        [HttpPost, Route("api/Goods/CreateGoodsInfo")]
        public CreateGoodsResponse CreateGoodsInfo([FromBody] CreateGoodsRequest request)
        {
            CreateGoodsResponse response = new CreateGoodsResponse();
            #region 验证
            if (string.IsNullOrWhiteSpace(request.Token) || !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }
            if (request.Goods==null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品信息不能为空";
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.Goods.GoodsName))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品名称不能为空";
                return response;
            }
            decimal marketPrice = 0;
            if (string.IsNullOrWhiteSpace(request.Goods.MarketPrice)||!Decimal.TryParse(request.Goods.MarketPrice,out marketPrice))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品市场价格不能为空或者非数字类型";
                return response;
            }
            decimal shopPrice = 0;
            if (string.IsNullOrWhiteSpace(request.Goods.ShopPrice) || !Decimal.TryParse(request.Goods.ShopPrice, out shopPrice))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "门店价格不能为空或者非数字类型";
                return response;
            }
            int categoryId = -1;
            if (string.IsNullOrWhiteSpace(request.Goods.CategoryId)|| !Int32.TryParse(request.Goods.CategoryId,out categoryId))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品类别不能为空";
                return response;
            }
            var existCateGory = CharmMstCategoryService.GetModel(categoryId);
            if (existCateGory==null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品类别不存在";
                return response;
            }
          
            if (string.IsNullOrWhiteSpace(request.Goods.BrandId))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌不能为空";
                return response;
            }
            var existBrand = CharmBusinessBrandService.GetModel(new Guid(request.Goods.BrandId));
            if (existBrand==null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌不存在";
                return response;
            }
            int isOnSale = -1;
            if (string.IsNullOrWhiteSpace(request.Goods.IsOnSale)|| !Int32.TryParse(request.Goods.IsOnSale,out isOnSale))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "是否在售必填";
                return response;
            }
            int sortOrder = -1;
            if (!string.IsNullOrWhiteSpace(request.Goods.SortOrder) && !Int32.TryParse(request.Goods.SortOrder, out sortOrder))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "排序值必须是数字";
                return response;
            }
            else if(string.IsNullOrWhiteSpace(request.Goods.SortOrder))
            {
                sortOrder = -1;
            }
           
            if (request.Goods.Images==null||request.Goods.Images.Count==0)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品图片不能为空";
                return response;
            }

            #endregion


            var model = new CharmMstGoods()
            {
                Goods_id = Guid.NewGuid(),
                Goods_Name = request.Goods.GoodsName,
                Click_Count = 0,
                Market_Price = marketPrice,
                Shop_Price = marketPrice,
                Goods_Keywords = request.Goods.GoodsKeyWords,
                Goods_Brief = request.Goods.GoodsBrief,
                Goods_Desc = request.Goods.GoodsDesc,
                Is_Real_Goods = null,
                Create_By= existBrand.UserAccount,
                Create_Time=DateTime.Now,
                Modify_By = existBrand.UserAccount,
                Modify_Time = DateTime.Now,
                Category_Id =categoryId,
                Brand_Id=new Guid(request.Goods.BrandId),
                Collection_Count=0
            };
            if (sortOrder == -1)
            {
                model.Sort_Order = null;
            }
            else
            {
                model.Sort_Order = sortOrder;
            }
            if (isOnSale == -1)
            {
                model.Is_OnSale = null;
            }
            else
            {
                model.Is_OnSale = isOnSale==0?false:true;
            }
            var imgList = new List<CharmMstGoodsImage>();
            foreach (var item in request.Goods.Images)
            {
                var img = new CharmMstGoodsImage() {
                    Goods_Id=model.Goods_id,
                    Goods_Image_Id=Guid.NewGuid(),
                    Goods_Original_Img=item.GoodsOriginalImg,
                    Goods_Real_Img=item.GoodsRealImg,
                    Goods_Thumb_Img=item.GoodsThumbImg, 
                };
                imgList.Add(img);
            }
            if (CharmGoodsInfoQueryService.Add(model, imgList))
            {
                response.GoodsId = model.Goods_id.ToString();
            }
            else
            {
                response.RspCode = ReponseCode.AddFail.GetHashCode();
                response.RspDesc = "商品添加失败";
                return response;
            }
            response.RspCode = ReponseCode.Success.GetHashCode();
            response.RspDesc = "商品添加成功";
            return response;
        }

        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="request">商品创建参数</param>
        /// <returns></returns>
        [HttpPost, Route("api/Goods/UpdateGoodsInfo")]
        public BaseApiReponse UpdateGoodsInfo([FromBody] UpdateGoodsRequest request)
        {
            BaseApiReponse response = new BaseApiReponse();
            #region 验证
            if (string.IsNullOrWhiteSpace(request.Token) || !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }
            if (request.Goods == null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品信息不能为空";
                return response;
            }
            if (string.IsNullOrEmpty(request.Goods.GoodsId))
            {

                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品id不能为空";
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.Goods.GoodsName))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品名称不能为空";
                return response;
            }
            decimal marketPrice = 0;
            if (string.IsNullOrWhiteSpace(request.Goods.MarketPrice) || !Decimal.TryParse(request.Goods.MarketPrice, out marketPrice))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品市场价格不能为空或者非数字类型";
                return response;
            }
            decimal shopPrice = 0;
            if (string.IsNullOrWhiteSpace(request.Goods.ShopPrice) || !Decimal.TryParse(request.Goods.ShopPrice, out shopPrice))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "门店价格不能为空或者非数字类型";
                return response;
            }
            int categoryId = -1;
            if (string.IsNullOrWhiteSpace(request.Goods.CategoryId) || !Int32.TryParse(request.Goods.CategoryId, out categoryId))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品类别不能为空";
                return response;
            }
            var existCateGory = CharmMstCategoryService.GetModel(categoryId);
            if (existCateGory == null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品类别不存在";
                return response;
            }

            if (string.IsNullOrWhiteSpace(request.Goods.BrandId))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌不能为空";
                return response;
            }
            var existBrand = CharmBusinessBrandService.GetModel(new Guid(request.Goods.BrandId));
            if (existBrand == null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌不存在";
                return response;
            }
            int isOnSale = -1;
            if (string.IsNullOrWhiteSpace(request.Goods.IsOnSale) || !Int32.TryParse(request.Goods.IsOnSale, out isOnSale))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "是否在售必填";
                return response;
            }
            int sortOrder = -1;
            if (!string.IsNullOrWhiteSpace(request.Goods.SortOrder) && !Int32.TryParse(request.Goods.SortOrder, out sortOrder))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "排序值必须是数字";
                return response;
            }
            else if (string.IsNullOrWhiteSpace(request.Goods.SortOrder))
            {
                sortOrder = -1;
            }

            if (request.Goods.Images == null || request.Goods.Images.Count == 0)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品图片不能为空";
                return response;
            }
            var oldModel = CharmMstGoodsService.GetModel(new Guid(request.Goods.GoodsId));
            if (oldModel==null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品不存在";
                return response;
            }
            #endregion
            oldModel.Goods_Name = request.Goods.GoodsName;
            oldModel.Market_Price = marketPrice;
            oldModel.Shop_Price = marketPrice;
            oldModel.Goods_Brief = request.Goods.GoodsBrief;
            oldModel.Goods_Desc = request.Goods.GoodsDesc;
            oldModel.Is_Real_Goods = null;
            oldModel.Modify_By = existBrand.UserAccount;
            oldModel.Modify_Time = DateTime.Now;
            oldModel.Category_Id = categoryId;
            if (sortOrder == -1)
            {
                oldModel.Sort_Order = null;
            }
            else
            {
                oldModel.Sort_Order = sortOrder;
            }
            if (isOnSale == -1)
            {
                oldModel.Is_OnSale = null;
            }
            else
            {
                oldModel.Is_OnSale = isOnSale == 0 ? false : true;
            }
            var imgList = new List<CharmMstGoodsImage>();
            foreach (var item in request.Goods.Images)
            {
                var img = new CharmMstGoodsImage()
                {
                    Goods_Id = oldModel.Goods_id,
                    Goods_Image_Id = Guid.NewGuid(),
                    Goods_Original_Img = item.GoodsOriginalImg,
                    Goods_Real_Img = item.GoodsRealImg,
                    Goods_Thumb_Img = item.GoodsThumbImg,
                };
                imgList.Add(img);
            }
            if (!CharmGoodsInfoQueryService.Update(oldModel, imgList))
            {
                response.RspCode = ReponseCode.AddFail.GetHashCode();
                response.RspDesc = "商品更新失败";
                return response;
            }
            response.RspCode = ReponseCode.Success.GetHashCode();
            response.RspDesc = "商品更新成功";
            return response;
        }

        /// <summary>
        /// 删除商品
        /// </summary>
        /// <param name="request">商品创建参数</param>
        /// <returns></returns>
        [HttpPost, Route("api/Goods/DeleteGoodsInfo")]
        public BaseApiReponse DeleteGoodsInfo([FromBody] DeleteGoodsRequest request)
        {
            BaseApiReponse response = new BaseApiReponse();
            #region 验证
            if (string.IsNullOrWhiteSpace(request.Token) || !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }
           
            if (string.IsNullOrEmpty(request.GoodsId))
            {

                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品id不能为空";
                return response;
            }
            var oldModel = CharmMstGoodsService.GetModel(new Guid(request.GoodsId));
            if (oldModel == null)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "商品不存在";
                return response;
            }
            #endregion
            if (!CharmGoodsInfoQueryService.Delete(new Guid(request.GoodsId)))
            {
                response.RspCode = ReponseCode.AddFail.GetHashCode();
                response.RspDesc = "商品删除失败";
                return response;
            }
            response.RspCode = ReponseCode.Success.GetHashCode();
            response.RspDesc = "商品删除成功";
            return response;
        }
    }
}
