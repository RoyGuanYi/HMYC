using AutoMapper;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Charm.MvcExt.Base;
using Charm.Services.GenServices.Business;
using Charm.MvcExt.Extisions;
using CharmMananger.Models.Business;
using Charm.Entity.Business;
using Charm.Common.Enum;
using System.Text;

namespace CharmMananger.Controllers.Member
{
    public class CharmMemberInfoController : BaseController
    {
        [Dependency]
        public ICharmMemberInfoService CharmMemberInfoService { get; set; }

        public ActionResult Index(CharmMemberInfoDTO query, int? page)
         {
            var where = new StringBuilder();
            var paras = new List<object>();

            if (!string.IsNullOrEmpty(query.User_Name))
            {
                paras.Add(query.User_Name);
                where.Append(" AND User_Name LIKE '%' + ? + '%' ");
            }

            var p = page ?? 1;
            var models = this.CharmMemberInfoService.GetModels(p, 5, where.ToString(), "Member_Id", paras.ToArray());
            var pm = this.Kernel.CreatePageModel(5, p, models.TotalCount);
            var dtos = Mapper.Map<List<CharmMemberInfoDTO>>(models.Models);

            this.ViewBag.PM = pm;

            if (dtos == null)
            {
                dtos = new List<CharmMemberInfoDTO>();
            }
            else
            {
                foreach(var item in dtos)
                {
                    item.User_Source_Show = EnumOperate.GetEnumDesc((MemberSourceEnum)item.User_Source);
                    item.Sex_Show = EnumOperate.GetEnumDesc((SexEnum)item.Wc_Sex);
                }
            }
            ViewBag.ModelList = dtos;
            return this.View(query);
         }

        public ActionResult Details(Guid memberId)
        {
            var entity = this.CharmMemberInfoService.GetModel(memberId);
            var model = Mapper.Map<CharmMemberInfoDTO>(entity);
            if(model!=null)
            {
                model.User_Source_Show = EnumOperate.GetEnumDesc((MemberSourceEnum)model.User_Source);
                model.Sex_Show = EnumOperate.GetEnumDesc((SexEnum)model.Wc_Sex);
            }

            return this.View(model);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(CharmMemberInfoDTO model)
        {
            var entity = Mapper.Map<CharmMemberInfo>(model);

            this.CharmMemberInfoService.Add(entity);

            return this.View("jump");
        }

        public ActionResult Edit(Guid memberId)
        {
            var entity = this.CharmMemberInfoService.GetModel(memberId);
            var model = Mapper.Map<CharmMemberInfoDTO>(entity);

            return this.View(model);
        }

        [HttpPost]
        public ActionResult Edit(CharmMemberInfoDTO model)
        {
            var entity = this.CharmMemberInfoService.GetModel(model.Member_Id);

            entity.User_Name = model.User_Name;
            entity.Wechat_Id = model.Wechat_Id;
            entity.User_Avatar = model.User_Avatar;
            entity.User_Phone = model.User_Phone;
            entity.User_Source = model.User_Source;
            entity.Login_Count = model.Login_Count;
            entity.Modify_By = CurrentUser.UserName;
            entity.Modify_Time = DateTime.Now;
            entity.Wc_AccessToken = model.Wc_AccessToken;
            entity.Wc_RefreshToken = model.Wc_RefreshToken;
            entity.Wc_AccessToken_ExpireDate = model.Wc_AccessToken_ExpireDate;
            entity.Wc_RefreshToken_ExpireDate = model.Wc_RefreshToken_ExpireDate;
            entity.Wc_Sex = model.Wc_Sex;
            entity.Wc_Province = model.Wc_Province;
            entity.Wc_City = model.Wc_City;
            entity.Wc_Country = model.Wc_Country;
            entity.Wc_Privilege = model.Wc_Privilege;
            entity.Wc_UnionId = model.Wc_UnionId;

            this.CharmMemberInfoService.Modify(entity);

            return this.View("jump");
        }

        public ActionResult Delete(Guid memberId)
        {
            this.CharmMemberInfoService.Delete(memberId);

            return this.RedirectToAction("Index");
        }
    }

}