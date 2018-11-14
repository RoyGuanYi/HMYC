using AutoMapper;
using Charm.Common.Enum;
using Charm.MvcExt.Base;
using Charm.MvcExt.Extisions;
using Charm.Services.GenServices.Business;
using CharmMananger.Models.Business;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CharmMananger.Controllers.Goods
{
    public class CharmGoodsInfoController : BaseController
    {
        [Dependency]
        public ICharmGoodsInfoQueryService CharmGoodsInfoQueryService { get; set; }

        [Dependency]
        public ICharmMstGoodsService CharmMstGoodsService { get; set; }

        [Dependency]
        public ICharmBusinessBrandService CharmBusinessBrandService { get; set;}

        [Dependency]
        public ICharmMstCategoryService CharmMstCategoryService { get; set; }

        [Dependency]
        public ICharmMstGoodsImageService CharmMstGoodsImageService { get; set; }


        public ActionResult Index(CharmGoodsInfoDTO query ,int? page)
        {
          
            var where = new StringBuilder();
            var paras = new List<object>();

            if (!string.IsNullOrEmpty(query.Goods_Name))
            {
                paras.Add(query.Goods_Name);
                where.Append(" AND  Goods_Name LIKE '%' + ? + '%' ");
            }
            var p = page ?? 1;
            var models = this.CharmGoodsInfoQueryService.GetModels(p, 5,where.ToString(), "Goods_id", paras.ToArray());
            var pm = this.Kernel.CreatePageModel(5, p, models.TotalCount);
            var dtos = Mapper.Map<List<CharmGoodsInfoDTO>>(models.Models);

            this.ViewBag.PM = pm;

            if (dtos != null&&dtos.Count>0)
            {
                foreach (var item in dtos)
                {
                    if (item.Is_OnSale)
                    {
                       item.IsOnSaleShow= EnumOperate.GetEnumDesc(OnSaleEnum.Sale);
                    }
                    else
                    {
                        item.IsOnSaleShow = EnumOperate.GetEnumDesc(OnSaleEnum.UnSale);
                    }
                    if (item.Is_OnSale)
                    {
                        item.IsRealGoodsShow = EnumOperate.GetEnumDesc(GoodsTypeEnum.Real);
                    }
                    else
                    {
                        item.IsRealGoodsShow = EnumOperate.GetEnumDesc(GoodsTypeEnum.UnReal);
                    }
                }
            }
            else
            {
                dtos = new List<CharmGoodsInfoDTO>();
            }
            ViewBag.ModelList = dtos;
            return this.View(query);
        }

        public ActionResult Details(Guid goodsId)
        {
            var paras = new List<object>();
           
            var imageList = new List<CharmMstGoodsImageDTO>();
            var entity = this.CharmGoodsInfoQueryService.GetModels(" AND Goods_id=?", string.Empty,goodsId.ToString()).FirstOrDefault();
            if (entity == null)
            {
                return RedirectToAction("Index");
            }
            var model = Mapper.Map<CharmGoodsInfoDTO>(entity);
            if (model != null)
            {
                paras.Add(model.Goods_id);
                //产品图片
                var imageModels = CharmMstGoodsImageService.GetModels(" AND Goods_id=?", string.Empty, paras.ToArray() );
                imageList = Mapper.Map<List<CharmMstGoodsImageDTO>>(imageModels);

                //产品品牌
                var brandModel = CharmBusinessBrandService.GetModel(model.Brand_Id);
                model.Brand_Name = brandModel == null ? string.Empty : brandModel.Brand_Name;
                //大类名称
                var cateGoryModel = CharmMstCategoryService.GetModel(model.Category_Id);
                model.Category_Name = cateGoryModel == null ? string.Empty : cateGoryModel.Category_Name;
                //大类名称
                if (model.Is_OnSale)
                {
                    model.IsOnSaleShow = EnumOperate.GetEnumDesc(OnSaleEnum.Sale);
                }
                else
                {
                    model.IsOnSaleShow = EnumOperate.GetEnumDesc(OnSaleEnum.UnSale);
                }
                if (model.Is_OnSale)
                {
                    model.IsRealGoodsShow = EnumOperate.GetEnumDesc(GoodsTypeEnum.Real);
                }
                else
                {
                    model.IsRealGoodsShow = EnumOperate.GetEnumDesc(GoodsTypeEnum.UnReal);
                }
            }
            else
            {
                model = new CharmGoodsInfoDTO();
            }
            ViewBag.ImageList = imageList;
            return this.View(model);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(CharmGoodsInfoDTO model)
        {
            //var entity = Mapper.Map<CharmGoodsInfo>(model);

            //this.CharmGoodsInfoService.Add(entity);

            return this.View("jump");
        }

        public ActionResult Edit(Guid goods_id)
        {
            //var entity = this.CharmGoodsInfoService.GetModel(goods_id);
            //var model = Mapper.Map<CharmGoodsInfoDTO>(entity);

            //return this.View(model);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(CharmGoodsInfoDTO model)
        {
            //var entity = this.CharmGoodsInfoService.GetModel(model.Goods_id);

            //entity.Goods_Name = model.Goods_Name;
            //entity.Click_Count = model.Click_Count;
            //entity.Market_Price = model.Market_Price;
            //entity.Shop_Price = model.Shop_Price;
            //entity.Goods_Keywords = model.Goods_Keywords;
            //entity.Goods_Brief = model.Goods_Brief;
            //entity.Goods_Desc = model.Goods_Desc;
            //entity.Goods_Thumb_Img = model.Goods_Thumb_Img;
            //entity.Goods_Real_Img = model.Goods_Real_Img;
            //entity.Goods_Original_Img = model.Goods_Original_Img;
            //entity.Is_Real_Goods = model.Is_Real_Goods;
            //entity.Is_OnSale = model.Is_OnSale;
            //entity.Sort_Order = model.Sort_Order;
            //entity.Create_By = model.Create_By;
            //entity.Create_Time = model.Create_Time;
            //entity.Modify_By = model.Modify_By;
            //entity.Modify_Time = model.Modify_Time;
            //entity.Modify_By_Admin = model.Modify_By_Admin;
            //entity.Modify_Time_Admin = model.Modify_Time_Admin;
            //entity.Category_Id = model.Category_Id;
            //entity.Brand_Id = model.Brand_Id;
            //entity.Collection_Count = model.Collection_Count;
            //entity.Brand_Name = model.Brand_Name;
            //entity.Category_Name = model.Category_Name;

            //this.CharmGoodsInfoService.Modify(entity);

            return this.View("jump");
        }

        public ActionResult Delete(Guid goodsId)
        {
            this.CharmGoodsInfoQueryService.Delete(goodsId);

            return this.RedirectToAction("Index");
        }
    }

}