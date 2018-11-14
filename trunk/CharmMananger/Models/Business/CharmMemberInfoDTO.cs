using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
    [Serializable]
    public partial class CharmMemberInfoDTO
    {
        #region	属性


        /// <summary>
        /// Member_Id
        /// </summary>
        [Display(Name = "Member_Id")]

        [Required(ErrorMessage = "不能为空！")]

        public Guid Member_Id
        {
            get;
            set;
        }


        /// <summary>
        /// User_Name
        /// </summary>
        [Display(Name = "User_Name")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string User_Name
        {
            get;
            set;
        }


        /// <summary>
        /// 微信的OpenId
        /// </summary>
        [Display(Name = "微信的OpenId")]

        [StringLength(50, ErrorMessage = "微信的OpenId不能超过50个字符！")]

        public string Wechat_Id
        {
            get;
            set;
        }


        /// <summary>
        /// 用户头像
        /// </summary>
        [Display(Name = "用户头像")]

        [StringLength(50, ErrorMessage = "用户头像不能超过50个字符！")]

        public string User_Avatar
        {
            get;
            set;
        }


        /// <summary>
        /// User_Phone
        /// </summary>
        [Display(Name = "User_Phone")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string User_Phone
        {
            get;
            set;
        }


        /// <summary>
        /// 0:普通，1:微信。
        /// </summary>
        [Display(Name = "0:普通，1:微信。")]

        public int User_Source
        {
            get;
            set;
        }
        /// <summary>
        /// 微信来源页面显示
        /// </summary>
        public string User_Source_Show { get; set; }

        /// <summary>
        /// Login_Count
        /// </summary>
        [Display(Name = "Login_Count")]

        public int Login_Count
        {
            get;
            set;
        }


        /// <summary>
        /// Create_By
        /// </summary>
        [Display(Name = "Create_By")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string Create_By
        {
            get;
            set;
        }


        /// <summary>
        /// Create_Time
        /// </summary>
        [Display(Name = "Create_Time")]

        public DateTime Create_Time
        {
            get;
            set;
        }


        /// <summary>
        /// Modify_By
        /// </summary>
        [Display(Name = "Modify_By")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string Modify_By
        {
            get;
            set;
        }


        /// <summary>
        /// Modify_Time
        /// </summary>
        [Display(Name = "Modify_Time")]

        public DateTime Modify_Time
        {
            get;
            set;
        }


        /// <summary>
        /// 网页授权接口调用凭证
        /// </summary>
        [Display(Name = "网页授权接口调用凭证")]

        [StringLength(150, ErrorMessage = "网页授权接口调用凭证不能超过150个字符！")]

        public string Wc_AccessToken
        {
            get;
            set;
        }


        /// <summary>
        /// 用户刷新access_token
        /// </summary>
        [Display(Name = "用户刷新access_token")]

        [StringLength(150, ErrorMessage = "用户刷新access_token不能超过150个字符！")]

        public string Wc_RefreshToken
        {
            get;
            set;
        }


        /// <summary>
        /// Wc_AccessToken_ExpireDate
        /// </summary>
        [Display(Name = "Wc_AccessToken_ExpireDate")]

        public DateTime Wc_AccessToken_ExpireDate
        {
            get;
            set;
        }


        /// <summary>
        /// Wc_RefreshToken_ExpireDate
        /// </summary>
        [Display(Name = "Wc_RefreshToken_ExpireDate")]

        public DateTime Wc_RefreshToken_ExpireDate
        {
            get;
            set;
        }


        /// <summary>
        /// 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
        /// </summary>
        [Display(Name = "用户的性别，值为1时是男性，值为2时是女性，值为0时是未知")]

        public int Wc_Sex
        {
            get;
            set;
        }

        /// <summary>
        /// 性别页面显示
        /// </summary>
        public string Sex_Show { get; set; }

        /// <summary>
        /// Wc_Province
        /// </summary>
        [Display(Name = "Wc_Province")]

        [StringLength(10, ErrorMessage = "不能超过10个字符！")]

        public string Wc_Province
        {
            get;
            set;
        }


        /// <summary>
        /// Wc_City
        /// </summary>
        [Display(Name = "Wc_City")]

        [StringLength(10, ErrorMessage = "不能超过10个字符！")]

        public string Wc_City
        {
            get;
            set;
        }


        /// <summary>
        /// Wc_Country
        /// </summary>
        [Display(Name = "Wc_Country")]

        [StringLength(10, ErrorMessage = "不能超过10个字符！")]

        public string Wc_Country
        {
            get;
            set;
        }


        /// <summary>
        /// 用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）
        /// </summary>
        [Display(Name = "用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）")]

        [StringLength(500, ErrorMessage = "用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）不能超过500个字符！")]

        public string Wc_Privilege
        {
            get;
            set;
        }


        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段
        /// </summary>
        [Display(Name = "只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段")]

        [StringLength(50, ErrorMessage = "只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段不能超过50个字符！")]

        public string Wc_UnionId
        {
            get;
            set;
        }


        #endregion
    }
}