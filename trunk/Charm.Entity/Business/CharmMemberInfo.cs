using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Oct.Framework.DB.Base;
using Oct.Framework.DB.Core;
using Oct.Framework.DB.Interface;

namespace Charm.Entity.Business
{
    [Serializable]
    public partial class CharmMemberInfo : BaseEntity<CharmMemberInfo>
    {
        #region	属性


        private Guid _member_Id;

        /// <summary>
        /// Member_Id
        /// </summary>
        public Guid Member_Id
        {
            get
            {
                return this._member_Id;
            }
            set
            {
                this.PropChanged("Member_Id", this._member_Id, value);

                this._member_Id = value;
            }
        }


        private string _user_Name;

        /// <summary>
        /// User_Name
        /// </summary>
        public string User_Name
        {
            get
            {
                return this._user_Name;
            }
            set
            {
                this.PropChanged("User_Name", this._user_Name, value);

                this._user_Name = value;
            }
        }


        private string _wechat_Id;

        /// <summary>
        /// 微信的OpenId
        /// </summary>
        public string Wechat_Id
        {
            get
            {
                return this._wechat_Id;
            }
            set
            {
                this.PropChanged("Wechat_Id", this._wechat_Id, value);

                this._wechat_Id = value;
            }
        }


        private string _user_Avatar;

        /// <summary>
        /// 用户头像
        /// </summary>
        public string User_Avatar
        {
            get
            {
                return this._user_Avatar;
            }
            set
            {
                this.PropChanged("User_Avatar", this._user_Avatar, value);

                this._user_Avatar = value;
            }
        }


        private string _user_Phone;

        /// <summary>
        /// User_Phone
        /// </summary>
        public string User_Phone
        {
            get
            {
                return this._user_Phone;
            }
            set
            {
                this.PropChanged("User_Phone", this._user_Phone, value);

                this._user_Phone = value;
            }
        }


        private int? _user_Source;

        /// <summary>
        /// 0:普通，1:微信。
        /// </summary>
        public int? User_Source
        {
            get
            {
                return this._user_Source;
            }
            set
            {
                this.PropChanged("User_Source", this._user_Source, value);

                this._user_Source = value;
            }
        }


        private int? _login_Count;

        /// <summary>
        /// Login_Count
        /// </summary>
        public int? Login_Count
        {
            get
            {
                return this._login_Count;
            }
            set
            {
                this.PropChanged("Login_Count", this._login_Count, value);

                this._login_Count = value;
            }
        }


        private string _create_By;

        /// <summary>
        /// Create_By
        /// </summary>
        public string Create_By
        {
            get
            {
                return this._create_By;
            }
            set
            {
                this.PropChanged("Create_By", this._create_By, value);

                this._create_By = value;
            }
        }


        private DateTime? _create_Time;

        /// <summary>
        /// Create_Time
        /// </summary>
        public DateTime? Create_Time
        {
            get
            {
                return this._create_Time;
            }
            set
            {
                this.PropChanged("Create_Time", this._create_Time, value);

                this._create_Time = value;
            }
        }


        private string _modify_By;

        /// <summary>
        /// Modify_By
        /// </summary>
        public string Modify_By
        {
            get
            {
                return this._modify_By;
            }
            set
            {
                this.PropChanged("Modify_By", this._modify_By, value);

                this._modify_By = value;
            }
        }


        private DateTime? _modify_Time;

        /// <summary>
        /// Modify_Time
        /// </summary>
        public DateTime? Modify_Time
        {
            get
            {
                return this._modify_Time;
            }
            set
            {
                this.PropChanged("Modify_Time", this._modify_Time, value);

                this._modify_Time = value;
            }
        }


        private string _wc_AccessToken;

        /// <summary>
        /// 网页授权接口调用凭证
        /// </summary>
        public string Wc_AccessToken
        {
            get
            {
                return this._wc_AccessToken;
            }
            set
            {
                this.PropChanged("Wc_AccessToken", this._wc_AccessToken, value);

                this._wc_AccessToken = value;
            }
        }


        private string _wc_RefreshToken;

        /// <summary>
        /// 用户刷新access_token
        /// </summary>
        public string Wc_RefreshToken
        {
            get
            {
                return this._wc_RefreshToken;
            }
            set
            {
                this.PropChanged("Wc_RefreshToken", this._wc_RefreshToken, value);

                this._wc_RefreshToken = value;
            }
        }


        private DateTime? _wc_AccessToken_ExpireDate;

        /// <summary>
        /// Wc_AccessToken_ExpireDate
        /// </summary>
        public DateTime? Wc_AccessToken_ExpireDate
        {
            get
            {
                return this._wc_AccessToken_ExpireDate;
            }
            set
            {
                this.PropChanged("Wc_AccessToken_ExpireDate", this._wc_AccessToken_ExpireDate, value);

                this._wc_AccessToken_ExpireDate = value;
            }
        }


        private DateTime? _wc_RefreshToken_ExpireDate;

        /// <summary>
        /// Wc_RefreshToken_ExpireDate
        /// </summary>
        public DateTime? Wc_RefreshToken_ExpireDate
        {
            get
            {
                return this._wc_RefreshToken_ExpireDate;
            }
            set
            {
                this.PropChanged("Wc_RefreshToken_ExpireDate", this._wc_RefreshToken_ExpireDate, value);

                this._wc_RefreshToken_ExpireDate = value;
            }
        }


        private int? _wc_Sex;

        /// <summary>
        /// 用户的性别，值为1时是男性，值为2时是女性，值为0时是未知
        /// </summary>
        public int? Wc_Sex
        {
            get
            {
                return this._wc_Sex;
            }
            set
            {
                this.PropChanged("Wc_Sex", this._wc_Sex, value);

                this._wc_Sex = value;
            }
        }


        private string _wc_Province;

        /// <summary>
        /// Wc_Province
        /// </summary>
        public string Wc_Province
        {
            get
            {
                return this._wc_Province;
            }
            set
            {
                this.PropChanged("Wc_Province", this._wc_Province, value);

                this._wc_Province = value;
            }
        }


        private string _wc_City;

        /// <summary>
        /// Wc_City
        /// </summary>
        public string Wc_City
        {
            get
            {
                return this._wc_City;
            }
            set
            {
                this.PropChanged("Wc_City", this._wc_City, value);

                this._wc_City = value;
            }
        }


        private string _wc_Country;

        /// <summary>
        /// Wc_Country
        /// </summary>
        public string Wc_Country
        {
            get
            {
                return this._wc_Country;
            }
            set
            {
                this.PropChanged("Wc_Country", this._wc_Country, value);

                this._wc_Country = value;
            }
        }


        private string _wc_Privilege;

        /// <summary>
        /// 用户特权信息，json 数组，如微信沃卡用户为（chinaunicom）
        /// </summary>
        public string Wc_Privilege
        {
            get
            {
                return this._wc_Privilege;
            }
            set
            {
                this.PropChanged("Wc_Privilege", this._wc_Privilege, value);

                this._wc_Privilege = value;
            }
        }


        private string _wc_UnionId;

        /// <summary>
        /// 只有在用户将公众号绑定到微信开放平台帐号后，才会出现该字段
        /// </summary>
        public string Wc_UnionId
        {
            get
            {
                return this._wc_UnionId;
            }
            set
            {
                this.PropChanged("Wc_UnionId", this._wc_UnionId, value);

                this._wc_UnionId = value;
            }
        }


        #endregion

        #region 重载

        public override object PkValue
        {
            get
            {
                return this.Member_Id;
            }
        }

        public override string PkName
        {
            get
            {
                return "Member_Id";
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

                    _props.Add("Member_Id", "Member_Id");

                    _props.Add("User_Name", "User_Name");

                    _props.Add("Wechat_Id", "Wechat_Id");

                    _props.Add("User_Avatar", "User_Avatar");

                    _props.Add("User_Phone", "User_Phone");

                    _props.Add("User_Source", "User_Source");

                    _props.Add("Login_Count", "Login_Count");

                    _props.Add("Create_By", "Create_By");

                    _props.Add("Create_Time", "Create_Time");

                    _props.Add("Modify_By", "Modify_By");

                    _props.Add("Modify_Time", "Modify_Time");

                    _props.Add("Wc_AccessToken", "Wc_AccessToken");

                    _props.Add("Wc_RefreshToken", "Wc_RefreshToken");

                    _props.Add("Wc_AccessToken_ExpireDate", "Wc_AccessToken_ExpireDate");

                    _props.Add("Wc_RefreshToken_ExpireDate", "Wc_RefreshToken_ExpireDate");

                    _props.Add("Wc_Sex", "Wc_Sex");

                    _props.Add("Wc_Province", "Wc_Province");

                    _props.Add("Wc_City", "Wc_City");

                    _props.Add("Wc_Country", "Wc_Country");

                    _props.Add("Wc_Privilege", "Wc_Privilege");

                    _props.Add("Wc_UnionId", "Wc_UnionId");

                }
                return _props;
            }
        }

        public override CharmMemberInfo GetEntityFromDataRow(DataRow row)
        {

            if (row.Table.Columns.Contains("Member_Id") && row["Member_Id"] != null && row["Member_Id"].ToString() != "")
            {
                this._member_Id = new Guid(row["Member_Id"].ToString());
            }
            if (row.Table.Columns.Contains("User_Name") && row["User_Name"] != null)
            {
                this._user_Name = row["User_Name"].ToString();
            }
            if (row.Table.Columns.Contains("Wechat_Id") && row["Wechat_Id"] != null)
            {
                this._wechat_Id = row["Wechat_Id"].ToString();
            }
            if (row.Table.Columns.Contains("User_Avatar") && row["User_Avatar"] != null)
            {
                this._user_Avatar = row["User_Avatar"].ToString();
            }
            if (row.Table.Columns.Contains("User_Phone") && row["User_Phone"] != null)
            {
                this._user_Phone = row["User_Phone"].ToString();
            }
            if (row.Table.Columns.Contains("User_Source") && row["User_Source"] != null && row["User_Source"].ToString() != "")
            {
                this._user_Source = int.Parse(row["User_Source"].ToString());
            }
            if (row.Table.Columns.Contains("Login_Count") && row["Login_Count"] != null && row["Login_Count"].ToString() != "")
            {
                this._login_Count = int.Parse(row["Login_Count"].ToString());
            }
            if (row.Table.Columns.Contains("Create_By") && row["Create_By"] != null)
            {
                this._create_By = row["Create_By"].ToString();
            }
            if (row.Table.Columns.Contains("Create_Time") && row["Create_Time"] != null && row["Create_Time"].ToString() != "")
            {
                this._create_Time = DateTime.Parse(row["Create_Time"].ToString());
            }
            if (row.Table.Columns.Contains("Modify_By") && row["Modify_By"] != null)
            {
                this._modify_By = row["Modify_By"].ToString();
            }
            if (row.Table.Columns.Contains("Modify_Time") && row["Modify_Time"] != null && row["Modify_Time"].ToString() != "")
            {
                this._modify_Time = DateTime.Parse(row["Modify_Time"].ToString());
            }
            if (row.Table.Columns.Contains("Wc_AccessToken") && row["Wc_AccessToken"] != null)
            {
                this._wc_AccessToken = row["Wc_AccessToken"].ToString();
            }
            if (row.Table.Columns.Contains("Wc_RefreshToken") && row["Wc_RefreshToken"] != null)
            {
                this._wc_RefreshToken = row["Wc_RefreshToken"].ToString();
            }
            if (row.Table.Columns.Contains("Wc_AccessToken_ExpireDate") && row["Wc_AccessToken_ExpireDate"] != null && row["Wc_AccessToken_ExpireDate"].ToString() != "")
            {
                this._wc_AccessToken_ExpireDate = DateTime.Parse(row["Wc_AccessToken_ExpireDate"].ToString());
            }
            if (row.Table.Columns.Contains("Wc_RefreshToken_ExpireDate") && row["Wc_RefreshToken_ExpireDate"] != null && row["Wc_RefreshToken_ExpireDate"].ToString() != "")
            {
                this._wc_RefreshToken_ExpireDate = DateTime.Parse(row["Wc_RefreshToken_ExpireDate"].ToString());
            }
            if (row.Table.Columns.Contains("Wc_Sex") && row["Wc_Sex"] != null && row["Wc_Sex"].ToString() != "")
            {
                this._wc_Sex = int.Parse(row["Wc_Sex"].ToString());
            }
            if (row.Table.Columns.Contains("Wc_Province") && row["Wc_Province"] != null)
            {
                this._wc_Province = row["Wc_Province"].ToString();
            }
            if (row.Table.Columns.Contains("Wc_City") && row["Wc_City"] != null)
            {
                this._wc_City = row["Wc_City"].ToString();
            }
            if (row.Table.Columns.Contains("Wc_Country") && row["Wc_Country"] != null)
            {
                this._wc_Country = row["Wc_Country"].ToString();
            }
            if (row.Table.Columns.Contains("Wc_Privilege") && row["Wc_Privilege"] != null)
            {
                this._wc_Privilege = row["Wc_Privilege"].ToString();
            }
            if (row.Table.Columns.Contains("Wc_UnionId") && row["Wc_UnionId"] != null)
            {
                this._wc_UnionId = row["Wc_UnionId"].ToString();
            }

            return this;
        }

        public override CharmMemberInfo GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);

                if (name.ToLower() == "member_id" && !reader.IsDBNull(i))
                {




                    _member_Id = reader.GetGuid(i);







                    continue;
                }

                if (name.ToLower() == "user_name" && !reader.IsDBNull(i))
                {





                    _user_Name = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "wechat_id" && !reader.IsDBNull(i))
                {





                    _wechat_Id = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "user_avatar" && !reader.IsDBNull(i))
                {





                    _user_Avatar = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "user_phone" && !reader.IsDBNull(i))
                {





                    _user_Phone = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "user_source" && !reader.IsDBNull(i))
                {









                    _user_Source = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "login_count" && !reader.IsDBNull(i))
                {









                    _login_Count = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "create_by" && !reader.IsDBNull(i))
                {





                    _create_By = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "create_time" && !reader.IsDBNull(i))
                {



                    _create_Time = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "modify_by" && !reader.IsDBNull(i))
                {





                    _modify_By = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "modify_time" && !reader.IsDBNull(i))
                {



                    _modify_Time = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "wc_accesstoken" && !reader.IsDBNull(i))
                {





                    _wc_AccessToken = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "wc_refreshtoken" && !reader.IsDBNull(i))
                {





                    _wc_RefreshToken = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "wc_accesstoken_expiredate" && !reader.IsDBNull(i))
                {



                    _wc_AccessToken_ExpireDate = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "wc_refreshtoken_expiredate" && !reader.IsDBNull(i))
                {



                    _wc_RefreshToken_ExpireDate = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "wc_sex" && !reader.IsDBNull(i))
                {









                    _wc_Sex = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "wc_province" && !reader.IsDBNull(i))
                {





                    _wc_Province = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "wc_city" && !reader.IsDBNull(i))
                {





                    _wc_City = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "wc_country" && !reader.IsDBNull(i))
                {





                    _wc_Country = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "wc_privilege" && !reader.IsDBNull(i))
                {





                    _wc_Privilege = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "wc_unionid" && !reader.IsDBNull(i))
                {





                    _wc_UnionId = reader.GetString(i);






                    continue;
                }

            }
            return this;
        }

        public override string TableName
        {
            get
            {
                return "Charm_Member_Info";
            }
        }

        public override IOctDbCommand GetInsertCmd()
        {

            var sql = @"
				INSERT INTO Charm_Member_Info (
					Member_Id,
					User_Name,
					Wechat_Id,
					User_Avatar,
					User_Phone,
					User_Source,
					Login_Count,
					Create_By,
					Create_Time,
					Modify_By,
					Modify_Time,
					Wc_AccessToken,
					Wc_RefreshToken,
					Wc_AccessToken_ExpireDate,
					Wc_RefreshToken_ExpireDate,
					Wc_Sex,
					Wc_Province,
					Wc_City,
					Wc_Country,
					Wc_Privilege,
					Wc_UnionId)
				VALUES (
					@Member_Id,
					@User_Name,
					@Wechat_Id,
					@User_Avatar,
					@User_Phone,
					@User_Source,
					@Login_Count,
					@Create_By,
					@Create_Time,
					@Modify_By,
					@Modify_Time,
					@Wc_AccessToken,
					@Wc_RefreshToken,
					@Wc_AccessToken_ExpireDate,
					@Wc_RefreshToken_ExpireDate,
					@Wc_Sex,
					@Wc_Province,
					@Wc_City,
					@Wc_Country,
					@Wc_Privilege,
					@Wc_UnionId)";

            DbCommand cmd = new SqlCommand();
            var parameters = new Dictionary<string, object> {
                {"@Member_Id", this.Member_Id},
                {"@User_Name", this.User_Name},
                {"@Wechat_Id", this.Wechat_Id},
                {"@User_Avatar", this.User_Avatar},
                {"@User_Phone", this.User_Phone},
                {"@User_Source", this.User_Source},
                {"@Login_Count", this.Login_Count},
                {"@Create_By", this.Create_By},
                {"@Create_Time", this.Create_Time},
                {"@Modify_By", this.Modify_By},
                {"@Modify_Time", this.Modify_Time},
                {"@Wc_AccessToken", this.Wc_AccessToken},
                {"@Wc_RefreshToken", this.Wc_RefreshToken},
                {"@Wc_AccessToken_ExpireDate", this.Wc_AccessToken_ExpireDate},
                {"@Wc_RefreshToken_ExpireDate", this.Wc_RefreshToken_ExpireDate},
                {"@Wc_Sex", this.Wc_Sex},
                {"@Wc_Province", this.Wc_Province},
                {"@Wc_City", this.Wc_City},
                {"@Wc_Country", this.Wc_Country},
                {"@Wc_Privilege", this.Wc_Privilege},
                {"@Wc_UnionId", this.Wc_UnionId}};

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
                sql +=  @where;

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
                sql +=  @where;

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