using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Business
{
	[Serializable]
	public partial class CharmBusinessBrandDTO
	{ 
		#region	属性
		

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

		[Required(ErrorMessage = "不能为空！")]
		[StringLength(60, ErrorMessage = "不能超过60个字符！")]

		public string Brand_Name
		{
			get;
			set;
		}
		

		/// <summary>
		/// Brand_Logo
		/// </summary>
		[Display(Name = "Brand_Logo")]

		[Required(ErrorMessage = "不能为空！")]
		[StringLength(80, ErrorMessage = "不能超过80个字符！")]

		public string Brand_Logo
		{
			get;
			set;
		}
		

		/// <summary>
		/// Brand_Desc
		/// </summary>
		[Display(Name = "Brand_Desc")]

		[StringLength(200, ErrorMessage = "不能超过200个字符！")]

		public string Brand_Desc
		{
			get;
			set;
		}
		

		/// <summary>
		/// Site_Url
		/// </summary>
		[Display(Name = "Site_Url")]

		[StringLength(100, ErrorMessage = "不能超过100个字符！")]

		public string Site_Url
		{
			get;
			set;
		}
		

		/// <summary>
		/// Site_Short_Url
		/// </summary>
		[Display(Name = "Site_Short_Url")]

		[StringLength(50, ErrorMessage = "不能超过50个字符！")]

		public string Site_Short_Url
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
		/// Is_Show
		/// </summary>
		[Display(Name = "Is_Show")]

		public bool Is_Show
		{
			get;
			set;
		}
		

		/// <summary>
		/// Is_Hot
		/// </summary>
		[Display(Name = "Is_Hot")]

		public bool Is_Hot
		{
			get;
			set;
		}
		

		/// <summary>
		/// 商家编号，唯一不能重复，跟在URL后的QUERYSTRING。
		/// </summary>
		[Display(Name = "商家编号，唯一不能重复，跟在URL后的QUERYSTRING。")]

		[Required(ErrorMessage = "商家编号，唯一不能重复，跟在URL后的QUERYSTRING。不能为空！")]

		public int Brand_Code
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
		/// 商家联系方式
		/// </summary>
		[Display(Name = "商家联系方式")]

		[StringLength(20, ErrorMessage = "商家联系方式不能超过20个字符！")]

		public string Brand_Phone
		{
			get;
			set;
		}


        /// <summary>
        /// UserAccount
        /// </summary>
        [Display(Name = "UserAccount")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserAccount
        {
            get;
            set;
        }


        /// <summary>
        /// UserName
        /// </summary>
        [Display(Name = "UserName")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string UserName
        {
            get;
            set;
        }


        /// <summary>
        /// UserPassword
        /// </summary>
        [Display(Name = "UserPassword")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string UserPassword
        {
            get;
            set;
        }

        /// <summary>
        /// 新密码
        /// </summary>
        [Display(Name = "NewUserPassword")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string NewUserPassword
        {
            get;
            set;
        }


        #endregion
    }
}