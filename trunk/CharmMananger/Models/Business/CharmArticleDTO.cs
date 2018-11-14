using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
	[Serializable]
	public partial class CharmArticleDTO
	{ 
		#region	属性
		

		/// <summary>
		/// Article_Id
		/// </summary>
		[Display(Name = "Article_Id")]

		[Required(ErrorMessage = "不能为空！")]

		public Guid Article_Id
		{
			get;
			set;
		}
		

		/// <summary>
		/// Article_Title
		/// </summary>
		[Display(Name = "Article_Title")]

		[StringLength(100, ErrorMessage = "不能超过100个字符！")]

		public string Article_Title
		{
			get;
			set;
		}
		

		/// <summary>
		/// Article_Content
		/// </summary>
		[Display(Name = "Article_Content")]

		[StringLength(2147483647, ErrorMessage = "不能超过2147483647个字符！")]

		public string Article_Content
		{
			get;
			set;
		}
		

		/// <summary>
		/// Author
		/// </summary>
		[Display(Name = "Author")]

		[StringLength(50, ErrorMessage = "不能超过50个字符！")]

		public string Author
		{
			get;
			set;
		}
		

		/// <summary>
		/// Keywords
		/// </summary>
		[Display(Name = "Keywords")]

		[StringLength(150, ErrorMessage = "不能超过150个字符！")]

		public string Keywords
		{
			get;
			set;
		}
		

		/// <summary>
		/// 文章类型 1,普通分类2,系统分类 3,网店信息 4, 帮助分类 5,网店帮助
		/// </summary>
		[Display(Name = "文章类型 1,普通分类2,系统分类 3,网店信息 4, 帮助分类 5,网店帮助")]

		public int Article_Type
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
		

		#endregion	
	}
}