using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
	[Serializable]
	public partial class CharmMstGoodsDTO
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
		[StringLength(50, ErrorMessage = "不能超过50个字符！")]

		public string Goods_Name
		{
			get;
			set;
		}
		

		/// <summary>
		/// 商品被点击的次数
		/// </summary>
		[Display(Name = "商品被点击的次数")]

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
		/// 商品关键字，走索引查询用。
		/// </summary>
		[Display(Name = "商品关键字，走索引查询用。")]

		[StringLength(50, ErrorMessage = "商品关键字，走索引查询用。不能超过50个字符！")]

		public string Goods_Keywords
		{
			get;
			set;
		}
		

		/// <summary>
		/// 商品简介
		/// </summary>
		[Display(Name = "商品简介")]

		[StringLength(255, ErrorMessage = "商品简介不能超过255个字符！")]

		public string Goods_Brief
		{
			get;
			set;
		}
		

		/// <summary>
		/// 商品详细介绍
		/// </summary>
		[Display(Name = "商品详细介绍")]

		[StringLength(2147483647, ErrorMessage = "商品详细介绍不能超过2147483647个字符！")]

		public string Goods_Desc
		{
			get;
			set;
		}
		

		/// <summary>
		/// 缩略图
		/// </summary>
		[Display(Name = "缩略图")]

		[StringLength(200, ErrorMessage = "缩略图不能超过200个字符！")]

		public string Goods_Thumb_Img
		{
			get;
			set;
		}
		

		/// <summary>
		/// 实际图片大小
		/// </summary>
		[Display(Name = "实际图片大小")]

		[StringLength(200, ErrorMessage = "实际图片大小不能超过200个字符！")]

		public string Goods_Real_Img
		{
			get;
			set;
		}
		

		/// <summary>
		/// 商家上传图片
		/// </summary>
		[Display(Name = "商家上传图片")]

		[StringLength(200, ErrorMessage = "商家上传图片不能超过200个字符！")]

		public string Goods_Original_Img
		{
			get;
			set;
		}
		

		/// <summary>
		/// 是否是实物，1，是；0，否；比如虚拟卡就为0，不是实物
		/// </summary>
		[Display(Name = "是否是实物，1，是；0，否；比如虚拟卡就为0，不是实物")]

		public bool Is_Real_Goods
		{
			get;
			set;
		}
		

		/// <summary>
		/// 是否开放销售
		/// </summary>
		[Display(Name = "是否开放销售")]

		public bool Is_OnSale
		{
			get;
			set;
		}
		

		/// <summary>
		/// Sort_Order
		/// </summary>
		[Display(Name = "Sort_Order")]

		public int Sort_Order
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
		/// Modify_By_Admin
		/// </summary>
		[Display(Name = "Modify_By_Admin")]

		[StringLength(50, ErrorMessage = "不能超过50个字符！")]

		public string Modify_By_Admin
		{
			get;
			set;
		}
		

		/// <summary>
		/// Modify_Time_Admin
		/// </summary>
		[Display(Name = "Modify_Time_Admin")]

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
		/// 商家ID
		/// </summary>
		[Display(Name = "商家ID")]

		[Required(ErrorMessage = "商家ID不能为空！")]

		public Guid Brand_Id
		{
			get;
			set;
		}
		

		/// <summary>
		/// 商品被用户收藏的次数
		/// </summary>
		[Display(Name = "商品被用户收藏的次数")]

		public int Collection_Count
		{
			get;
			set;
		}
		

		#endregion	
	}
}