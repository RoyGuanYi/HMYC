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
	public partial class CharmCommonActionInfo : BaseEntity<CharmCommonActionInfo>
	{ 
		#region	属性
		

		private Guid _actionId;

		/// <summary>
		/// ActionId
		/// </summary>
		public Guid ActionId
		{
			get
			{
				return this._actionId;
			}
			set
			{
				this.PropChanged("ActionId", this._actionId, value);

				this._actionId = value;
			}
		}
		

		private string _actionCategoryName;

		/// <summary>
		/// ActionCategoryName
		/// </summary>
		public string ActionCategoryName
		{
			get
			{
				return this._actionCategoryName;
			}
			set
			{
				this.PropChanged("ActionCategoryName", this._actionCategoryName, value);

				this._actionCategoryName = value;
			}
		}
		

		private string _actionName;

		/// <summary>
		/// ActionName
		/// </summary>
		public string ActionName
		{
			get
			{
				return this._actionName;
			}
			set
			{
				this.PropChanged("ActionName", this._actionName, value);

				this._actionName = value;
			}
		}
		

		private string _actionUrl;

		/// <summary>
		/// ActionUrl
		/// </summary>
		public string ActionUrl
		{
			get
			{
				return this._actionUrl;
			}
			set
			{
				this.PropChanged("ActionUrl", this._actionUrl, value);

				this._actionUrl = value;
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
		

		private bool? _isVisible;

		/// <summary>
		/// IsVisible
		/// </summary>
		public bool? IsVisible
		{
			get
			{
				return this._isVisible;
			}
			set
			{
				this.PropChanged("IsVisible", this._isVisible, value);

				this._isVisible = value;
			}
		}
		

		private bool? _isLog;

		/// <summary>
		/// IsLog
		/// </summary>
		public bool? IsLog
		{
			get
			{
				return this._isLog;
			}
			set
			{
				this.PropChanged("IsLog", this._isLog, value);

				this._isLog = value;
			}
		}
		

		private int? _operation;

		/// <summary>
		/// Operation
		/// </summary>
		public int? Operation
		{
			get
			{
				return this._operation;
			}
			set
			{
				this.PropChanged("Operation", this._operation, value);

				this._operation = value;
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
		

		private Guid? _menuId;

		/// <summary>
		/// MenuId
		/// </summary>
		public Guid? MenuId
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
		/// CreateUserId
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

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName
	    {
	        get;
	        set;
	    }

        #endregion

        #region 重载

        public override object PkValue
		{
			get
			{
				return this.ActionId; 
			}
		}

		public override string PkName
		{
			get
			{
				return "ActionId"; 
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
	        get {
				if(_props == null)
				{
					_props = new Dictionary<string, string>();
					
					_props.Add( "ActionId","ActionId");
					
					_props.Add( "ActionCategoryName","ActionCategoryName");
					
					_props.Add( "ActionName","ActionName");
					
					_props.Add( "ActionUrl","ActionUrl");
					
					_props.Add( "IsEnable","IsEnable");
					
					_props.Add( "IsVisible","IsVisible");
					
					_props.Add( "IsLog","IsLog");
					
					_props.Add( "Operation","Operation");
					
					_props.Add( "Sort","Sort");
					
					_props.Add( "MenuId","MenuId");

				    _props.Add("CreateDate", "CreateDate");

				    _props.Add("CreateBy", "CreateBy");

				    _props.Add("ModifyDate", "ModifyDate");

				    _props.Add("ModifyBy", "ModifyBy");

                    _props.Add("MenuName", "MenuName");

                }
                return _props;			 
			 }
	    }

		public override CharmCommonActionInfo GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("ActionId") && row["ActionId"] != null && row["ActionId"].ToString() != "")
			{
				this._actionId = new Guid(row["ActionId"].ToString());
			}
			if (row.Table.Columns.Contains("ActionCategoryName") && row["ActionCategoryName"] != null)
			{
				this._actionCategoryName = row["ActionCategoryName"].ToString();
			}
			if (row.Table.Columns.Contains("ActionName") && row["ActionName"] != null)
			{
				this._actionName = row["ActionName"].ToString();
			}
			if (row.Table.Columns.Contains("ActionUrl") && row["ActionUrl"] != null)
			{
				this._actionUrl = row["ActionUrl"].ToString();
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
			if (row.Table.Columns.Contains("IsVisible") && row["IsVisible"] != null && row["IsVisible"].ToString() != "")
			{
				if ((row["IsVisible"].ToString() == "1") || (row["IsVisible"].ToString().ToLower() == "true"))
				{
					this._isVisible = true;
				}
				else
				{
					this._isVisible = false;
				}
			}
			if (row.Table.Columns.Contains("IsLog") && row["IsLog"] != null && row["IsLog"].ToString() != "")
			{
				if ((row["IsLog"].ToString() == "1") || (row["IsLog"].ToString().ToLower() == "true"))
				{
					this._isLog = true;
				}
				else
				{
					this._isLog = false;
				}
			}
			if (row.Table.Columns.Contains("Operation") && row["Operation"] != null && row["Operation"].ToString() != "")
			{
				this._operation = int.Parse(row["Operation"].ToString());
			}
			if (row.Table.Columns.Contains("Sort") && row["Sort"] != null && row["Sort"].ToString() != "")
			{
				this._sort = int.Parse(row["Sort"].ToString());
			}
			if (row.Table.Columns.Contains("MenuId") && row["MenuId"] != null && row["MenuId"].ToString() != "")
			{
				this._menuId = new Guid(row["MenuId"].ToString());
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
            if (row.Table.Columns.Contains("MenuName") && row["MenuName"] != null)
		    {
		        this.MenuName = row["MenuName"].ToString();
		    }
            return this;
		}

		public override CharmCommonActionInfo GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "actionid" && !reader.IsDBNull(i))
{




_actionId = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "actioncategoryname" && !reader.IsDBNull(i))
{





_actionCategoryName = reader.GetString(i);






 continue;
}

if (name.ToLower() == "actionname" && !reader.IsDBNull(i))
{





_actionName = reader.GetString(i);






 continue;
}

if (name.ToLower() == "actionurl" && !reader.IsDBNull(i))
{





_actionUrl = reader.GetString(i);






 continue;
}

if (name.ToLower() == "isenable" && !reader.IsDBNull(i))
{

_isEnable = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "isvisible" && !reader.IsDBNull(i))
{

_isVisible = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "islog" && !reader.IsDBNull(i))
{

_isLog = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "operation" && !reader.IsDBNull(i))
{









_operation = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "sort" && !reader.IsDBNull(i))
{









_sort = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "menuid" && !reader.IsDBNull(i))
{




_menuId = reader.GetGuid(i);







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
                if (name.ToLower() == "menuname" && !reader.IsDBNull(i))
                {
                    MenuName = reader.GetString(i);
                    continue;
                }

            }
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Common_ActionInfo";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Common_ActionInfo (
					ActionId,
					ActionCategoryName,
					ActionName,
					ActionUrl,
					IsEnable,
					IsVisible,
					IsLog,
					Operation,
					Sort,
					MenuId,
					CreateDate,
					CreateBy,
					ModifyDate,
					ModifyBy)
				VALUES (
					@ActionId,
					@ActionCategoryName,
					@ActionName,
					@ActionUrl,
					@IsEnable,
					@IsVisible,
					@IsLog,
					@Operation,
					@Sort,
					@MenuId,
					@CreateDate,
					@CreateBy,
					@ModifyDate,
					@ModifyBy)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@ActionId", this.ActionId},
				{"@ActionCategoryName", this.ActionCategoryName},
				{"@ActionName", this.ActionName},
				{"@ActionUrl", this.ActionUrl},
				{"@IsEnable", this.IsEnable},
				{"@IsVisible", this.IsVisible},
				{"@IsLog", this.IsLog},
				{"@Operation", this.Operation},
				{"@Sort", this.Sort},
				{"@MenuId", this.MenuId},
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
			var sql = string.Format("select a.*,b.MenuName from Charm_Common_ActionInfo a left join Charm_Common_MenuInfo b on a.MenuId = b.MenuId where 1 = 1 ");
           
			if (!string.IsNullOrEmpty(@where))
				sql +=  @where;

			return sql;
		}

		#endregion
	}
}