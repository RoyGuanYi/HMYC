using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Role
{
    [Serializable]
    public partial class CharmCommonUserInfoDTO
    {
        #region	属性


        /// <summary>
        /// UserId
        /// </summary>
        [Display(Name = "UserId")]

        [Required(ErrorMessage = "不能为空！")]

        public Guid UserId
        {
            get;
            set;
        }


        /// <summary>
        /// UserAccount
        /// </summary>
        [Display(Name = "UserAccount")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserAccount
        {
            get;
            set;
        }


        /// <summary>
        /// UserName
        /// </summary>
        [Display(Name = "UserName")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserName
        {
            get;
            set;
        }


        /// <summary>
        /// UserPassword
        /// </summary>
        [Display(Name = "UserPassword")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string UserPassword
        {
            get;
            set;
        }


        /// <summary>
        /// UserStatus
        /// </summary>
        [Display(Name = "UserStatus")]

        public int UserStatus
        {
            get;
            set;
        }


        /// <summary>
        /// CreateDate
        /// </summary>
        [Display(Name = "CreateDate")]

        public DateTime CreateDate
        {
            get;
            set;
        }


        /// <summary>
        /// CreateBy
        /// </summary>
        [Display(Name = "CreateBy")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string CreateBy
        {
            get;
            set;
        }


        /// <summary>
        /// ModifyBy
        /// </summary>
        [Display(Name = "ModifyBy")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string ModifyBy
        {
            get;
            set;
        }


        /// <summary>
        /// ModifyDate
        /// </summary>
        [Display(Name = "ModifyDate")]

        public DateTime ModifyDate
        {
            get;
            set;
        }


        /// <summary>
        /// UserPhone
        /// </summary>
        [Display(Name = "UserPhone")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserPhone
        {
            get;
            set;
        }


        /// <summary>
        /// UserEmail
        /// </summary>
        [Display(Name = "UserEmail")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string UserEmail
        {
            get;
            set;
        }


        /// <summary>
        /// UserFax
        /// </summary>
        [Display(Name = "UserFax")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserFax
        {
            get;
            set;
        }


        /// <summary>
        /// UserQQ
        /// </summary>
        [Display(Name = "UserQQ")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserQQ
        {
            get;
            set;
        }


        /// <summary>
        /// UserAddress
        /// </summary>
        [Display(Name = "UserAddress")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string UserAddress
        {
            get;
            set;
        }


        /// <summary>
        /// UserMobile
        /// </summary>
        [Display(Name = "UserMobile")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserMobile
        {
            get;
            set;
        }


        /// <summary>
        /// UserIDNumber
        /// </summary>
        [Display(Name = "UserIDNumber")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string UserIDNumber
        {
            get;
            set;
        }


        /// <summary>
        /// UserLastLoginDate
        /// </summary>
        [Display(Name = "UserLastLoginDate")]

        public DateTime UserLastLoginDate
        {
            get;
            set;
        }


        /// <summary>
        /// UserLoginCount
        /// </summary>
        [Display(Name = "UserLoginCount")]

        public int UserLoginCount
        {
            get;
            set;
        }

        /// <summary>
        /// RememberMe
        /// </summary>
        [Display(Name = "RememberMe")]
        public bool IsRememberMe { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        [Display(Name ="AuthCode")]
        public string AuthCode { get; set; }

        #endregion
    }
}