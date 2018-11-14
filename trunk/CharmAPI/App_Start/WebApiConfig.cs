using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Charm.Services.GenServices.Business;
using CharmAPI.App_Start;
using Unity;

namespace CharmAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            var container = new UnityContainer();
            container.RegisterType<ICharmArticleService, CharmArticleService>();

            container.RegisterType<ICharmBusinessBrandService, CharmBusinessBrandService>();

            container.RegisterType<ICharmMemberInfoService, CharmMemberInfoService>();

            container.RegisterType<ICharmMstCategoryService, CharmMstCategoryService>();

            container.RegisterType<ICharmMstCommentService, CharmMstCommentService>();

            container.RegisterType<ICharmMstFeedbackService, CharmMstFeedbackService>();

            container.RegisterType<ICharmMstGoodsService, CharmMstGoodsService>();

            container.RegisterType<ICharmMstGoodsImageService, CharmMstGoodsImageService>();

            container.RegisterType<ICharmGoodsInfoQueryService, CharmGoodsInfoQueryService>();
            config.DependencyResolver = new UnityResolver(container);
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }

            );
        }
    }
}
