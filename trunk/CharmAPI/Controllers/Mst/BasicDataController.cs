using Charm.Common;
using Charm.Common.Enum;
using Charm.Entity.API;
using Charm.Entity.API.Mst;
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

namespace CharmAPI.Controllers.Mst
{
    /// <summary>
    /// 基础数据
    /// </summary>
    public class BasicDataController : BaseApiController
    {
        /// <summary>
        ///Category服务
        /// </summary>
        [Dependency]
        public ICharmMstCategoryService CharmMstCategoryService { get; set; }

        /// <summary>
        /// Brand服务
        /// </summary>
        [Dependency]
        public ICharmBusinessBrandService CharmBusinessBrandService { get; set; }


        /// <summary>
        /// 获取类别信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet, Route("api/BasicData/GetCategoryInfo")]
         public CategoryInfoResponse GetCategoryInfo([FromUri] CategoryInfoRequest request)
        {
            CategoryInfoResponse response = new CategoryInfoResponse();
            string queryStr = string.Empty;
            if (string.IsNullOrWhiteSpace(request.Token)|| !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc= EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }
            var where = new StringBuilder();
            var paras = new List<object>();
            paras.Add(1);
            where.Append("  AND Is_Show =? ");
            if (!string.IsNullOrEmpty(request.CategoryId))
            {
                paras.Add(request.CategoryId);
                where.Append(" AND Category_Id =? ");
            }
            if (!string.IsNullOrEmpty(request.ParentId))
            {
                paras.Add(request.ParentId);
                where.Append(" AND Parent_id =? ");
            }

            var models = this.CharmMstCategoryService.GetModels(where.ToString(), null, paras.ToArray());
            if (models != null && models.Count > 0)
            {
                response.CateGoryList = new List<CategoryInfo>();
                foreach (var item in models)
                {
                    var model = new CategoryInfo()
                    {
                        CategoryDesc=item.Category_Desc,
                        CategoryId=item.Category_Id.ToString(),
                        CategoryName=item.Category_Name,
                        SortOrder=item.Sort_Order.ToString(),
                        ParentId=item.Parent_id.ToString()
                    };
                    response.CateGoryList.Add(model);
                }
            }
            response.RspCode= ReponseCode.Success.GetHashCode();
            response.RspDesc = "类别查询成功";
            return response;
        }

        /// <summary>
        /// 获取品牌信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost, Route("api/BasicData/GetBrandInfo")]
        public GetBrandResponse GetBrandInfo([FromBody] GetBrandRequest request)
        {
            GetBrandResponse response = new GetBrandResponse();
            #region 验证
            if (string.IsNullOrWhiteSpace(request.Token) || !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }
            if ((string.IsNullOrWhiteSpace(request.UserAccount)||string.IsNullOrWhiteSpace(request.UserPassword))&&string.IsNullOrWhiteSpace(request.BrandId))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "用户账号或密码不能为空";
                return response;
            }
            #endregion

            var where = new StringBuilder();
            var paras = new List<object>();
            if (!string.IsNullOrWhiteSpace(request.BrandId))
            {
                paras.Add(new Guid(request.BrandId));
                where.Append(" AND  Brand_Id =? ");
            }
            else
            {
                paras.Add(request.UserAccount);
                where.Append(" AND  UserAccount =? ");

                paras.Add(Md5Encode.Encode(request.UserPassword));
                where.Append("  AND  UserPassword =? ");
            }
            var model = CharmBusinessBrandService.GetModels(where.ToString(),string.Empty,paras.ToArray()).FirstOrDefault();
            if (model == null)
            {
                response.RspCode = ReponseCode.AccountNotExist.GetHashCode();
                response.RspDesc = "用户账号或密码错误";
                return response;
            }
            else
            {
                response.BrandInfo = new BrandInfo()
                {
                    BrandId = model.Brand_Id.ToString(),
                    BrandName = model.Brand_Name,
                    BrandLogo = model.Brand_Logo,
                    BrandDesc = model.Brand_Desc,
                    SiteUrl = model.Site_Url,
                    SiteShortUrl = model.Site_Short_Url,
                    SortOrder = model.Sort_Order.ToString(),
                    IsShow = model.Is_Show == null ? string.Empty : model.Is_Show.ToString(),
                    IsHot = model.Is_Hot == null ? string.Empty : model.Is_Hot.ToString(),
                    BrandCode = model.Brand_Code.ToString(),
                    BrandPhone = model.Brand_Phone,
                    UserAccount=model.UserAccount
                };

            }
            response.RspCode = ReponseCode.Success.GetHashCode();
            response.RspDesc = "品牌查询成功";
            return response;
        }


        /// <summary>
        /// 更新品牌信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost, Route("api/BasicData/UpdateBrandInfo")]
        public UpdateBrandResponse UpdateBrandInfo([FromBody] UpdateBrandRequest request)
        {
            UpdateBrandResponse response = new UpdateBrandResponse();
            #region 验证
            if (string.IsNullOrWhiteSpace(request.Token) || !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.BrandId))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "BrandId不能为空";
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.BrandName))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌名称不能为空";
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.BrandLogo))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌Logo不能为空";
                return response;
            }

            if (string.IsNullOrWhiteSpace(request.UserAccount))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "账号不能为空";
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.BrandPhone))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌电话不能为空";
                return response;
            }
            #endregion


            var model = CharmBusinessBrandService.GetModel(new Guid(request.BrandId));
            if (model == null)
            {
                response.RspCode = ReponseCode.SearchFail.GetHashCode();
                response.RspDesc = "品牌信息不存在";
                return response;
            }
            else
            {
                  
                    model.Brand_Name = request.BrandName;
                    model.Brand_Logo = request.BrandLogo;
                    model.Brand_Desc = request.BrandDesc;
                    model.Site_Url = request.SiteUrl;
                    model.Site_Short_Url = request.SiteShortUrl;
                    model.Brand_Phone = request.BrandPhone;
                    if (!string.IsNullOrWhiteSpace(request.UserPassword)&&!model.UserPassword.Equals(Md5Encode.Encode(request.UserPassword)))
                    {
                        model.UserPassword = Md5Encode.Encode(request.UserPassword);
                    }
                    if (!model.UserAccount.Equals(request.UserAccount))
                    {
                        model.UserAccount = request.UserAccount;
                        var existWhere = new StringBuilder();
                        var existParas = new List<object>();
                        existParas.Add(request.UserAccount);
                        existWhere.Append(" AND UserAccount =? ");
                        var existAccountModels = CharmBusinessBrandService.GetModels(existWhere.ToString(), string.Empty, existParas.ToArray());
                        if (existAccountModels != null && existParas.Count > 0)
                        {
                            response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                            response.RspDesc = "账户已存在";
                            return response;
                        }
                }  
                    model.Modify_By =model.UserAccount;
                    model.Modify_Time = DateTime.Now;
                if (!CharmBusinessBrandService.Modify(model))
                {
                    response.RspCode = ReponseCode.UpdateFail.GetHashCode();
                    response.RspDesc = "品牌更新失败";
                    return response;
                }
                else
                {
                    var newModel = CharmBusinessBrandService.GetModel(model.Brand_Id);
                    response.BrandInfo = new BrandInfo()
                    {
                        BrandId = model.Brand_Id.ToString(),
                        BrandName = model.Brand_Name,
                        BrandLogo = model.Brand_Logo,
                        BrandDesc = model.Brand_Desc,
                        SiteUrl = model.Site_Url,
                        SiteShortUrl = model.Site_Short_Url,
                        SortOrder = model.Sort_Order.ToString(),
                        IsShow = model.Is_Show == null ? string.Empty : model.Is_Show.ToString(),
                        IsHot = model.Is_Hot == null ? string.Empty : model.Is_Hot.ToString(),
                        BrandCode = model.Brand_Code.ToString(),
                        BrandPhone = model.Brand_Phone
                    };
                }

            }
            response.RspCode = ReponseCode.Success.GetHashCode();
            response.RspDesc ="品牌更新成功";
            return response;
        }


        /// <summary>
        /// 创建品牌信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost, Route("api/BasicData/CreateBrandInfo")]
        public UpdateBrandResponse CreateBrandInfo([FromBody] CreateBrandRequest request)
        {
            UpdateBrandResponse response = new UpdateBrandResponse();
            #region 验证
            if (string.IsNullOrWhiteSpace(request.Token) || !VerifyTokey(request.Token))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = EnumOperate.GetEnumDesc(ReponseCode.VerifyFail);
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.BrandName))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌名称不能为空";
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.BrandLogo))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌Logo不能为空";
                return response;
            }

            if (string.IsNullOrWhiteSpace(request.UserAccount))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "账户不能为空";
                return response;
            }
            if (string.IsNullOrEmpty(request.UserPassword))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "密码不能为空";
                return response;
            }
            if (string.IsNullOrWhiteSpace(request.BrandPhone))
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "品牌电话不能为空";
                return response;
            }
            var existWhere = new StringBuilder();
            var existParas = new List<object>();
            existParas.Add(request.UserAccount);
            existWhere.Append(" AND UserAccount =? ");
            var existAccountModels = CharmBusinessBrandService.GetModels(existWhere.ToString(),string.Empty,existParas.ToArray());
            if (existAccountModels!=null&&existParas.Count>0)
            {
                response.RspCode = ReponseCode.VerifyFail.GetHashCode();
                response.RspDesc = "账户已存在";
                return response;
            }
            
            #endregion

            var model = new CharmBusinessBrand();
                model.Brand_Name = request.BrandName;
                model.Brand_Logo = request.BrandLogo;
                model.Brand_Desc = request.BrandDesc;
                model.Site_Url = request.SiteUrl;
                model.Brand_Phone = request.BrandPhone;
                model.UserAccount = request.UserAccount;
                model.UserPassword = Md5Encode.Encode(request.UserPassword);
                model.Is_Show = false;
                model.Create_By = request.UserAccount;
                model.Create_Time = DateTime.Now;
                var maxBrandCode = CharmBusinessBrandService.GetModels(1, 1, "", "Brand_Code Desc", null);
                if (maxBrandCode != null && maxBrandCode.Models != null && maxBrandCode.Models.Count > 0)
                {
                    model.Brand_Code += maxBrandCode.Models.Max(m=>m.Brand_Code);
                 }
                else
                {
                    model.Brand_Code = 1;
                }
                model.Modify_By = request.UserAccount;
                model.Modify_Time= DateTime.Now;
                model.Brand_Id = Guid.NewGuid();
            if (!CharmBusinessBrandService.Add(model))
            {
                response.RspCode = ReponseCode.AddFail.GetHashCode();
                response.RspDesc = "品牌创建失败";
                return response;
            }
            else
            {
                var newModel = CharmBusinessBrandService.GetModel(model.Brand_Id);
                response.BrandInfo = new BrandInfo()
                {
                    BrandId = model.Brand_Id.ToString(),
                    BrandName = model.Brand_Name,
                    BrandLogo = model.Brand_Logo,
                    BrandDesc = model.Brand_Desc,
                    SiteUrl = model.Site_Url,
                    SiteShortUrl = model.Site_Short_Url,
                    SortOrder = model.Sort_Order.ToString(),
                    IsShow = model.Is_Show == null ? string.Empty : model.Is_Show.ToString(),
                    IsHot = model.Is_Hot == null ? string.Empty : model.Is_Hot.ToString(),
                    BrandCode = model.Brand_Code.ToString(),
                    BrandPhone = model.Brand_Phone
                };
            }

            response.RspCode = ReponseCode.Success.GetHashCode();
            response.RspDesc ="品牌创建成功";
            return response;
        }
    }
}
