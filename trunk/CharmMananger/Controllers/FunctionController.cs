using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Charm.Common;
using Charm.Entity.Role;
using Charm.MvcExt.Base;
using Charm.MvcExt.Extisions;
using Charm.MvcExt.Filter;
using Charm.Services.GenServices;
using CharmMananger.Models.Role;
using Microsoft.Practices.Unity;

namespace CharmMananger.Controllers
{
    [LoginFilter(Order = 1)]        //登录验证过滤器
    [PermissionFilter(Order = 2)]	//权限验证过滤器
    //[ViewFilter(Order = 3)]			//浏览追踪过滤器
    public class FunctionController : BaseController
    {
        /// <summary>
        /// 功能信息表
        /// </summary>
        [Dependency]
        public ICharmCommonActionInfoService CommonActionInfoService { get; set; }

        /// <summary>
        /// 功能管理
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public ActionResult Index(CharmCommonActionInfoDTO query, int? page)
        {
            var where = new StringBuilder();
            var paras = new List<object>();

            paras.Add(query.MenuId);
            where.Append(" AND b.MenuId = ? ");

            if (!string.IsNullOrEmpty(query.ActionCategoryName))
            {
                paras.Add(query.ActionCategoryName);
                where.Append(" AND  ActionCategoryName LIKE '%' + ? + '%' ");
            }

            if (!string.IsNullOrEmpty(query.ActionName))
            {
                paras.Add(query.ActionName);
                where.Append(" AND ActionName LIKE '%' + ? + '%' ");
            }

            if (!string.IsNullOrEmpty(query.ActionUrl))
            {
                paras.Add(query.ActionUrl);
                where.Append(" AND ActionUrl LIKE '%' + ? + '%' ");
            }
            var p = page ?? 1;
            var models = this.CommonActionInfoService.GetModels(p, Const.PAGESIZE, where.ToString(), "ActionCategoryName, Sort", paras.ToArray());
            var pm = this.Kernel.CreatePageModel(Const.PAGESIZE, p, models.TotalCount);
            var dtos = Mapper.Map<List<CharmCommonActionInfoDTO>>(models.Models);

            if (dtos == null)
                dtos = new List<CharmCommonActionInfoDTO>();

            this.ViewBag.PM = pm;
            this.ViewBag.Functions = dtos;

            return this.View(query);
        }

        /// <summary>
        /// 获得新增
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        public ActionResult Create(Guid modelId)
        {
            var model = new CharmCommonActionInfoDTO();
            model.MenuId = modelId; //菜单ID
            model.Sort = this.GetMaxSort(modelId);	//排序

            return this.View(model);
        }

        /// <summary>
        /// 提交新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(CharmCommonActionInfoDTO model)
        {
            var entity = Mapper.Map<CharmCommonActionInfo>(model);
            entity.ActionId = Guid.NewGuid();
            entity.CreateBy = this.CurrentUser.UserName;
            entity.CreateDate = DateTime.Now;
            entity.ModifyBy = this.CurrentUser.UserName;
            entity.ModifyDate = DateTime.Now;
            this.CommonActionInfoService.Add(entity);

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
            var entity = this.CommonActionInfoService.GetModel(id);
            var model = Mapper.Map<CharmCommonActionInfoDTO>(entity);

            return this.View(model);
        }

        /// <summary>
        /// 提交编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(CharmCommonActionInfoDTO model)
        {
            var entity = this.CommonActionInfoService.GetModel(model.ActionId);
            entity.ActionCategoryName = model.ActionCategoryName;
            entity.ActionName = model.ActionName;
            entity.ActionUrl = model.ActionUrl;
            entity.IsEnable = model.IsEnable;
            entity.IsVisible = model.IsVisible;
            entity.IsLog = model.IsLog;
            entity.Operation = (int)model.Operation;
            entity.Sort = model.Sort;
            entity.ModifyBy = this.CurrentUser.UserName;
            entity.ModifyDate = DateTime.Now;

            this.CommonActionInfoService.Modify(entity);

            this.TipS("保存成功！");

            return this.View("jump");
        }

        #region 私有方法

        /// <summary>
        /// 获得最大排序号
        /// </summary>
        /// <returns></returns>
        private int GetMaxSort(Guid modelId)
        {
            var sortNum = 1;    //排序号
            var entity = this.CommonActionInfoService.GetModels(" AND b.MenuId = ?", "Sort DESC",
                modelId).FirstOrDefault(); //获取最大排序号的实体

            if (entity != null)
            {
                sortNum = entity.Sort.Value + 1;
            }
            return sortNum; //返回最大排序号
        }

        #endregion


        /// <summary>
        /// 功能管理
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public ActionResult Index2(CharmCommonActionInfoDTO query)
        {
            var where = new StringBuilder();
            var paras = new List<object>();

            paras.Add(query.MenuId);
            where.Append(" AND b.MenuId = ? ");

            if (!string.IsNullOrEmpty(query.ActionCategoryName))
            {
                paras.Add(query.ActionCategoryName);
                where.Append(" AND ActionCategoryName LIKE '%' + ? + '%' ");
            }

            if (!string.IsNullOrEmpty(query.ActionName))
            {
                paras.Add(query.ActionName);
                where.Append("  AND ActionName LIKE '%' + ? + '%' ");
            }

            if (!string.IsNullOrEmpty(query.ActionUrl))
            {
                paras.Add(query.ActionUrl);
                where.Append(" AND ActionUrl LIKE '%' + ? + '%' ");
            }

            var models = this.CommonActionInfoService.GetModels(Const.PageIndex, Const.PAGESIZE, where.ToString(), "ActionCategoryName, Sort", paras.ToArray());
            var pm = this.Kernel.CreatePageModel(Const.PAGESIZE, Const.PageIndex, models.TotalCount);
            var dtos = Mapper.Map<List<CharmCommonActionInfoDTO>>(models.Models);

            if (dtos == null)
                dtos = new List<CharmCommonActionInfoDTO>();

            this.ViewBag.PM = pm;
            this.ViewBag.Functions = dtos;

            return this.View(query);
        }
    }
}