using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Charm.Entity.Business;
using Charm.MvcExt.Base;
using Charm.MvcExt.Extisions;
using Charm.Services.GenServices.Business;
using CharmMananger.Models.Business;
using Microsoft.Practices.Unity;

namespace CharmMananger.Controllers
{
    public class CategoryController : BaseController
    {
        [Dependency]
        public ICharmMstCategoryService CharmMstCategoryService { get; set; }

        public ActionResult Index(int? page)
        {
            var p = page ?? 1;
            var models = this.CharmMstCategoryService.GetModels(p, 5, string.Empty, "Category_Id", null);
            var pm = this.Kernel.CreatePageModel(5, p, models.TotalCount);
            var dtos = Mapper.Map<List<CharmMstCategoryDTO>>(models.Models);

            this.ViewBag.PM = pm;

            if (dtos == null)
                dtos = new List<CharmMstCategoryDTO>();

            return this.View(dtos);
        }

        public ActionResult Details(int categoryId)
        {
            var entity = this.CharmMstCategoryService.GetModel(categoryId);
            var model = Mapper.Map<CharmMstCategoryDTO>(entity);

            return this.View(model);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(CharmMstCategoryDTO model)
        {
            var entity = Mapper.Map<CharmMstCategory>(model);

            this.CharmMstCategoryService.Add(entity);

            return this.View("jump");
        }

        public ActionResult Edit(int categoryId)
        {
            var entity = this.CharmMstCategoryService.GetModel(categoryId);
            var model = Mapper.Map<CharmMstCategoryDTO>(entity);

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Edit(CharmMstCategoryDTO model)
        {
            var entity = this.CharmMstCategoryService.GetModel(model.Category_Id);

            entity.Category_Name = model.Category_Name;
            entity.Keywords = model.Keywords;
            entity.Category_Desc = model.Category_Desc;
            entity.Parent_id = model.Parent_id;
            entity.Sort_Order = model.Sort_Order;
            entity.Is_Show = model.Is_Show;
            this.CharmMstCategoryService.Modify(entity);

            return this.View("jump");
        }

        public ActionResult Delete(int categoryId)
        {
            this.CharmMstCategoryService.Delete(categoryId);
            return this.RedirectToAction("Index");
        }
    }
}