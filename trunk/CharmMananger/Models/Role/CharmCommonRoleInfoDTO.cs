using System;
using System.ComponentModel.DataAnnotations;

namespace CharmMananger.Models.Role
{
    [Serializable]
    public partial class CharmCommonRoleInfoDTO
    {
        #region	属性


        /// <summary>
        /// RoleId
        /// </summary>
        [Display(Name = "RoleId")]

        [Required(ErrorMessage = "不能为空！")]

        public Guid RoleId
        {
            get;
            set;
        }


        /// <summary>
        /// RoleName
        /// </summary>
        [Display(Name = "RoleName")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string RoleName
        {
            get;
            set;
        }


        /// <summary>
        /// RoleCode
        /// </summary>
        [Display(Name = "RoleCode")]

        [StringLength(20, ErrorMessage = "不能超过20个字符！")]

        public string RoleCode
        {
            get;
            set;
        }


        /// <summary>
        /// IsEnable
        /// </summary>
        [Display(Name = "IsEnable")]

        public bool IsEnable
        {
            get;
            set;
        }


        /// <summary>
        /// IsSysDefault
        /// </summary>
        [Display(Name = "IsSysDefault")]

        public bool IsSysDefault
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
        /// CreateBy
        /// </summary>
        [Display(Name = "CreateBy")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string CreateBy
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
        /// ModifyBy
        /// </summary>
        [Display(Name = "ModifyBy")]

        [StringLength(50, ErrorMessage = "不能超过50个字符！")]

        public string ModifyBy
        {
            get;
            set;
        }


        #endregion
    }
}