using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharmMananger.Models.Business
{
    [Serializable]
    public partial class CharmGoodsInfoDTO
    {
        #region	属性


        /// <summary>
        /// Goods_id
        /// </summary>
        [Display(Name = "Goods_id")]

        [Required(ErrorMessage = "不能为空！")]

        public Guid Goods_id
        {
            get;
            set;
        }


        /// <summary>
        /// Goods_Name
        /// </summary>
        [Display(Name = "Goods_Name")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Goods_Name
        {
            get;
            set;
        }


        /// <summary>
        /// Click_Count
        /// </summary>
        [Display(Name = "Click_Count")]

        [Required(ErrorMessage = "不能为空！")]

        public int Click_Count
        {
            get;
            set;
        }


        /// <summary>
        /// Market_Price
        /// </summary>
        [Display(Name = "Market_Price")]

        [Required(ErrorMessage = "不能为空！")]

        public decimal Market_Price
        {
            get;
            set;
        }


        /// <summary>
        /// Shop_Price
        /// </summary>
        [Display(Name = "Shop_Price")]

        [Required(ErrorMessage = "不能为空！")]

        public decimal Shop_Price
        {
            get;
            set;
        }


        /// <summary>
        /// Goods_Keywords
        /// </summary>
        [Display(Name = "Goods_Keywords")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Goods_Keywords
        {
            get;
            set;
        }


        /// <summary>
        /// Goods_Brief
        /// </summary>
        [Display(Name = "Goods_Brief")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Goods_Brief
        {
            get;
            set;
        }


        /// <summary>
        /// Goods_Desc
        /// </summary>
        [Display(Name = "Goods_Desc")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Goods_Desc
        {
            get;
            set;
        }


        /// <summary>
        /// Goods_Thumb_Img
        /// </summary>
        [Display(Name = "Goods_Thumb_Img")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Goods_Thumb_Img
        {
            get;
            set;
        }


        /// <summary>
        /// Goods_Real_Img
        /// </summary>
        [Display(Name = "Goods_Real_Img")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Goods_Real_Img
        {
            get;
            set;
        }


        /// <summary>
        /// Goods_Original_Img
        /// </summary>
        [Display(Name = "Goods_Original_Img")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Goods_Original_Img
        {
            get;
            set;
        }


        /// <summary>
        /// Is_Real_Goods
        /// </summary>
        [Display(Name = "Is_Real_Goods")]

        [Required(ErrorMessage = "不能为空！")]

        public bool Is_Real_Goods
        {
            get;
            set;
        }
        public string IsRealGoodsShow { get; set; }

        /// <summary>
        /// Is_OnSale
        /// </summary>
        [Display(Name = "Is_OnSale")]

        [Required(ErrorMessage = "不能为空！")]

        public bool Is_OnSale
        {
            get;
            set;
        }
        public string IsOnSaleShow { get; set; }

        /// <summary>
        /// Sort_Order
        /// </summary>
        [Display(Name = "Sort_Order")]

        [Required(ErrorMessage = "不能为空！")]

        public int Sort_Order
        {
            get;
            set;
        }


        /// <summary>
        /// Create_By
        /// </summary>
        [Display(Name = "Create_By")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Create_By
        {
            get;
            set;
        }


        /// <summary>
        /// Create_Time
        /// </summary>
        [Display(Name = "Create_Time")]

        [Required(ErrorMessage = "不能为空！")]

        public DateTime Create_Time
        {
            get;
            set;
        }


        /// <summary>
        /// Modify_By
        /// </summary>
        [Display(Name = "Modify_By")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Modify_By
        {
            get;
            set;
        }


        /// <summary>
        /// Modify_Time
        /// </summary>
        [Display(Name = "Modify_Time")]

        [Required(ErrorMessage = "不能为空！")]

        public DateTime Modify_Time
        {
            get;
            set;
        }


        /// <summary>
        /// Modify_By_Admin
        /// </summary>
        [Display(Name = "Modify_By_Admin")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Modify_By_Admin
        {
            get;
            set;
        }


        /// <summary>
        /// Modify_Time_Admin
        /// </summary>
        [Display(Name = "Modify_Time_Admin")]

        [Required(ErrorMessage = "不能为空！")]

        public DateTime Modify_Time_Admin
        {
            get;
            set;
        }


        /// <summary>
        /// Category_Id
        /// </summary>
        [Display(Name = "Category_Id")]

        [Required(ErrorMessage = "不能为空！")]

        public int Category_Id
        {
            get;
            set;
        }


        /// <summary>
        /// Brand_Id
        /// </summary>
        [Display(Name = "Brand_Id")]

        [Required(ErrorMessage = "不能为空！")]

        public Guid Brand_Id
        {
            get;
            set;
        }


        /// <summary>
        /// Collection_Count
        /// </summary>
        [Display(Name = "Collection_Count")]

        [Required(ErrorMessage = "不能为空！")]

        public int Collection_Count
        {
            get;
            set;
        }


        /// <summary>
        /// Brand_Name
        /// </summary>
        [Display(Name = "Brand_Name")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Brand_Name
        {
            get;
            set;
        }


        /// <summary>
        /// Category_Name
        /// </summary>
        [Display(Name = "Category_Name")]

        [Required(ErrorMessage = "不能为空！")]
        [StringLength(0, ErrorMessage = "不能超过0个字符！")]

        public string Category_Name
        {
            get;
            set;
        }


        #endregion
    }

}