using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Role
{
	[Serializable]
	public partial class CharmCommonRoleActionDTO
	{ 
		#region	属性
		

		/// <summary>
		/// RoleActionId
		/// </summary>
		[Display(Name = "RoleActionId")]

		[Required(ErrorMessage = "不能为空！")]

		public Guid RoleActionId
		{
			get;
			set;
		}
		

		/// <summary>
		/// ActionId
		/// </summary>
		[Display(Name = "ActionId")]

		public Guid ActionId
		{
			get;
			set;
		}
		

		/// <summary>
		/// RoleId
		/// </summary>
		[Display(Name = "RoleId")]

		public Guid RoleId
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
		/// CreateUserId
		/// </summary>
		[Display(Name = "CreateUserId")]

		public Guid CreateUserId
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
		/// ModifyUserId
		/// </summary>
		[Display(Name = "ModifyUserId")]

		public Guid ModifyUserId
		{
			get;
			set;
		}
		

		#endregion	
	}
}