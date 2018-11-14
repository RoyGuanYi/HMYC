using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using Charm.Entity.Business;
using Charm.Entity.Role;
using Charm.MvcExt;
using Charm.MvcExt.User;
using CharmMananger.Models.Business;
using CharmMananger.Models.Role;

namespace CharmMananger
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            try
            {
                OctGlobal.InitIOC(); //Bootstrapper.Initialise();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            CreateMapper();
        }

        private void CreateMapper()
        {
            //Mapper.CreateMap<UserInfo, UserInfoDTO>();
            //Mapper.CreateMap<UserInfoDTO, UserInfo>();
            Mapper.CreateMap<CharmCommonActionInfo, CharmCommonActionInfoDTO>();
            Mapper.CreateMap<CharmCommonActionInfoDTO, CharmCommonActionInfo>();

            Mapper.CreateMap<CharmCommonMenuInfo, CharmCommonMenuInfoDTO>();
            Mapper.CreateMap<CharmCommonMenuInfoDTO, CharmCommonMenuInfo>();

            Mapper.CreateMap<CharmCommonRoleAction, CharmCommonRoleActionDTO>();
            Mapper.CreateMap<CharmCommonRoleActionDTO, CharmCommonRoleAction>();

            Mapper.CreateMap<CharmCommonRoleInfo, CharmCommonRoleInfoDTO>();
            Mapper.CreateMap<CharmCommonRoleInfoDTO, CharmCommonRoleInfo>();

            Mapper.CreateMap<CharmCommonUserInfo, CharmCommonUserInfoDTO>();
            Mapper.CreateMap<CharmCommonUserInfoDTO, CharmCommonUserInfo>();

            Mapper.CreateMap<CharmCommonUserRole, CharmCommonUserRoleDTO>();
            Mapper.CreateMap<CharmCommonUserRoleDTO, CharmCommonUserRole>();


            Mapper.CreateMap<Charm_CommonUserAction, Charm_CommonUserActionDTO>();
            Mapper.CreateMap<Charm_CommonUserActionDTO, Charm_CommonUserAction>();


            Mapper.CreateMap<CharmArticle, CharmArticleDTO>();
            Mapper.CreateMap<CharmArticleDTO, CharmArticle>();

            Mapper.CreateMap<CharmBusinessBrand, CharmBusinessBrandDTO>();
            Mapper.CreateMap<CharmBusinessBrandDTO, CharmBusinessBrand>();

            Mapper.CreateMap<CharmMemberInfo, CharmMemberInfoDTO>();
            Mapper.CreateMap<CharmMemberInfoDTO, CharmMemberInfo>();

            Mapper.CreateMap<CharmMstCategory, CharmMstCategoryDTO>();
            Mapper.CreateMap<CharmMstCategoryDTO, CharmMstCategory>();

            Mapper.CreateMap<CharmMstComment, CharmMstCommentDTO>();
            Mapper.CreateMap<CharmMstCommentDTO, CharmMstComment>();

            Mapper.CreateMap<CharmMstFeedback, CharmMstFeedbackDTO>();
            Mapper.CreateMap<CharmMstFeedbackDTO, CharmMstFeedback>();

            Mapper.CreateMap<CharmMstGoods, CharmMstGoodsDTO>();
            Mapper.CreateMap<CharmMstGoodsDTO, CharmMstGoods>();

            Mapper.CreateMap<CharmMstGoodsImage, CharmMstGoodsImageDTO>();
            Mapper.CreateMap<CharmMstGoodsImageDTO, CharmMstGoodsImage>();

            Mapper.CreateMap<CharmGoodsInfoQuery, CharmGoodsInfoDTO>();
            Mapper.CreateMap<CharmGoodsInfoDTO, CharmGoodsInfoQuery>();
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError().GetBaseException();
        }

        public void Session_Start()
        {

        }

        public void Session_End()
        {
            LoginHelper.Instance.LogOut();
        }
    }
}
