using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Role
{
    [Serializable]
    public partial class Charm_CommonUserActionDTO
    {
        #region	属性


        /// <summary>
        /// MenuName
        /// </summary>
        [Display(Name = "MenuName")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string MenuName
        {
            get;
            set;
        }


        /// <summary>
        /// ActionCategoryName
        /// </summary>
        [Display(Name = "ActionCategoryName")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string ActionCategoryName
        {
            get;
            set;
        }


        /// <summary>
        /// ActionName
        /// </summary>
        [Display(Name = "ActionName")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string ActionName
        {
            get;
            set;
        }


        /// <summary>
        /// ActionUrl
        /// </summary>
        [Display(Name = "ActionUrl")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string ActionUrl
        {
            get;
            set;
        }


        /// <summary>
        /// IsLog
        /// </summary>
        [Display(Name = "IsLog")]

        [Required(ErrorMessage = "不能为空！")]

        public bool IsLog
        {
            get;
            set;
        }


        /// <summary>
        /// IsVisible
        /// </summary>
        [Display(Name = "IsVisible")]

        [Required(ErrorMessage = "不能为空！")]

        public bool IsVisible
        {
            get;
            set;
        }


        /// <summary>
        /// Operation
        /// </summary>
        [Display(Name = "Operation")]

        [Required(ErrorMessage = "不能为空！")]

        public int Operation
        {
            get;
            set;
        }


        /// <summary>
        /// Sort
        /// </summary>
        [Display(Name = "Sort")]

        [Required(ErrorMessage = "不能为空！")]

        public int Sort
        {
            get;
            set;
        }


        /// <summary>
        /// msort
        /// </summary>
        [Display(Name = "msort")]

        [Required(ErrorMessage = "不能为空！")]

        public int msort
        {
            get;
            set;
        }


        #endregion
    }
}