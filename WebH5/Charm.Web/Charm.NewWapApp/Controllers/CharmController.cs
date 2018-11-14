using Charm.Common;
using Charm.Common.Models;
using Charm.Common.Models.ApiRequest;
using Charm.Common.Models.ApiResponse;
using Charm.Common.Models.Common;
using Charm.Common.MvcExt;
using Charm.Entity.API.Goods;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charm.NewWapApp.Controllers
{
    public class CharmController : Controller
    {
        //
        // GET: /Charm/
        /// <summary>
        /// 产品列表(分页)
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var request = new GoodsInfoRequest
            {
                Token = RestServiceProxy.GetToken(),
                CurrentPage = "1",
                PageSize = "9",
                IsNeedPage = true
            };
            if (LoginHelper.Instance.IsLogin() && LoginHelper.Instance.GetLoginUser<UserInfo>().UserType != UserTypeEnum.Brand)
            {
                request.BrandId = LoginHelper.Instance.GetLoginUser<UserInfo>().BrandId;
            }
            string url = GlobalClientConfig.BaseURI + "/Goods/GetGoodsInfo";
            var result= RestServiceProxy.Get<GoodsInfoResponse, GoodsInfoRequest>(request, url);
            return View(result);
        }
        /// <summary>
        /// 魅力圈详情
        /// </summary>
        /// <returns></returns>
        public ActionResult Details(string goodsId)
        {

            var request = new GoodsInfoRequest
            {
                Token = RestServiceProxy.GetToken(),
                CurrentPage = "1",
                PageSize = "1",
                IsNeedPage = false,
                GoodsId=goodsId
            };
            string url = GlobalClientConfig.BaseURI + "/Goods/GetGoodsInfo";
            var result = RestServiceProxy.Get<GoodsInfoResponse, GoodsInfoRequest>(request, url);
            return View(result);
        }



        /// <summary>
        /// 魅力圈详情评论提交
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveComment(string txtComment, string txtUser, string articleId)
        {
            var dto = new CommentDTO();
            dto.CommentContent = txtComment;
            dto.MemberId = txtUser;
            dto.Token = RestServiceProxy.GetToken();
            dto.ArticleId = articleId;
            dto.CommentType =1;

            string url = GlobalClientConfig.BaseURI + "/Article/CreateArticleComment/";
            var result = RestServiceProxy.Post<ApiResponseBase, CommentDTO>(dto, url);

            if (result.RspCode == 0)
            {
                
                TempData["sjs"] = "评论成功";
            }
            else
            {

                TempData["ejs"] = "评论失败";
            }
            return Json(result);
        }

        /// <summary>
        /// 魅力圈点赞
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ThumbUp(string txtUser, string articleId)
        {
            var dto = new ThumbUpDto();           
            dto.MemberId = txtUser;
            dto.Token = RestServiceProxy.GetToken();
            dto.ArticleId = articleId;
            string url = GlobalClientConfig.BaseURI + "/Article/CreateArticleLike/";
            var result = RestServiceProxy.Post<ApiResponseBase, ThumbUpDto>(dto, url);
            if (result.RspCode == 0)
            {

                TempData["sjs"] = "点赞成功";
            }
            else
            {

                TempData["ejs"] = "点赞失败";
            }
            return Json(result);
        }


        /// <summary>
        /// 魅力圈取消点赞
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DelThumbUp(string txtUser, string articleId)
        {
            var dto = new ThumbUpDto();
            dto.MemberId = txtUser;
            dto.Token = RestServiceProxy.GetToken();
            dto.ArticleId = articleId;
            string url = GlobalClientConfig.BaseURI + "/Article/DeleteArticleLike/";
            var result = RestServiceProxy.Post<ApiResponseBase, ThumbUpDto>(dto, url);
            if (result.RspCode == 0)
            {

                TempData["sjs"] = "取消点赞成功";
            }
            else
            {

                TempData["ejs"] = "取消点赞失败";
            }
            return Json(result);
        }


        /// <summary>
        /// 魅力圈列表(分页)(滚动条)
        /// </summary>
        /// <returns></returns>

        public JsonResult GetCharmByPage(int CurrentPage)
        {
            var request = new GoodsInfoRequest
            {
                Token = RestServiceProxy.GetToken(),
                CurrentPage = CurrentPage.ToString(),
                PageSize = "9",
                IsNeedPage = true
            };
            if (LoginHelper.Instance.IsLogin()&& LoginHelper.Instance.GetLoginUser<UserInfo>().UserType!=UserTypeEnum.Brand)
            {
                request.BrandId = LoginHelper.Instance.GetLoginUser<UserInfo>().BrandId;
            }
            string url = GlobalClientConfig.BaseURI + "/Goods/GetGoodsInfo";
            var result = RestServiceProxy.Get<GoodsInfoResponse, GoodsInfoRequest>(request, url);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 魅力圈会员评论(分页)(滚动条)
        /// </summary>
        /// <returns></returns>

        public JsonResult GetCharmMemberCommentByPage(int CurrentPage, String articleId)
        {
            var model = new CharmCommentListRequest
            {
                Token = RestServiceProxy.GetToken(),
                CurrentPage = CurrentPage,
                pageSize = 10,
                ArticleId = articleId,
            };
            string url = GlobalClientConfig.BaseURI + "/Article/GetArticleMemberCommentList";
            var result = RestServiceProxy.Get<CharmCommentListResponse, CharmCommentListRequest>(model, url);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="filedata"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Upload()
        {

            var context = this.HttpContext;
            // 如果没有上传文件
            if (context == null)
            {
                return HttpNotFound();
            }


            var filedata = context.Request.Files[0];
            var url = "";
            var mUrl = "";
            string saveName = "";
            // 保存到photos 文件夹中,改变名称
            if (filedata != null)
            {
                string fileName = Path.GetFileName(filedata.FileName); // 原始文件名称
                string fileExtension = Path.GetExtension(fileName); // 文件扩展名
                string newName = Guid.NewGuid().ToString();
                saveName = newName + fileExtension; // 保存文件名称
                string showpath = "/uploadImg/";
                string filePath = Server.MapPath(showpath);
                //   创建目录
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                //   保存原图
                filedata.SaveAs(filePath + saveName);
                url = showpath + saveName;
                //  读取文件
                //FileStream fs = new FileStream(filePath + saveName, FileMode.Open, FileAccess.Read);
                //BinaryReader by = new BinaryReader(fs);
                //int length = (int)fs.Length;
                //byte[] imgbyte = by.ReadBytes(length);

                //MemoryStream ms = new MemoryStream(imgbyte);
                //ms.Seek(0, SeekOrigin.Begin);
                //Image image = Image.FromStream(ms);

                ////System.Drawing.Image image = System.Drawing.Image.FromStream(filedata.InputStream);
                //int width = (int)image.Width;
                //int height =(int)image.Height;  

                //if(height>786 || width>1024){
                //    //   保存原图
                //    //filedata.SaveAs(filePath + saveName);
                //    //   保存缩略图
                //    MakeThumbnail(filePath + saveName, filePath + "min" + saveName, 330, 400, "DB",
                //        fileExtension.ToUpper().Replace(".", ""));
                //    url = showpath + "min" + saveName;

                //}else{
                //    //   保存原图
                //    //filedata.SaveAs(filePath + saveName);
                //    url = showpath + saveName;

                //}     

                return Json(new { Success = true, Url = url ,FileName=saveName});
            }
            return Json(new { Success = false, Url = url , FileName = saveName });
        }

        [HttpPost]
        public ActionResult DeleteImage(string key)
        {
            string showpath = "/uploadImg/";
            string serverPath = Server.MapPath(showpath);
            FileInfo file = new FileInfo(serverPath + key);
            file.Delete();
            return Json(new { Success = true });
        }

        /// <summary>
        /// 缩略图处理
        /// </summary>
        /// <param name="originalImagePath"></param>
        /// <param name="thumbnailPath"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="mode"></param>
        /// <param name="type"></param>
        public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height,
            string mode, string type)
        {
            Image originalImage = Image.FromFile(originalImagePath);

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW": //指定高宽缩放（可能变形） 
                    break;
                case "W": //指定宽，高按比例 
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H": //指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut": //指定高宽裁减（不变形） 
                    if (originalImage.Width / (double)originalImage.Height > towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                case "DB": //等比缩放（不变形，如果高大按高，宽大按宽缩放） 
                    if (originalImage.Width / (double)towidth < originalImage.Height / (double)toheight)
                    {
                        toheight = height;
                        towidth = originalImage.Width * height / originalImage.Height;
                    }
                    else
                    {
                        towidth = width;
                        toheight = originalImage.Height * width / originalImage.Width;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片
            Image bitmap = new Bitmap(towidth, toheight);
            //新建一个画板
            Graphics g = Graphics.FromImage(bitmap);
            //设置高质量插值法
            g.InterpolationMode = InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
                new Rectangle(x, y, ow, oh),
                GraphicsUnit.Pixel);

            try
            {
                //保存缩略图
                if (type == "JPG")
                {
                    bitmap.Save(thumbnailPath, ImageFormat.Jpeg);
                }
                if (type == "BMP")
                {
                    bitmap.Save(thumbnailPath, ImageFormat.Bmp);
                }
                if (type == "GIF")
                {
                    bitmap.Save(thumbnailPath, ImageFormat.Gif);
                }
                if (type == "PNG")
                {
                    bitmap.Save(thumbnailPath, ImageFormat.Png);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }


      
    }
}
