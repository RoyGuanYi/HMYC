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
using Charm.MvcExt.Filter;
using Charm.Services;
using Charm.Services.GenServices;
using CharmMananger.Models.Role;
using Microsoft.Practices.Unity;

namespace CharmMananger.Controllers
{
    [LoginFilter(Order = 1)]
    //[PermissionFilter(Order = 2)]
    //[ViewFilter(Order = 3)]
    public class RoleController : BaseController
    {
        [Dependency]
        public ICharmCommonRoleInfoService CommonRoleInfoService { get; set; }

        [Dependency]
        public ICharmCommonActionInfoService CommonActionInfoService { get; set; }

        [Dependency]
        public ICharmCommonRoleActionService CommonRoleActionService { get; set; }

        /// <summary>
        /// 角色管理
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public ActionResult Index(int? page)
        {
            var p = page ?? 1;
            var models = this.CommonRoleInfoService.GetModels(p, Const.PAGESIZE, string.Empty, "CreateDate", null);
            var pm = this.Kernel.CreatePageModel(Const.PAGESIZE, p, models.TotalCount);
            var dtos = Mapper.Map<List<CharmCommonRoleInfoDTO>>(models.Models);

            this.ViewBag.PM = pm;

            if (dtos == null)
                dtos = new List<CharmCommonRoleInfoDTO>();

            return this.View(dtos);
        }

        /// <summary>
        /// 获得新增
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return this.View();
        }

        /// <summary>
        /// 提交新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(CharmCommonRoleInfoDTO model)
        {
            var entity = Mapper.Map<CharmCommonRoleInfo>(model);
            entity.RoleId = Guid.NewGuid();
            entity.CreateBy = this.CurrentUser.UserName;
            entity.CreateDate = DateTime.Now;

            this.CommonRoleInfoService.Add(entity);

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
            var entity = this.CommonRoleInfoService.GetModel(id);
            var model = Mapper.Map<CharmCommonRoleInfoDTO>(entity);

            return this.View(model);
        }

        /// <summary>
        /// 提交编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(CharmCommonRoleInfoDTO model)
        {
            var entity = this.CommonRoleInfoService.GetModel(model.RoleId);
            entity.RoleName = model.RoleName;
            entity.RoleCode = model.RoleCode;
            entity.IsEnable = model.IsEnable;
            entity.IsSysDefault = model.IsSysDefault;
            entity.ModifyBy = this.CurrentUser.UserName;
            entity.ModifyDate = DateTime.Now;
            //entity.na = this.CurrentUser.Account;
            //entity.ModifyGuid = this.CurrentUser.Id;

            this.CommonRoleInfoService.Modify(entity);

            this.TipS("保存成功！");

            return this.View("jump");
        }

        /// <summary>
        /// 获得角色授权
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public ActionResult Authorization(Guid roleId)
        {
            //功能
            var actions = this.CommonActionInfoService.GetModels("", null, " a.MenuId, a.CategoryName, a.Sort");
            //角色与功能的关系
            var roleActions = this.CommonRoleActionService.GetModels(" AND RoleId = ?", string.Empty, roleId);

            this.ViewBag.RoleId = roleId;
            this.ViewBag.Actions = actions;
            this.ViewBag.RoleActions = roleActions;

            return View();
        }

        /// <summary>
        /// 提交角色授权
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="actionIds"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Authorization(Guid roleId, Guid[] actionIds)
        {
            this.CommonRoleActionService.Authorization(roleId, actionIds);

            this.TipS("保存成功！");

            return this.RedirectToAction("Authorization", new { roleId = roleId });
        }
    }
}