using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Charm.Common;
using Charm.Entity.Role;
using Charm.MvcExt.Base;
using Charm.MvcExt.Extisions;
using Charm.Services.GenServices;
using CharmMananger.Models.Role;
using Microsoft.Practices.Unity;

namespace CharmMananger.Controllers
{
    public class ModuleController : BaseController
    {
        /// <summary>
        /// 菜单信息表
        /// </summary>
        [Dependency]
        public ICharmCommonMenuInfoService CommonMenuInfoService { get; set; }

        /// <summary>
        /// 模块管理
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult Index(int? page)
        {
            var p = page ?? 1;
            var models = this.CommonMenuInfoService.GetModels(p, Const.PAGESIZE, string.Empty, "Sort", null);
            var pm = this.Kernel.CreatePageModel(Const.PAGESIZE, p, models.TotalCount);
            var dtos = Mapper.Map<List<CharmCommonMenuInfoDTO>>(models.Models);

            this.ViewBag.PM = pm;

            if (dtos == null)
                dtos = new List<CharmCommonMenuInfoDTO>();

            return this.View(dtos);
        }

        /// <summary>
        /// 获得新增
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            var dto = new CharmCommonMenuInfoDTO() { Sort = this.GetMaxSort() }; //初始化页面DTO
            return this.View(dto);	//返回视图
        }

        /// <summary>
        /// 提交新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(CharmCommonMenuInfoDTO model)
        {
            var entity = Mapper.Map<CharmCommonMenuInfo>(model);
            entity.MenuId = Guid.NewGuid();
            entity.CreateBy = this.CurrentUser.UserName;
            entity.CreateDate = DateTime.Now;
            entity.ModifyBy = this.CurrentUser.UserName;
            entity.ModifyDate = DateTime.Now;
            entity.MenuName = model.MenuName;
            this.CommonMenuInfoService.Add(entity);

            this.TipS("保存成功！");

            return this.View("jump");
        }

        /// <summary>
        /// 获得编辑
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(Guid id)
        {
            var entity = this.CommonMenuInfoService.GetModel(id);
            var model = Mapper.Map<CharmCommonMenuInfoDTO>(entity);

            return this.View(model);
        }

        /// <summary>
        /// 提交编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(CharmCommonMenuInfoDTO model)
        {
            var entity = this.CommonMenuInfoService.GetModel(model.MenuId);
            entity.MenuName = model.MenuName;
            entity.IsAllowAnonymousAccess = model.IsAllowAnonymousAccess;
            entity.IsEnable = model.IsEnable;
            entity.Sort = model.Sort;
            entity.ModifyBy = this.CurrentUser.UserName;
            entity.ModifyDate = DateTime.Now;

            this.CommonMenuInfoService.Modify(entity);

            this.TipS("保存成功！");

            return this.View("jump");

        }

        #region 私有方法

        /// <summary>
        /// 获得最大排序号
        /// </summary>
        /// <returns></returns>
        private int GetMaxSort()
        {
            var sortNum = 1;    //排序号
            var entity = this.CommonMenuInfoService.GetModels("", null, "Sort DESC").FirstOrDefault();  //获取最大排序号的实体
            if (entity != null)
            {
                sortNum = entity.Sort.Value + 1;
            }
            return sortNum; //返回最大排序号
        }

        #endregion
    }
}