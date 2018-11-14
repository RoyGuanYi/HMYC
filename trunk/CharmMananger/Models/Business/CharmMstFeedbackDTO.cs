using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
	[Serializable]
	public partial class CharmMstFeedbackDTO
	{ 
		#region	属性
		

		/// <summary>
		/// Feedback_Id
		/// </summary>
		[Display(Name = "Feedback_Id")]

		[Required(ErrorMessage = "不能为空！")]

		public Guid Feedback_Id
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
		/// Brand_Name
		/// </summary>
		[Display(Name = "Brand_Name")]

		[StringLength(50, ErrorMessage = "不能超过50个字符！")]

		public string Brand_Name
		{
			get;
			set;
		}
		

		/// <summary>
		/// Feedback_Content
		/// </summary>
		[Display(Name = "Feedback_Content")]

		[StringLength(2147483647, ErrorMessage = "不能超过2147483647个字符！")]

		public string Feedback_Content
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
		/// 回复的哪条评论
		/// </summary>
		[Display(Name = "回复的哪条评论")]

		public Guid Comment_Id
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