using System.Web.Mvc;
using Charm.Services;
using Charm.Services.GenServices;
using Charm.Services.GenServices.Business;
using Microsoft.Practices.Unity;
using MongoDB.Bson.Serialization;
using Oct.Framework.Core.IOC;
using Oct.Framework.Core.Log;
using Unity.Mvc4;

namespace Charm.MvcExt
{
    public static class OctGlobal
    {
        public static void InitIOC()
        {
            BsonClassMap.RegisterClassMap<DataChangeLog>();
            BsonClassMap.RegisterClassMap<ViewLog>();
            BsonClassMap.RegisterClassMap<PerformanceLog>();
            IUnityContainer container = Bootstrapper.Initialise();

            #region Role
            container.RegisterType<ICharmCommonActionInfoService, CharmCommonActionInfoService>();

            container.RegisterType<ICharmCommonMenuInfoService, CharmCommonMenuInfoService>();

            container.RegisterType<ICharmCommonRoleActionService, CharmCommonRoleActionService>();

            container.RegisterType<ICharmCommonRoleInfoService, CharmCommonRoleInfoService>();

            container.RegisterType<ICharmCommonUserInfoService, CharmCommonUserInfoService>();

            container.RegisterType<ICharmCommonUserRoleService, CharmCommonUserRoleService>();

            container.RegisterType<ICharm_CommonUserActionService, Charm_CommonUserActionService>();
            #endregion

            container.RegisterType<ICharmArticleService, CharmArticleService>();

            container.RegisterType<ICharmBusinessBrandService, CharmBusinessBrandService>();

            container.RegisterType<ICharmMemberInfoService, CharmMemberInfoService>();

            container.RegisterType<ICharmMstCategoryService, CharmMstCategoryService>();

            container.RegisterType<ICharmMstCommentService, CharmMstCommentService>();

            container.RegisterType<ICharmMstFeedbackService, CharmMstFeedbackService>();

            container.RegisterType<ICharmMstGoodsService, CharmMstGoodsService>();

            container.RegisterType<ICharmMstGoodsImageService, CharmMstGoodsImageService>();

            container.RegisterType<ICharmGoodsInfoQueryService, CharmGoodsInfoQueryService>();

            //container.RegisterType<ITestTsService, TestTsService>();
            //container.RegisterType<ITest, Test>();

            //container.RegisterType<ICommonActionInfoService, CommonActionInfoService>();
            //container.RegisterType<ICommonMenuInfoService, CommonMenuInfoService>();
            //container.RegisterType<ICommonRoleActionService, CommonRoleActionService>();
            //container.RegisterType<ICommonUserRoleService, CommonUserRoleService>();
            //container.RegisterType<ICommonUserService, CommonUserService>();
            //container.RegisterType<ICommonRoleInfoService, CommonRoleInfoService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }

    }
}
