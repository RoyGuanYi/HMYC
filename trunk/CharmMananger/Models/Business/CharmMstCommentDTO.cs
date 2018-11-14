using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
	[Serializable]
	public partial class CharmMstCommentDTO
	{ 
		#region	属性
		

		/// <summary>
		/// Comment_Id
		/// </summary>
		[Display(Name = "Comment_Id")]

		[Required(ErrorMessage = "不能为空！")]

		public Guid Comment_Id
		{
			get;
			set;
		}
		

		/// <summary>
		/// 0:评论的商品，1:评论的文章
		/// </summary>
		[Display(Name = "0:评论的商品，1:评论的文章")]

		[Required(ErrorMessage = "0:评论的商品，1:评论的文章不能为空！")]

		public int Comment_Type
		{
			get;
			set;
		}
		

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
		/// Comment_Content
		/// </summary>
		[Display(Name = "Comment_Content")]

		[StringLength(2147483647, ErrorMessage = "不能超过2147483647个字符！")]

		public string Comment_Content
		{
			get;
			set;
		}
		

		/// <summary>
		/// 评星
		/// </summary>
		[Display(Name = "评星")]

		public int Comment_Rank
		{
			get;
			set;
		}
		

		/// <summary>
		/// Ip_Address
		/// </summary>
		[Display(Name = "Ip_Address")]

		[StringLength(20, ErrorMessage = "不能超过20个字符！")]

		public string Ip_Address
		{
			get;
			set;
		}
		

		/// <summary>
		/// 是否被管理员批准显示;1是;0未批准显示
		/// </summary>
		[Display(Name = "是否被管理员批准显示;1是;0未批准显示")]

		public bool Status
		{
			get;
			set;
		}
		

		/// <summary>
		/// 新闻或者商品的Id
		/// </summary>
		[Display(Name = "新闻或者商品的Id")]

		public Guid Relation_Id
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
		/// 是否回复
		/// </summary>
		[Display(Name = "是否回复")]

		public bool Is_Feedback
		{
			get;
			set;
		}
		

		#endregion	
	}
}