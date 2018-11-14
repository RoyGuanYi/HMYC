using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Charm.Common;
using Charm.Common.Models.ApiRequest;
using Charm.Common.Models.ApiResponse;
using Charm.Common.Models.Common;

namespace Charm.NewWapApp.Controllers
{
    public class NewsController : Controller
    {

        public ActionResult AddComment()
        {
            var model = new NewsComment
            {
                Token = RestServiceProxy.GetToken(),
                Content = "test",
                CreateBy = "admin",
                CreateOn = DateTime.Now,
                NewsId = Guid.NewGuid().ToString()
            };
            string url = GlobalClientConfig.BaseURI + "/NewsApi/CreateNewsComment";
            var result = RestServiceProxy.Post<ApiResponseBase, NewsComment>(model, url);
            return null;

        }


        /// <summary>
        /// 获取新闻详情
        /// </summary>
        /// <returns></returns>
        public ActionResult NewsDetails(String newId)
        {
            var model = new NewsInfoRequestById
            {
                Token = RestServiceProxy.GetToken(),
                //newId = "CD40B9A9-FD37-4746-97AD-FACCEEEDE616",
                newId = newId,
                CurrentPage = 1,
                pageSize = 10
            };
            string url = GlobalClientConfig.BaseURI + "/NewsApi/GetNewsById/";
            var result = RestServiceProxy.Get<NewsInfoById, NewsInfoRequestById>(model, url);
            return View(result);
        }

        /// <summary>
        /// 获取所有新闻列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = new NewsListInfoRequest
            {
                Token = RestServiceProxy.GetToken(),
                CurrentPage = 1,
                pageSize =9
            };
            string url = GlobalClientConfig.BaseURI + "/NewsApi/GetNewsList/";
            //var result = RestServiceProxy.Get<NewsInfo, NewsListInfoRequest>(model, url);
            var result = new NewsInfo();
            result.NewsList = new List<NewsList>();
            result.NewsList.Add(new NewsList() { NewsName = "瑟斯" });
            result.TotalPages = 10;

            return View(result);
        }

        /// <summary>
        /// 新闻列表(分页)(滚动条)
        /// </summary>
        /// <returns></returns>

        public JsonResult GetNewsByPage(int CurrentPage)
        {
            var model = new NewsListInfoRequest
            {
                Token = RestServiceProxy.GetToken(),
                CurrentPage = CurrentPage,
                pageSize = 9

            };
            string url = GlobalClientConfig.BaseURI + "/NewsApi/GetNewsList/";
            var result = RestServiceProxy.Get<NewsInfo, NewsListInfoRequest>(model, url);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        
    }
}
