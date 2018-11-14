using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
	[Serializable]
	public partial class CharmMstCategoryDTO
	{ 
		#region	属性
		

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
		/// Category_Name
		/// </summary>
		[Display(Name = "Category_Name")]

		[Required(ErrorMessage = "不能为空！")]
		[StringLength(50, ErrorMessage = "不能超过50个字符！")]

		public string Category_Name
		{
			get;
			set;
		}
		

		/// <summary>
		/// 搜索关键字，索引用。
		/// </summary>
		[Display(Name = "搜索关键字，索引用。")]

		[StringLength(50, ErrorMessage = "搜索关键字，索引用。不能超过50个字符！")]

		public string Keywords
		{
			get;
			set;
		}
		

		/// <summary>
		/// Category_Desc
		/// </summary>
		[Display(Name = "Category_Desc")]

		[StringLength(200, ErrorMessage = "不能超过200个字符！")]

		public string Category_Desc
		{
			get;
			set;
		}
		

		/// <summary>
		/// 父级ID
		/// </summary>
		[Display(Name = "父级ID")]

		public int Parent_id
		{
			get;
			set;
		}
		

		/// <summary>
		/// 排序，数字越小越往前。
		/// </summary>
		[Display(Name = "排序，数字越小越往前。")]

		public int Sort_Order
		{
			get;
			set;
		}
		

		/// <summary>
		/// Is_Show
		/// </summary>
		[Display(Name = "Is_Show")]

		public bool Is_Show
		{
			get;
			set;
		}
		

		#endregion	
	}
}