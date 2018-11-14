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
    public partial class CharmCommonMenuInfo : BaseEntity<CharmCommonMenuInfo>
    {
        #region	属性


        private Guid _menuId;

        /// <summary>
        /// MenuId
        /// </summary>
        public Guid MenuId
        {
            get
            {
                return this._menuId;
            }
            set
            {
                this.PropChanged("MenuId", this._menuId, value);

                this._menuId = value;
            }
        }


        private string _menuName;

        /// <summary>
        /// MenuName
        /// </summary>
        public string MenuName
        {
            get
            {
                return this._menuName;
            }
            set
            {
                this.PropChanged("MenuName", this._menuName, value);

                this._menuName = value;
            }
        }


        private bool? _isAllowAnonymousAccess;

        /// <summary>
        /// IsAllowAnonymousAccess
        /// </summary>
        public bool? IsAllowAnonymousAccess
        {
            get
            {
                return this._isAllowAnonymousAccess;
            }
            set
            {
                this.PropChanged("IsAllowAnonymousAccess", this._isAllowAnonymousAccess, value);

                this._isAllowAnonymousAccess = value;
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


        private int? _sort;

        /// <summary>
        /// Sort
        /// </summary>
        public int? Sort
        {
            get
            {
                return this._sort;
            }
            set
            {
                this.PropChanged("Sort", this._sort, value);

                this._sort = value;
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
                return this.MenuId;
            }
        }

        public override string PkName
        {
            get
            {
                return "MenuId";
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

                    _props.Add("MenuId", "MenuId");

                    _props.Add("MenuName", "MenuName");

                    _props.Add("IsAllowAnonymousAccess", "IsAllowAnonymousAccess");

                    _props.Add("IsEnable", "IsEnable");

                    _props.Add("Sort", "Sort");

                    _props.Add("CreateDate", "CreateDate");

                    _props.Add("CreateBy", "CreateBy");

                    _props.Add("ModifyDate", "ModifyDate");

                    _props.Add("ModifyBy", "ModifyBy");

                }
                return _props;
            }
        }

        public override CharmCommonMenuInfo GetEntityFromDataRow(DataRow row)
        {

            if (row.Table.Columns.Contains("MenuId") && row["MenuId"] != null && row["MenuId"].ToString() != "")
            {
                this._menuId = new Guid(row["MenuId"].ToString());
            }
            if (row.Table.Columns.Contains("MenuName") && row["MenuName"] != null)
            {
                this._menuName = row["MenuName"].ToString();
            }
            if (row.Table.Columns.Contains("IsAllowAnonymousAccess") && row["IsAllowAnonymousAccess"] != null && row["IsAllowAnonymousAccess"].ToString() != "")
            {
                if ((row["IsAllowAnonymousAccess"].ToString() == "1") || (row["IsAllowAnonymousAccess"].ToString().ToLower() == "true"))
                {
                    this._isAllowAnonymousAccess = true;
                }
                else
                {
                    this._isAllowAnonymousAccess = false;
                }
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
            if (row.Table.Columns.Contains("Sort") && row["Sort"] != null && row["Sort"].ToString() != "")
            {
                this._sort = int.Parse(row["Sort"].ToString());
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

        public override CharmCommonMenuInfo GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);

                if (name.ToLower() == "menuid" && !reader.IsDBNull(i))
                {




                    _menuId = reader.GetGuid(i);







                    continue;
                }

                if (name.ToLower() == "menuname" && !reader.IsDBNull(i))
                {





                    _menuName = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "isallowanonymousaccess" && !reader.IsDBNull(i))
                {

                    _isAllowAnonymousAccess = reader.GetBoolean(i);










                    continue;
                }

                if (name.ToLower() == "isenable" && !reader.IsDBNull(i))
                {

                    _isEnable = reader.GetBoolean(i);










                    continue;
                }

                if (name.ToLower() == "sort" && !reader.IsDBNull(i))
                {









                    _sort = reader.GetInt32(i);


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
                return "Charm_Common_MenuInfo";
            }
        }

        public override IOctDbCommand GetInsertCmd()
        {

            var sql = @"
				INSERT INTO Charm_Common_MenuInfo (
					MenuId,
					MenuName,
					IsAllowAnonymousAccess,
					IsEnable,
					Sort,
					CreateDate,
					CreateBy,
					ModifyDate,
					ModifyBy)
				VALUES (
					@MenuId,
					@MenuName,
					@IsAllowAnonymousAccess,
					@IsEnable,
					@Sort,
					@CreateDate,
					@CreateBy,
					@ModifyDate,
					@ModifyBy)";

            DbCommand cmd = new SqlCommand();
            var parameters = new Dictionary<string, object> {
                {"@MenuId", this.MenuId},
                {"@MenuName", this.MenuName},
                {"@IsAllowAnonymousAccess", this.IsAllowAnonymousAccess},
                {"@IsEnable", this.IsEnable},
                {"@Sort", this.Sort},
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