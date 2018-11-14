using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Role
{
    [Serializable]
    public partial class CharmCommonActionInfoDTO
    {
        #region	属性


        /// <summary>
        /// ActionId
        /// </summary>
        [Display(Name = "ActionId")]

        [Required(ErrorMessage = "不能为空！")]

        public Guid ActionId
        {
            get;
            set;
        }


        /// <summary>
        /// ActionCategoryName
        /// </summary>
        [Display(Name = "ActionCategoryName")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string ActionCategoryName
        {
            get;
            set;
        }


        /// <summary>
        /// ActionName
        /// </summary>
        [Display(Name = "ActionName")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string ActionName
        {
            get;
            set;
        }


        /// <summary>
        /// ActionUrl
        /// </summary>
        [Display(Name = "ActionUrl")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string ActionUrl
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
        /// IsVisible
        /// </summary>
        [Display(Name = "IsVisible")]

        public bool IsVisible
        {
            get;
            set;
        }


        /// <summary>
        /// IsLog
        /// </summary>
        [Display(Name = "IsLog")]

        public bool IsLog
        {
            get;
            set;
        }


        /// <summary>
        /// Operation
        /// </summary>
        [Display(Name = "Operation")]

        public int Operation
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
        /// MenuId
        /// </summary>
        [Display(Name = "MenuId")]

        public Guid MenuId
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