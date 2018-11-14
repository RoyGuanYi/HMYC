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
    public partial class CharmCommonRoleInfo : BaseEntity<CharmCommonRoleInfo>
    {
        #region	属性


        private Guid _roleId;

        /// <summary>
        /// RoleId
        /// </summary>
        public Guid RoleId
        {
            get
            {
                return this._roleId;
            }
            set
            {
                this.PropChanged("RoleId", this._roleId, value);

                this._roleId = value;
            }
        }


        private string _roleName;

        /// <summary>
        /// RoleName
        /// </summary>
        public string RoleName
        {
            get
            {
                return this._roleName;
            }
            set
            {
                this.PropChanged("RoleName", this._roleName, value);

                this._roleName = value;
            }
        }


        private string _roleCode;

        /// <summary>
        /// RoleCode
        /// </summary>
        public string RoleCode
        {
            get
            {
                return this._roleCode;
            }
            set
            {
                this.PropChanged("RoleCode", this._roleCode, value);

                this._roleCode = value;
            }
        }


        private bool? _isEnable;

        /// <summary>
        /// IsEnable
        /// </summary>
        public bool? IsEnable
        {
            get
            {
                return this._isEnable;
            }
            set
            {
                this.PropChanged("IsEnable", this._isEnable, value);

                this._isEnable = value;
            }
        }


        private bool? _isSysDefault;

        /// <summary>
        /// IsSysDefault
        /// </summary>
        public bool? IsSysDefault
        {
            get
            {
                return this._isSysDefault;
            }
            set
            {
                this.PropChanged("IsSysDefault", this._isSysDefault, value);

                this._isSysDefault = value;
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


        #endregion

        #region 重载

        public override object PkValue
        {
            get
            {
                return this.RoleId;
            }
        }

        public override string PkName
        {
            get
            {
                return "RoleId";
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

                    _props.Add("RoleId", "RoleId");

                    _props.Add("RoleName", "RoleName");

                    _props.Add("RoleCode", "RoleCode");

                    _props.Add("IsEnable", "IsEnable");

                    _props.Add("IsSysDefault", "IsSysDefault");

                    _props.Add("CreateDate", "CreateDate");

                    _props.Add("CreateBy", "CreateBy");

                    _props.Add("ModifyDate", "ModifyDate");

                    _props.Add("ModifyBy", "ModifyBy");

                }
                return _props;
            }
        }

        public override CharmCommonRoleInfo GetEntityFromDataRow(DataRow row)
        {

            if (row.Table.Columns.Contains("RoleId") && row["RoleId"] != null && row["RoleId"].ToString() != "")
            {
                this._roleId = new Guid(row["RoleId"].ToString());
            }
            if (row.Table.Columns.Contains("RoleName") && row["RoleName"] != null)
            {
                this._roleName = row["RoleName"].ToString();
            }
            if (row.Table.Columns.Contains("RoleCode") && row["RoleCode"] != null)
            {
                this._roleCode = row["RoleCode"].ToString();
            }
            if (row.Table.Columns.Contains("IsEnable") && row["IsEnable"] != null && row["IsEnable"].ToString() != "")
            {
                if ((row["IsEnable"].ToString() == "1") || (row["IsEnable"].ToString().ToLower() == "true"))
                {
                    this._isEnable = true;
                }
                else
                {
                    this._isEnable = false;
                }
            }
            if (row.Table.Columns.Contains("IsSysDefault") && row["IsSysDefault"] != null && row["IsSysDefault"].ToString() != "")
            {
                if ((row["IsSysDefault"].ToString() == "1") || (row["IsSysDefault"].ToString().ToLower() == "true"))
                {
                    this._isSysDefault = true;
                }
                else
                {
                    this._isSysDefault = false;
                }
            }
            if (row.Table.Columns.Contains("CreateDate") && row["CreateDate"] != null && row["CreateDate"].ToString() != "")
            {
                this._createDate = DateTime.Parse(row["CreateDate"].ToString());
            }
            if (row.Table.Columns.Contains("CreateBy") && row["CreateBy"] != null)
            {
                this._createBy = row["CreateBy"].ToString();
            }
            if (row.Table.Columns.Contains("ModifyDate") && row["ModifyDate"] != null && row["ModifyDate"].ToString() != "")
            {
                this._modifyDate = DateTime.Parse(row["ModifyDate"].ToString());
            }
            if (row.Table.Columns.Contains("ModifyBy") && row["ModifyBy"] != null)
            {
                this._modifyBy = row["ModifyBy"].ToString();
            }

            return this;
        }

        public override CharmCommonRoleInfo GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);

                if (name.ToLower() == "roleid" && !reader.IsDBNull(i))
                {




                    _roleId = reader.GetGuid(i);







                    continue;
                }

                if (name.ToLower() == "rolename" && !reader.IsDBNull(i))
                {





                    _roleName = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "rolecode" && !reader.IsDBNull(i))
                {





                    _roleCode = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "isenable" && !reader.IsDBNull(i))
                {

                    _isEnable = reader.GetBoolean(i);










                    continue;
                }

                if (name.ToLower() == "issysdefault" && !reader.IsDBNull(i))
                {

                    _isSysDefault = reader.GetBoolean(i);










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

                if (name.ToLower() == "modifydate" && !reader.IsDBNull(i))
                {



                    _modifyDate = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "modifyby" && !reader.IsDBNull(i))
                {





                    _modifyBy = reader.GetString(i);






                    continue;
                }

            }
            return this;
        }

        public override string TableName
        {
            get
            {
                return "Charm_Common_RoleInfo";
            }
        }

        public override IOctDbCommand GetInsertCmd()
        {

            var sql = @"
				INSERT INTO Charm_Common_RoleInfo (
					RoleId,
					RoleName,
					RoleCode,
					IsEnable,
					IsSysDefault,
					CreateDate,
					CreateBy,
					ModifyDate,
					ModifyBy)
				VALUES (
					@RoleId,
					@RoleName,
					@RoleCode,
					@IsEnable,
					@IsSysDefault,
					@CreateDate,
					@CreateBy,
					@ModifyDate,
					@ModifyBy)";

            DbCommand cmd = new SqlCommand();
            var parameters = new Dictionary<string, object> {
                {"@RoleId", this.RoleId},
                {"@RoleName", this.RoleName},
                {"@RoleCode", this.RoleCode},
                {"@IsEnable", this.IsEnable},
                {"@IsSysDefault", this.IsSysDefault},
                {"@CreateDate", this.CreateDate},
                {"@CreateBy", this.CreateBy},
                {"@ModifyDate", this.ModifyDate},
                {"@ModifyBy", this.ModifyBy}};

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
                sql += @where;

            return sql;
        }

        #endregion
    }
}