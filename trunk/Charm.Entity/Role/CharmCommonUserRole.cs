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
	public partial class CharmCommonUserRole : BaseEntity<CharmCommonUserRole>
	{ 
		#region	属性
		

		private Guid _userRoleId;

		/// <summary>
		/// UserRoleId
		/// </summary>
		public Guid UserRoleId
		{
			get
			{
				return this._userRoleId;
			}
			set
			{
				this.PropChanged("UserRoleId", this._userRoleId, value);

				this._userRoleId = value;
			}
		}
		

		private Guid? _userId;

		/// <summary>
		/// UserId
		/// </summary>
		public Guid? UserId
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
		

		private Guid? _roleId;

		/// <summary>
		/// RoleId
		/// </summary>
		public Guid? RoleId
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
		

		private Guid? _createUserId;

		/// <summary>
		/// CreateUserId
		/// </summary>
		public Guid? CreateUserId
		{
			get
			{
				return this._createUserId;
			}
			set
			{
				this.PropChanged("CreateUserId", this._createUserId, value);

				this._createUserId = value;
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
		

		private Guid? _modifyUserId;

		/// <summary>
		/// ModifyUserId
		/// </summary>
		public Guid? ModifyUserId
		{
			get
			{
				return this._modifyUserId;
			}
			set
			{
				this.PropChanged("ModifyUserId", this._modifyUserId, value);

				this._modifyUserId = value;
			}
		}
		

		#endregion

		#region 重载

		public override object PkValue
		{
			get
			{
				return this.UserRoleId; 
			}
		}

		public override string PkName
		{
			get
			{
				return "UserRoleId"; 
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
					
					_props.Add( "UserRoleId","UserRoleId");
					
					_props.Add( "UserId","UserId");
					
					_props.Add( "RoleId","RoleId");
					
					_props.Add( "CreateDate","CreateDate");
					
					_props.Add( "CreateUserId","CreateUserId");
					
					_props.Add( "ModifyDate","ModifyDate");
					
					_props.Add( "ModifyUserId","ModifyUserId");
					
				}
				return _props;			 
			 }
	    }

		public override CharmCommonUserRole GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("UserRoleId") && row["UserRoleId"] != null && row["UserRoleId"].ToString() != "")
			{
				this._userRoleId = new Guid(row["UserRoleId"].ToString());
			}
			if (row.Table.Columns.Contains("UserId") && row["UserId"] != null && row["UserId"].ToString() != "")
			{
				this._userId = new Guid(row["UserId"].ToString());
			}
			if (row.Table.Columns.Contains("RoleId") && row["RoleId"] != null && row["RoleId"].ToString() != "")
			{
				this._roleId = new Guid(row["RoleId"].ToString());
			}
			if (row.Table.Columns.Contains("CreateDate") && row["CreateDate"] != null && row["CreateDate"].ToString() != "")
			{
				this._createDate = DateTime.Parse(row["CreateDate"].ToString());
			}
			if (row.Table.Columns.Contains("CreateUserId") && row["CreateUserId"] != null && row["CreateUserId"].ToString() != "")
			{
				this._createUserId = new Guid(row["CreateUserId"].ToString());
			}
			if (row.Table.Columns.Contains("ModifyDate") && row["ModifyDate"] != null && row["ModifyDate"].ToString() != "")
			{
				this._modifyDate = DateTime.Parse(row["ModifyDate"].ToString());
			}
			if (row.Table.Columns.Contains("ModifyUserId") && row["ModifyUserId"] != null && row["ModifyUserId"].ToString() != "")
			{
				this._modifyUserId = new Guid(row["ModifyUserId"].ToString());
			}

			return this;
		}

		public override CharmCommonUserRole GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "userroleid" && !reader.IsDBNull(i))
{




_userRoleId = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "userid" && !reader.IsDBNull(i))
{




_userId = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "roleid" && !reader.IsDBNull(i))
{




_roleId = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "createdate" && !reader.IsDBNull(i))
{



_createDate = reader.GetDateTime(i);








 continue;
}

if (name.ToLower() == "createuserid" && !reader.IsDBNull(i))
{




_createUserId = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "modifydate" && !reader.IsDBNull(i))
{



_modifyDate = reader.GetDateTime(i);








 continue;
}

if (name.ToLower() == "modifyuserid" && !reader.IsDBNull(i))
{




_modifyUserId = reader.GetGuid(i);







 continue;
}
               
}
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Common_UserRole";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Common_UserRole (
					UserRoleId,
					UserId,
					RoleId,
					CreateDate,
					CreateUserId,
					ModifyDate,
					ModifyUserId)
				VALUES (
					@UserRoleId,
					@UserId,
					@RoleId,
					@CreateDate,
					@CreateUserId,
					@ModifyDate,
					@ModifyUserId)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@UserRoleId", this.UserRoleId},
				{"@UserId", this.UserId},
				{"@RoleId", this.RoleId},
				{"@CreateDate", this.CreateDate},
				{"@CreateUserId", this.CreateUserId},
				{"@ModifyDate", this.ModifyDate},
				{"@ModifyUserId", this.ModifyUserId}};

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
				sql += @where;

			return sql;
		}

		#endregion
	}
}