using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Security;
using Charm.Entity.Role;
using Charm.MvcExt.Base;
using Charm.MvcExt.Extisions;
using Charm.MvcExt.Filter;
using Charm.MvcExt.User;
using Charm.Services.GenServices;
using CharmMananger.Models.Role;
using Microsoft.Practices.Unity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Drawing.Imaging;
using System.Web;
using Charm.Common;

namespace CharmMananger.Controllers
{
    public class HomeController : BaseController
    {

        [Dependency]
        public ICharmCommonUserInfoService CharmCommonUserInfoService { get; set; }

        [Dependency]
        public ICharm_CommonUserActionService CharmCommonUserActionService { get; set; }

        [LoginFilter]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            

            //获取cook登陆信息
            HttpCookie cookie = Request.Cookies["CharmUserInfo"];
            CharmCommonUserInfoDTO model = new CharmCommonUserInfoDTO();
            if (cookie!=null)
            {
                model.IsRememberMe = true;
                model.UserAccount = Server.HtmlEncode(cookie.Values["UserAccount"]);
                model.UserPassword = Server.HtmlEncode(cookie.Values["UserPassword"]);
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(CharmCommonUserInfoDTO model)
        {
            var users = CharmCommonUserInfoService.GetModels(" AND UserAccount=?", string.Empty, model.UserAccount);
           // var users = new List<CharmCommonUserInfo>()
           //{
           //    new CharmCommonUserInfo() { UserAccount=model.UserAccount,UserPassword=model.UserPassword}
           //};
            //if (user != null)
            //{
            //    LoginHelper.Instance.Login(() => new UserBase()
            //    {
            //        Account = model.UserName
            //    });
            //    FormsAuthentication.SetAuthCookie(model.UserName, true);
            //    return RedirectToAction("Index");
            //}
            if (users.Count > 0)
            {
                var user = users[0];
                LoginHelper.Instance.Login(() =>
                {
                    return new UserBase()
                    {
                        Account = user.UserAccount,
                        IpAddress = Kernel.GetIP(),
                        UserName = user.UserName,
                        UserId = user.UserId
                    };
                });
                //添加权限
                var userActions = CharmCommonUserActionService.GetModels(" AND ur.userId=?", String.Empty, user.UserId);

                //var userActions = CharmCommonUserActionService.GetUserActions("ur.userId=@userId", new Dictionary<string, object>()
                //{
                //    {"@userId",user.UserId}
                //}, " m.Sort,a.sort");

                LoginHelper.Instance.CacheRoles(() =>
                {
                    var userroles = new UserRoles();
                    userActions.ForEach(p =>
                        userroles.AddRole(p.ActionUrl, p.ActionName, p.ActionCategoryName));
                    return userroles;
                });

                LoginHelper.Instance.CacheMeuns(() =>
                {
                    var usermenu = new UserMenus();
                    userActions.ForEach(p =>
                        {
                            if (p.IsVisible)
                                usermenu.Add(p.MenuName, p.ActionName, p.ActionUrl);
                        }

                    );
                    return usermenu;
                });
                //发送客户端cookie
                HttpCookie cookie =Request.Cookies["CharmUserInfo"];
                if (model.IsRememberMe)
                {
                    if (cookie != null)
                    {
                        cookie.Values["UserAccount"] =Server.HtmlDecode(user.UserAccount);
                        cookie.Values["UserPassword"] = Server.HtmlDecode(user.UserPassword);
                    }
                    else
                    {
                        cookie = new HttpCookie("CharmUserInfo");
                        cookie.Values["UserAccount"] = Server.HtmlDecode(user.UserAccount);
                        cookie.Values["UserPassword"] = Server.HtmlDecode(user.UserPassword);
                    }
                    cookie.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie);
                }
                else
                {
                    if (cookie!=null)
                    {
                        Request.Cookies.Remove("CharmUserInfo");
                    }
                }

                FormsAuthentication.SetAuthCookie(model.UserName, true);


                return RedirectToAction("index");
            }
            ModelState.AddModelError("esg", "账号不存在");
            return View();
        }

        /// <summary>
        /// 注销
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            LoginHelper.Instance.LogOut();

            return this.View("Login");
        }

        public ActionResult SecurityCode()
        {
            string oldcode = TempData["SecurityCode"] as string;
            string code = CreateRandomCode(4); //验证码的字符为4个
            TempData["SecurityCode"] = code; //验证码存放在TempData中
            return File(CreateValidateGraphic(code), "image/Jpeg");
        }

        /// <summary>
        /// 生成随机的字符串
        /// </summary>
        /// <param name="codeCount"></param>
        /// <returns></returns>
        public string CreateRandomCode(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,a,b,c,d,e,f,g,h,i,g,k,l,m,n,o,p,q,r,F,G,H,I,G,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,s,t,u,v,w,x,y,z";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(35);
                if (temp == t)
                {
                    return CreateRandomCode(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }

        /// <summary>
        /// 创建验证码图片
        /// </summary>
        /// <param name="validateCode"></param>
        /// <returns></returns>
        public byte[] CreateValidateGraphic(string validateCode)
        {
            Bitmap image = new Bitmap((int)Math.Ceiling(validateCode.Length * 16.0), 27);
            Graphics g = Graphics.FromImage(image);
            try
            {
                //生成随机生成器
                Random random = new Random();
                //清空图片背景色
                g.Clear(Color.White);
                //画图片的干扰线
                for (int i = 0; i < 25; i++)
                {
                    int x1 = random.Next(image.Width);
                    int x2 = random.Next(image.Width);
                    int y1 = random.Next(image.Height);
                    int y2 = random.Next(image.Height);
                    g.DrawLine(new Pen(Color.Silver), x1, x2, y1, y2);
                }
                Font font = new Font("Arial", 13, (FontStyle.Bold | FontStyle.Italic));
                LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2f, true);
                g.DrawString(validateCode, font, brush, 3, 2);

                //画图片的前景干扰线
                for (int i = 0; i < 100; i++)
                {
                    int x = random.Next(image.Width);
                    int y = random.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(random.Next()));
                }
                //画图片的边框线
                g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);

                //保存图片数据
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);

                //输出图片流
                return stream.ToArray();
            }
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }

    }
}