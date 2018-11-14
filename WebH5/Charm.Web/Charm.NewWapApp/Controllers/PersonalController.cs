using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Charm.Common.MvcExt;
using Charm.Common.Models.ApiRequest;
using Charm.Common;
using Charm.Common.Models.Common;
using Charm.Common.Models.ApiResponse;
using Charm.NewWapApp.Models;
using Charm.Common.Models;
using Charm.Entity.API.Mst;
using Charm.Entity.API;
using Charm.Entity.API.Goods;
using Newtonsoft;
using Newtonsoft.Json;

namespace Charm.NewWapApp.Controllers
{
    public class PersonalController : BaseController
    {
        public static List<CategoryInfo> CategoryList = new List<CategoryInfo>();
        //
        // GET: /Personal/
        public ActionResult Index()
        {
         
            #region  品牌对应的商品信息
            var result = GetData(false,1,1,string.Empty);
            List<GoodsInfo> model =new  List<GoodsInfo>();
            if (result != null && result.RspCode == ReponseCode.Success.GetHashCode())
            {
                if(result.Goods!=null&&result.Goods.Count>0)
                {
                    model = result.Goods;
                }
            }
            ViewBag.GoodInfo = new GoodsInfo();
            #endregion
            return View(model);
            
        }


        public CategoryInfoResponse GetCategoryInfo()
        {
            Entity.API.Mst.CategoryInfoRequest request = new Entity.API.Mst.CategoryInfoRequest();
            string url = GlobalClientConfig.BaseURI + "/BasicData/GetCategoryInfo";
            request.Token = RestServiceProxy.GetToken();
            var resutl = RestServiceProxy.Get<CategoryInfoResponse, Entity.API.Mst.CategoryInfoRequest>(request, url);
            return resutl;
        }

       
        public GoodsInfoResponse GetData(bool isNeedPage,int pageIndex,int pageSize,string goodsId)
        {
            var model = new GoodsInfoRequest();
            model.Token = RestServiceProxy.GetToken();
            model.PageSize = pageSize.ToString();
            model.IsNeedPage = isNeedPage;
            model.CurrentPage = pageIndex.ToString();
            model.BrandId = CurrentUser.BrandId;
            if(!string.IsNullOrWhiteSpace(goodsId))
            {
                model.GoodsId = goodsId;
            }
            var result = new GoodsInfoResponse();
            string GoodsUrl = GlobalClientConfig.BaseURI + "/Goods/GetGoodsInfo";
            result = RestServiceProxy.Get<GoodsInfoResponse, GoodsInfoRequest>(model, GoodsUrl);
            return result;
        }

        /// <summary>
        ///根据父类获取子类集合拼接字符串
        /// </summary>
        /// <param name="categoryList"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        [HttpGet]
        public string GetCategoryInfoByParentId(string parentId,string categoryId)
        {
            string str = "";
            foreach(var item in CategoryList)
            {
                if (item.ParentId == parentId)
                {
                    if (!string.IsNullOrEmpty(categoryId)&&item.CategoryId==categoryId)
                    {
                        str += "<option value='" + item.CategoryId + "' selected='selected' >" + item.CategoryName + "</option>";
                    }
                    else
                    {
                        str += "<option value='" + item.CategoryId + "'>" + item.CategoryName + "</option>";
                    }
                    
                }   
            }

            return str;
        }


      /// <summary>
      /// 品牌设置
      /// </summary>
      /// <param name="brandId"></param>
      /// <returns></returns>
      [HttpGet]
        public ActionResult Setting(string brandId)
        {
            BrandInfoModel model = new BrandInfoModel();
            if (!string.IsNullOrEmpty(brandId))
            {
                GetBrandRequest request = new GetBrandRequest();
                request.Token = RestServiceProxy.GetToken();
                request.BrandId = brandId;
                var result = new GetBrandResponse();
                string brandUrl = GlobalClientConfig.BaseURI + "/BasicData/GetBrandInfo";
                result = RestServiceProxy.Post<GetBrandResponse, GetBrandRequest>(request, brandUrl);
                if(result != null&& result.RspCode== ReponseCode.Success.GetHashCode()&&result.BrandInfo!=null)
                {
                    model.BrandId = result.BrandInfo.BrandId;
                    model.BrandName = result.BrandInfo.BrandName;
                    model.BrandLogo = result.BrandInfo.BrandLogo;
                    model.BrandDesc = result.BrandInfo.BrandDesc;
                    model.BrandPhone = result.BrandInfo.BrandPhone;
                    model.UserAccount = result.BrandInfo.UserAccount;
                }
                else
                {
                    if (result == null)
                    {
                        TempData["ejs"] = "查询品牌异常";
                    }
                    else if (result.BrandInfo == null)
                    {
                        TempData["ejs"] = "品牌信息异常";
                    }
                    else
                    {
                        TempData["ejs"] = result.RspDesc;
                    }
                    return RedirectToAction("Index", "Personal");
                }
            }
         
            return View(model);
        }

        /// <summary>
        /// 品牌设置
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Setting(BrandInfoModel model)
        {
            #region 验证
            
            if (string.IsNullOrWhiteSpace(model.BrandName))
            {
                TempData["ejs"] = "品牌名称不能为空";
                return View(model);

            }
            if (string.IsNullOrWhiteSpace(model.BrandLogo))
            {
                TempData["ejs"] = "品牌logo不能为空";
                return View(model);

            }
            if (string.IsNullOrWhiteSpace(model.UserAccount))
            {
                TempData["ejs"] = "品牌用户账号不能为空";
                return View(model);

            }
            if (string.IsNullOrWhiteSpace(model.NewUserPassword)&&string.IsNullOrWhiteSpace(model.BrandId))
            {
                TempData["ejs"] = "品牌用户密码不能为空";
                return View(model);

            }
            if (string.IsNullOrWhiteSpace(model.BrandPhone))
            {
                TempData["ejs"] = "品牌电话不能为空";
                return View(model);
            }
            #endregion
            if (string.IsNullOrWhiteSpace(model.BrandId))
            {
                CreateBrandRequest request = new CreateBrandRequest();
                request.Token = RestServiceProxy.GetToken();
                request.BrandName = model.BrandName;
                request.BrandLogo = model.BrandLogo;
                request.BrandPhone = model.BrandPhone;
                request.BrandDesc = model.BrandDesc;
                request.UserAccount = model.UserAccount;
                request.UserPassword = model.NewUserPassword;
                var result = new UpdateBrandResponse();
                string brandUrl = GlobalClientConfig.BaseURI + "/BasicData/CreateBrandInfo";
                result = RestServiceProxy.Get<UpdateBrandResponse, CreateBrandRequest>(request, brandUrl);
                if (result != null && result.RspCode == ReponseCode.Success.GetHashCode() && result.BrandInfo != null)
                {
                    TempData["sjs"] = "品牌创建成功";
                    LoginHelper.Instance.Login(() => new UserInfo()
                    {
                        Account = result.BrandInfo.UserAccount,
                        UserName = result.BrandInfo.BrandName,
                        Avatar = "",
                        Phone = result.BrandInfo.BrandPhone,
                        BrandId = result.BrandInfo.BrandId,
                        UserType=UserTypeEnum.Brand
                    });
                    return RedirectToAction("Index", "Personal");
                }
                else
                {
                    if (result == null || result.BrandInfo == null)
                    {
                        TempData["ejs"] = "创建品牌异常";
                        return View(model);
                    }
                    else if (result.RspCode!= ReponseCode.Success.GetHashCode())
                    {
                        TempData["ejs"] = result.RspDesc;
                        return View(model);
                    }

                }
            }
            else
            {
                UpdateBrandRequest request = new UpdateBrandRequest();
                request.Token = RestServiceProxy.GetToken();
                request.BrandId = model.BrandId;
                request.BrandName = model.BrandName;
                request.BrandLogo = model.BrandLogo;
                request.BrandPhone = model.BrandPhone;
                request.BrandDesc = model.BrandDesc;
                request.UserAccount = model.UserAccount;
                request.UserPassword = model.NewUserPassword;
                var result = new UpdateBrandResponse();
                string brandUrl = GlobalClientConfig.BaseURI + "/BasicData/UpdateBrandInfo";
                result = RestServiceProxy.Post<UpdateBrandResponse, UpdateBrandRequest>(request, brandUrl);
                if (result != null && result.RspCode == ReponseCode.Success.GetHashCode() && result.BrandInfo != null)
                {
                    TempData["sjs"] = "品牌修改成功";
                    LoginHelper.Instance.Login(() => new UserInfo()
                    {
                        Account = result.BrandInfo.UserAccount,
                        UserName = result.BrandInfo.BrandName,
                        Avatar = "",
                        Phone = result.BrandInfo.BrandPhone,
                        BrandId = result.BrandInfo.BrandId,
                        UserType=UserTypeEnum.Brand
                    });
                    return RedirectToAction("Index", "Personal");
                }
                else
                {
                    if (result == null || result.BrandInfo == null)
                    {
                        TempData["ejs"] = "修改品牌异常";
                        return View(model);
                    }
                    else if (result.RspCode != ReponseCode.Success.GetHashCode())
                    {
                        TempData["ejs"] = result.RspDesc;
                        return View(model);
                    }

                }
            }
            return View(model);
        }


        /// <summary>
        /// 新建编辑商品
        /// </summary>
        /// <param name="goodsId"></param>
        /// <returns></returns>
        [HttpGet]
        public PartialViewResult CreateCharm(string goodsId)
        {
            #region 所有类别信息
            var categoryResutl = GetCategoryInfo();
            if (categoryResutl != null && categoryResutl.RspCode == ReponseCode.Success.GetHashCode())
            {
                //请求正确
                if (categoryResutl.CateGoryList != null && categoryResutl.CateGoryList.Count > 0)
                {
                    ViewBag.CategoryList = categoryResutl.CateGoryList;
                    CategoryList = categoryResutl.CateGoryList;
                }
                else
                {
                    ViewBag.CategoryList = new List<CategoryInfo>();
                }
            }
            else
            {

                ViewBag.CategoryList = new List<CategoryInfo>();
            }
            #endregion
            var model = new CharmModel();
            model.BrandId = CurrentUser.BrandId;
            model.IsOnSale = 0;
            if (!string.IsNullOrEmpty(goodsId))
            {
                model.GoodsId = goodsId;
                //查询商品详细信息
                GoodsInfoResponse response = GetData(false,1,1, model.GoodsId);
                if (response != null && response.Goods != null && response.Goods.Count > 0 && response.RspCode == ReponseCode.Success.GetHashCode())
                {
                    var oldModel = response.Goods.First();
                    model.GoodsName = oldModel.GoodsName;
                    model.GoodsBrief = oldModel.GoodsBrief;
                    model.GoodsDesc = oldModel.GoodsDesc;
                    model.ShopPrice = oldModel.ShopPrice;
                    model.MarketPrice = oldModel.MarketPrice;
                    model.BrandId = oldModel.BrandId;
                    model.CategoryId = oldModel.CategoryId;
                    if (Convert.ToBoolean(oldModel.IsOnSale))
                    {
                        model.IsOnSale = 1;
                    }
                    else
                    {
                        model.IsOnSale = 0;
                    }
                    model.SortOrder = oldModel.SortOrder;
                    model.Images = new List<GoodsImage>();
                    if (oldModel.Images!=null&&oldModel.Images.Count>0)
                    {
                        foreach (var item in oldModel.Images)
                        {
                            model.Images.Add(item);
                        }
                        model.ImageListJsonStr = JsonConvert.SerializeObject(model.Images);
                    }
                }

            }
            return PartialView("CreateCharm",model);
        }

        /// <summary>
        /// 发帖接口（新增魅力圈）
        /// </summary>
        /// <param name="charmModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateCharm(CharmModel charmModel)
        {
            if (string.IsNullOrEmpty(charmModel.BrandId))
            {
                TempData["ejs"]  = "品牌不能为空";
                //跳转至指定页
                return View(charmModel);
            }
            if (string.IsNullOrEmpty(charmModel.GoodsName))
            {
                TempData["ejs"] = "商品名称不能为空";
                //跳转至指定页
                return View(charmModel);
            }
            if (string.IsNullOrEmpty(charmModel.CategoryId))
            {
                TempData["ejs"] = "类别二请选择一项";
                //跳转至指定页
                return View(charmModel);
            }
            if (string.IsNullOrEmpty(charmModel.MarketPrice))
            {
                TempData["ejs"] = "市场价不能为空";
                //跳转至指定页
                return View(charmModel);
            }
            if (string.IsNullOrEmpty(charmModel.ShopPrice))
            {
                TempData["ejs"] = "门市价不能为空";
                //跳转至指定页
                return View(charmModel);
            }
            if (charmModel.filePath==null||charmModel.filePath.Count==0)
            {
                TempData["ejs"] = "商品图片最少传一张";
                //跳转至指定页
                return View(charmModel);
            }
            if (charmModel.filePath != null&&charmModel.filePath.Count > 5)
            {
                TempData["ejs"] = "商品图片最多传5张";
                //跳转至指定页
                return View(charmModel);
            }
            var model = new CreateGoodsRequest();
            model.Goods = new GoodsInfo();
            model.Goods.CategoryId = charmModel.CategoryId;
            model.Goods.IsOnSale =charmModel.IsOnSale.ToString();
            model.Goods.SortOrder = charmModel.SortOrder;
            model.Goods.BrandId = charmModel.BrandId;
            model.Goods.Images = new List<GoodsImage>();
            model.Token = RestServiceProxy.GetToken();
            foreach (var item in charmModel.filePath) {
                model.Goods.Images.Add(new GoodsImage() { GoodsOriginalImg = item});
            }
            model.Goods.GoodsName = charmModel.GoodsName;
            model.Goods.GoodsBrief = charmModel.GoodsBrief;
            model.Goods.GoodsDesc = charmModel.GoodsDesc;
            model.Goods.ShopPrice = charmModel.ShopPrice;
            model.Goods.MarketPrice = charmModel.MarketPrice;
            if (string.IsNullOrEmpty(charmModel.GoodsId))//新增
            {
                string url = GlobalClientConfig.BaseURI + "/Goods/CreateGoodsInfo";
                CreateGoodsResponse response = RestServiceProxy.Post<CreateGoodsResponse, CreateGoodsRequest>(model, url);
                if (response != null && response.RspCode == ReponseCode.Success.GetHashCode())
                {
                    TempData["sjs"] = "创建产品成功";
                    //跳转至指定页
                    return this.Redirect("/Personal/Index");
                }
                else
                {
                    if (response == null)
                    {
                        TempData["ejs"] = "新建产品异常";
                    }
                    else
                    {
                        TempData["ejs"] = response.RspDesc;

                    }
                }
            }
            else//编辑
            {
                model.Goods.GoodsId = charmModel.GoodsId;
                string url = GlobalClientConfig.BaseURI + "/Goods/UpdateGoodsInfo";
                CreateGoodsResponse response = RestServiceProxy.Post<CreateGoodsResponse, CreateGoodsRequest>(model, url);
                if (response != null && response.RspCode == ReponseCode.Success.GetHashCode())
                {
                    TempData["sjs"] = "编辑产品成功";
                    //跳转至指定页
                    return this.Redirect("/Personal/Index");
                }
                else
                {
                    if (response == null)
                    {
                        TempData["ejs"] = "编辑产品异常";
                    }
                    else
                    {
                        TempData["ejs"] = response.RspDesc;

                    }
                }

            }

            return View(charmModel);

        }


        /// <summary>
        /// 删除我发的帖
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteGoods(string goodsId)
        {

            var request = new DeleteGoodsRequest();
            request.Token = RestServiceProxy.GetToken();
            request.GoodsId = goodsId;
            string url = GlobalClientConfig.BaseURI + "/Goods/DeleteGoodsInfo/";
            var response = RestServiceProxy.Post<BaseApiReponse, DeleteGoodsRequest>(request, url);
            if (response!=null&& response.RspCode == ReponseCode.Success.GetHashCode())
            {
                TempData["sjs"] = "删除成功";
            }
            else {

                TempData["ejs"] = "删除失败";
            }
            return RedirectToAction("Index", "Personal");
        }

        /// <summary>
        /// 修改会员信息
        /// </summary>
        /// <param name="charmModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateUserInfo(UserInfoModel userInfoModel)
        {
            var model = new UpdateUserInfoRequest
            {
                Token = RestServiceProxy.GetToken(),
                HeadImageUrl = userInfoModel.HeadImageUrl,
                MemberNickName = userInfoModel.MemberNickName,
                MemberId = userInfoModel.MemberId,
                MemberAccount = userInfoModel.MemberAccount

            };
            string url = GlobalClientConfig.BaseURI + "/Member/UpdateMemberInfo/";
            var result = RestServiceProxy.Post<ApiResponseBase, UpdateUserInfoRequest>(model, url);
            if (result.RspCode == 0)
            {
                TempData["sjs"] = "修改成功";
            }
            else
            {
                TempData["ejs"] = "修改失败";
                LogHelper.Error(DateTime.Now.ToLongTimeString() + ":" + result.RspErrorMsg);
            }
            LoginHelper.Instance.Login(() => new UserInfo()
            {
                Account = userInfoModel.MemberId,
                UserName = userInfoModel.MemberNickName,
                Avatar = userInfoModel.HeadImageUrl,
                Phone = userInfoModel.MemberAccount
            });
            return RedirectToAction("Index", "Personal");
           

        }

        /// <summary>
        /// 移动端首页
        /// </summary>
        /// <returns></returns>
        public ActionResult MIndex()
        {
            ViewBag.CurrentUser = CurrentUser;
            return View();
        }

        /// <summary>
        /// 移动发帖
        /// </summary>
        /// <returns></returns>
        public ActionResult MSend()
        {
          
            return View();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <returns></returns>
        public ActionResult LogOut()
        {
            LoginHelper.Instance.LogOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
