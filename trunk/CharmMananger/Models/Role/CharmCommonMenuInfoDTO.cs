using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Role
{
    [Serializable]
    public partial class CharmCommonMenuInfoDTO
    {
        #region	属性


        /// <summary>
        /// MenuId
        /// </summary>
        [Display(Name = "MenuId")]

        [Required(ErrorMessage = "不能为空！")]

        public Guid MenuId
        {
            get;
            set;
        }


        /// <summary>
        /// MenuName
        /// </summary>
        [Display(Name = "MenuName")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string MenuName
        {
            get;
            set;
        }


        /// <summary>
        /// IsAllowAnonymousAccess
        /// </summary>
        [Display(Name = "IsAllowAnonymousAccess")]

        public bool IsAllowAnonymousAccess
        {
            get;
            set;
        }


        /// <summary>
        /// IsEnable
        /// </summary>
        [Display(Name = "IsEnable")]

        public bool IsEnable
        {
            get;
            set;
        }


        /// <summary>
        /// Sort
        /// </summary>
        [Display(Name = "Sort")]

        public int Sort
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

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string CreateBy
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
        /// ModifyBy
        /// </summary>
        [Display(Name = "ModifyBy")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string ModifyBy
        {
            get;
            set;
        }


        #endregion
    }
}