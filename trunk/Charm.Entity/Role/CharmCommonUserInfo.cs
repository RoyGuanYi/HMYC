using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Oct.Framework.DB.Base;
using Oct.Framework.DB.Core;
using Oct.Framework.DB.Interface;

namespace Charm.Entity.Role
{
    [Serializable]
    public partial class CharmCommonUserInfo : BaseEntity<CharmCommonUserInfo>
    {
        #region	属性


        private Guid _userId;

        /// <summary>
        /// UserId
        /// </summary>
        public Guid UserId
        {
            get
            {
                return this._userId;
            }
            set
            {
                this.PropChanged("UserId", this._userId, value);

                this._userId = value;
            }
        }


        private string _userAccount;

        /// <summary>
        /// UserAccount
        /// </summary>
        public string UserAccount
        {
            get
            {
                return this._userAccount;
            }
            set
            {
                this.PropChanged("UserAccount", this._userAccount, value);

                this._userAccount = value;
            }
        }


        private string _userName;

        /// <summary>
        /// UserName
        /// </summary>
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this.PropChanged("UserName", this._userName, value);

                this._userName = value;
            }
        }


        private string _userPassword;

        /// <summary>
        /// UserPassword
        /// </summary>
        public string UserPassword
        {
            get
            {
                return this._userPassword;
            }
            set
            {
                this.PropChanged("UserPassword", this._userPassword, value);

                this._userPassword = value;
            }
        }


        private int? _userStatus;

        /// <summary>
        /// UserStatus
        /// </summary>
        public int? UserStatus
        {
            get
            {
                return this._userStatus;
            }
            set
            {
                this.PropChanged("UserStatus", this._userStatus, value);

                this._userStatus = value;
            }
        }


        private DateTime? _createDate;

        /// <summary>
        /// CreateDate
        /// </summary>
        public DateTime? CreateDate
        {
            get
            {
                return this._createDate;
            }
            set
            {
                this.PropChanged("CreateDate", this._createDate, value);

                this._createDate = value;
            }
        }


        private string _createBy;

        /// <summary>
        /// CreateBy
        /// </summary>
        public string CreateBy
        {
            get
            {
                return this._createBy;
            }
            set
            {
                this.PropChanged("CreateBy", this._createBy, value);

                this._createBy = value;
            }
        }


        private string _modifyBy;

        /// <summary>
        /// ModifyBy
        /// </summary>
        public string ModifyBy
        {
            get
            {
                return this._modifyBy;
            }
            set
            {
                this.PropChanged("ModifyBy", this._modifyBy, value);

                this._modifyBy = value;
            }
        }


        private DateTime? _modifyDate;

        /// <summary>
        /// ModifyDate
        /// </summary>
        public DateTime? ModifyDate
        {
            get
            {
                return this._modifyDate;
            }
            set
            {
                this.PropChanged("ModifyDate", this._modifyDate, value);

                this._modifyDate = value;
            }
        }


        private string _userPhone;

        /// <summary>
        /// UserPhone
        /// </summary>
        public string UserPhone
        {
            get
            {
                return this._userPhone;
            }
            set
            {
                this.PropChanged("UserPhone", this._userPhone, value);

                this._userPhone = value;
            }
        }


        private string _userEmail;

        /// <summary>
        /// UserEmail
        /// </summary>
        public string UserEmail
        {
            get
            {
                return this._userEmail;
            }
            set
            {
                this.PropChanged("UserEmail", this._userEmail, value);

                this._userEmail = value;
            }
        }


        private string _userFax;

        /// <summary>
        /// UserFax
        /// </summary>
        public string UserFax
        {
            get
            {
                return this._userFax;
            }
            set
            {
                this.PropChanged("UserFax", this._userFax, value);

                this._userFax = value;
            }
        }


        private string _userQQ;

        /// <summary>
        /// UserQQ
        /// </summary>
        public string UserQQ
        {
            get
            {
                return this._userQQ;
            }
            set
            {
                this.PropChanged("UserQQ", this._userQQ, value);

                this._userQQ = value;
            }
        }


        private string _userAddress;

        /// <summary>
        /// UserAddress
        /// </summary>
        public string UserAddress
        {
            get
            {
                return this._userAddress;
            }
            set
            {
                this.PropChanged("UserAddress", this._userAddress, value);

                this._userAddress = value;
            }
        }


        private string _userMobile;

        /// <summary>
        /// UserMobile
        /// </summary>
        public string UserMobile
        {
            get
            {
                return this._userMobile;
            }
            set
            {
                this.PropChanged("UserMobile", this._userMobile, value);

                this._userMobile = value;
            }
        }


        private string _userIDNumber;

        /// <summary>
        /// UserIDNumber
        /// </summary>
        public string UserIDNumber
        {
            get
            {
                return this._userIDNumber;
            }
            set
            {
                this.PropChanged("UserIDNumber", this._userIDNumber, value);

                this._userIDNumber = value;
            }
        }


        private DateTime? _userLastLoginDate;

        /// <summary>
        /// UserLastLoginDate
        /// </summary>
        public DateTime? UserLastLoginDate
        {
            get
            {
                return this._userLastLoginDate;
            }
            set
            {
                this.PropChanged("UserLastLoginDate", this._userLastLoginDate, value);

                this._userLastLoginDate = value;
            }
        }


        private int? _userLoginCount;

        /// <summary>
        /// UserLoginCount
        /// </summary>
        public int? UserLoginCount
        {
            get
            {
                return this._userLoginCount;
            }
            set
            {
                this.PropChanged("UserLoginCount", this._userLoginCount, value);

                this._userLoginCount = value;
            }
        }


        #endregion

        #region 重载

        public override object PkValue
        {
            get
            {
                return this.UserId;
            }
        }

        public override string PkName
        {
            get
            {
                return "UserId";
            }
        }

        public override bool IsIdentityPk
        {
            get
            {
                return false;
            }
        }



        private Dictionary<string, string> _props;

        public override Dictionary<string, string> Props
        {
            get
            {
                if (_props == null)
                {
                    _props = new Dictionary<string, string>();

                    _props.Add("UserId", "UserId");

                    _props.Add("UserAccount", "UserAccount");

                    _props.Add("UserName", "UserName");

                    _props.Add("UserPassword", "UserPassword");

                    _props.Add("UserStatus", "UserStatus");

                    _props.Add("CreateDate", "CreateDate");

                    _props.Add("CreateBy", "CreateBy");

                    _props.Add("ModifyBy", "ModifyBy");

                    _props.Add("ModifyDate", "ModifyDate");

                    _props.Add("UserPhone", "UserPhone");

                    _props.Add("UserEmail", "UserEmail");

                    _props.Add("UserFax", "UserFax");

                    _props.Add("UserQQ", "UserQQ");

                    _props.Add("UserAddress", "UserAddress");

                    _props.Add("UserMobile", "UserMobile");

                    _props.Add("UserIDNumber", "UserIDNumber");

                    _props.Add("UserLastLoginDate", "UserLastLoginDate");

                    _props.Add("UserLoginCount", "UserLoginCount");

                }
                return _props;
            }
        }

        public override CharmCommonUserInfo GetEntityFromDataRow(DataRow row)
        {

            if (row.Table.Columns.Contains("UserId") && row["UserId"] != null && row["UserId"].ToString() != "")
            {
                this._userId = new Guid(row["UserId"].ToString());
            }
            if (row.Table.Columns.Contains("UserAccount") && row["UserAccount"] != null)
            {
                this._userAccount = row["UserAccount"].ToString();
            }
            if (row.Table.Columns.Contains("UserName") && row["UserName"] != null)
            {
                this._userName = row["UserName"].ToString();
            }
            if (row.Table.Columns.Contains("UserPassword") && row["UserPassword"] != null)
            {
                this._userPassword = row["UserPassword"].ToString();
            }
            if (row.Table.Columns.Contains("UserStatus") && row["UserStatus"] != null && row["UserStatus"].ToString() != "")
            {
                this._userStatus = int.Parse(row["UserStatus"].ToString());
            }
            if (row.Table.Columns.Contains("CreateDate") && row["CreateDate"] != null && row["CreateDate"].ToString() != "")
            {
                this._createDate = DateTime.Parse(row["CreateDate"].ToString());
            }
            if (row.Table.Columns.Contains("CreateBy") && row["CreateBy"] != null)
            {
                this._createBy = row["CreateBy"].ToString();
            }
            if (row.Table.Columns.Contains("ModifyBy") && row["ModifyBy"] != null)
            {
                this._modifyBy = row["ModifyBy"].ToString();
            }
            if (row.Table.Columns.Contains("ModifyDate") && row["ModifyDate"] != null && row["ModifyDate"].ToString() != "")
            {
                this._modifyDate = DateTime.Parse(row["ModifyDate"].ToString());
            }
            if (row.Table.Columns.Contains("UserPhone") && row["UserPhone"] != null)
            {
                this._userPhone = row["UserPhone"].ToString();
            }
            if (row.Table.Columns.Contains("UserEmail") && row["UserEmail"] != null)
            {
                this._userEmail = row["UserEmail"].ToString();
            }
            if (row.Table.Columns.Contains("UserFax") && row["UserFax"] != null)
            {
                this._userFax = row["UserFax"].ToString();
            }
            if (row.Table.Columns.Contains("UserQQ") && row["UserQQ"] != null)
            {
                this._userQQ = row["UserQQ"].ToString();
            }
            if (row.Table.Columns.Contains("UserAddress") && row["UserAddress"] != null)
            {
                this._userAddress = row["UserAddress"].ToString();
            }
            if (row.Table.Columns.Contains("UserMobile") && row["UserMobile"] != null)
            {
                this._userMobile = row["UserMobile"].ToString();
            }
            if (row.Table.Columns.Contains("UserIDNumber") && row["UserIDNumber"] != null)
            {
                this._userIDNumber = row["UserIDNumber"].ToString();
            }
            if (row.Table.Columns.Contains("UserLastLoginDate") && row["UserLastLoginDate"] != null && row["UserLastLoginDate"].ToString() != "")
            {
                this._userLastLoginDate = DateTime.Parse(row["UserLastLoginDate"].ToString());
            }
            if (row.Table.Columns.Contains("UserLoginCount") && row["UserLoginCount"] != null && row["UserLoginCount"].ToString() != "")
            {
                this._userLoginCount = int.Parse(row["UserLoginCount"].ToString());
            }

            return this;
        }

        public override CharmCommonUserInfo GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);

                if (name.ToLower() == "userid" && !reader.IsDBNull(i))
                {




                    _userId = reader.GetGuid(i);







                    continue;
                }

                if (name.ToLower() == "useraccount" && !reader.IsDBNull(i))
                {





                    _userAccount = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "username" && !reader.IsDBNull(i))
                {





                    _userName = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "userpassword" && !reader.IsDBNull(i))
                {





                    _userPassword = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "userstatus" && !reader.IsDBNull(i))
                {









                    _userStatus = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "createdate" && !reader.IsDBNull(i))
                {



                    _createDate = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "createby" && !reader.IsDBNull(i))
                {





                    _createBy = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "modifyby" && !reader.IsDBNull(i))
                {





                    _modifyBy = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "modifydate" && !reader.IsDBNull(i))
                {



                    _modifyDate = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "userphone" && !reader.IsDBNull(i))
                {





                    _userPhone = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "useremail" && !reader.IsDBNull(i))
                {





                    _userEmail = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "userfax" && !reader.IsDBNull(i))
                {





                    _userFax = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "userqq" && !reader.IsDBNull(i))
                {





                    _userQQ = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "useraddress" && !reader.IsDBNull(i))
                {





                    _userAddress = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "usermobile" && !reader.IsDBNull(i))
                {





                    _userMobile = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "useridnumber" && !reader.IsDBNull(i))
                {





                    _userIDNumber = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "userlastlogindate" && !reader.IsDBNull(i))
                {



                    _userLastLoginDate = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "userlogincount" && !reader.IsDBNull(i))
                {









                    _userLoginCount = reader.GetInt32(i);


                    continue;
                }

            }
            return this;
        }

        public override string TableName
        {
            get
            {
                return "Charm_Common_UserInfo";
            }
        }

        public override IOctDbCommand GetInsertCmd()
        {

            var sql = @"
				INSERT INTO Charm_Common_UserInfo (
					UserId,
					UserAccount,
					UserName,
					UserPassword,
					UserStatus,
					CreateDate,
					CreateBy,
					ModifyBy,
					ModifyDate,
					UserPhone,
					UserEmail,
					UserFax,
					UserQQ,
					UserAddress,
					UserMobile,
					UserIDNumber,
					UserLastLoginDate,
					UserLoginCount)
				VALUES (
					@UserId,
					@UserAccount,
					@UserName,
					@UserPassword,
					@UserStatus,
					@CreateDate,
					@CreateBy,
					@ModifyBy,
					@ModifyDate,
					@UserPhone,
					@UserEmail,
					@UserFax,
					@UserQQ,
					@UserAddress,
					@UserMobile,
					@UserIDNumber,
					@UserLastLoginDate,
					@UserLoginCount)";

            DbCommand cmd = new SqlCommand();
            var parameters = new Dictionary<string, object> {
                {"@UserId", this.UserId},
                {"@UserAccount", this.UserAccount},
                {"@UserName", this.UserName},
                {"@UserPassword", this.UserPassword},
                {"@UserStatus", this.UserStatus},
                {"@CreateDate", this.CreateDate},
                {"@CreateBy", this.CreateBy},
                {"@ModifyBy", this.ModifyBy},
                {"@ModifyDate", this.ModifyDate},
                {"@UserPhone", this.UserPhone},
                {"@UserEmail", this.UserEmail},
                {"@UserFax", this.UserFax},
                {"@UserQQ", this.UserQQ},
                {"@UserAddress", this.UserAddress},
                {"@UserMobile", this.UserMobile},
                {"@UserIDNumber", this.UserIDNumber},
                {"@UserLastLoginDate", this.UserLastLoginDate},
                {"@UserLoginCount", this.UserLoginCount}};

            return new OctDbCommand(sql, parameters);
        }

        public override IOctDbCommand GetUpdateCmd(string @where = "", IDictionary<string, object> paras = null)
        {
            var sb = new StringBuilder();
            var parameters = new Dictionary<string, object>();

            sb.Append("update " + this.TableName + " set ");

            foreach (var changedProp in this.ChangedProps)
            {
                sb.Append(string.Format("{0} = @{0},", changedProp.Key));

                parameters.Add("@" + changedProp.Key, changedProp.Value);
            }

            var sql = sb.ToString().Remove(sb.Length - 1);
            sql += string.Format(" where {0} = '{1}'", this.PkName, this.PkValue);

            if (!string.IsNullOrEmpty(@where))
                sql += @where;

            if (paras != null)
            {
                foreach (var p in paras)
                {
                    parameters.Add(p.Key, p.Value);
                }
            }

            return new OctDbCommand(sql, parameters);
        }

        public override string GetDelSQL()
        {
            return string.Format("delete from {0} where {1} = '{2}'", this.TableName, this.PkName, this.PkValue);
        }

        public override string GetDelSQL(object v, string @where = "")
        {
            string sql = string.Format("delete from {0} where 1 = 1 ", this.TableName);

            if (v != null)
                sql += "and " + this.PkName + " = '" + v + "'";

            if (!string.IsNullOrEmpty(@where))
                sql += @where;

            return sql;
        }

        public override string GetModelSQL(object v)
        {
            return string.Format("select * from {0} where {1} = '{2}'", this.TableName, this.PkName, v);
        }

        public override string GetQuerySQL(string @where = "")
        {
            var sql = string.Format("select * from {0} where 1 = 1 ", this.TableName);

            if (!string.IsNullOrEmpty(@where))
                sql +=  @where;

            return sql;
        }

        #endregion
    }
}