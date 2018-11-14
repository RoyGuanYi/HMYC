using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
	[Serializable]
	public partial class CharmMstGoodsImageDTO
	{ 
		#region	属性
		

		/// <summary>
		/// Goods_Image_Id
		/// </summary>
		[Display(Name = "Goods_Image_Id")]

		[Required(ErrorMessage = "不能为空！")]

		public Guid Goods_Image_Id
		{
			get;
			set;
		}
		

		/// <summary>
		/// Goods_Id
		/// </summary>
		[Display(Name = "Goods_Id")]

		public Guid Goods_Id
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
		

		#endregion	
	}
}