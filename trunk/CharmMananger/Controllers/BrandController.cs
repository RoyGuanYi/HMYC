using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Charm.Entity.Business;
using Charm.MvcExt.Base;
using Charm.MvcExt.Extisions;
using Charm.Services.GenServices.Business;
using CharmMananger.Models.Business;
using Microsoft.Practices.Unity;
using Charm.Common;

namespace CharmMananger.Controllers
{
    public class BrandController : BaseController
    {
        [Dependency]
        public ICharmBusinessBrandService CharmBusinessBrandService { get; set; }

        public ActionResult Index(int? page)
        {
            var p = page ?? 1;
            var models = this.CharmBusinessBrandService.GetModels(p, 5, string.Empty, "Brand_Id", null);
            var pm = this.Kernel.CreatePageModel(5, p, models.TotalCount);
            var dtos = Mapper.Map<List<CharmBusinessBrandDTO>>(models.Models);

            this.ViewBag.PM = pm;

            if (dtos == null)
                dtos = new List<CharmBusinessBrandDTO>();

            return this.View(dtos);
        }

        public ActionResult Details(Guid brandId)
        {
            var entity = this.CharmBusinessBrandService.GetModel(brandId);
            var model = Mapper.Map<CharmBusinessBrandDTO>(entity);

            return this.View(model);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(CharmBusinessBrandDTO model)
        {
            var entity = Mapper.Map<CharmBusinessBrand>(model);
            entity.Brand_Id = Guid.NewGuid();
            entity.UserPassword = Md5Encode.Encode(model.NewUserPassword);
            entity.Create_By = CurrentUser.UserName;
            entity.Create_Time = DateTime.Now;
            entity.Modify_By = CurrentUser.UserName;
            entity.Modify_Time = DateTime.Now;

            this.CharmBusinessBrandService.Add(entity);

            return this.View("jump");
        }

        public ActionResult Edit(Guid brandId)
        {
            var entity = this.CharmBusinessBrandService.GetModel(brandId);
            var model = Mapper.Map<CharmBusinessBrandDTO>(entity);

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Edit(CharmBusinessBrandDTO model)
        {
            var entity = this.CharmBusinessBrandService.GetModel(model.Brand_Id);

            entity.Brand_Name = model.Brand_Name;
            entity.Brand_Logo = model.Brand_Logo;
            entity.Brand_Desc = model.Brand_Desc;
            entity.Site_Url = model.Site_Url;
            entity.Site_Short_Url = model.Site_Short_Url;
            entity.Sort_Order = model.Sort_Order;
            entity.Is_Show = model.Is_Show;
            entity.Is_Hot = model.Is_Hot;
            entity.Brand_Code = model.Brand_Code;
            entity.Brand_Phone = model.Brand_Phone;
            entity.UserAccount = model.UserAccount;
            entity.Modify_Time = DateTime.Now;
            entity.Modify_By = CurrentUser.UserName;

            if (!string.IsNullOrWhiteSpace(model.NewUserPassword))
            {
                entity.UserPassword = Md5Encode.Encode(model.NewUserPassword);
            }
            this.CharmBusinessBrandService.Modify(entity);

            return this.View("jump");
        }

        public ActionResult Delete(Guid brandId)
        {
            this.CharmBusinessBrandService.Delete(brandId);

            return this.RedirectToAction("Index");
        }
    }
}