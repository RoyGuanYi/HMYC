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
	public partial class CharmMstComment : BaseEntity<CharmMstComment>
	{ 
		#region	属性
		

		private Guid _comment_Id;

		/// <summary>
		/// Comment_Id
		/// </summary>
		public Guid Comment_Id
		{
			get
			{
				return this._comment_Id;
			}
			set
			{
				this.PropChanged("Comment_Id", this._comment_Id, value);

				this._comment_Id = value;
			}
		}
		

		private int _comment_Type;

		/// <summary>
		/// 0:评论的商品，1:评论的文章
		/// </summary>
		public int Comment_Type
		{
			get
			{
				return this._comment_Type;
			}
			set
			{
				this.PropChanged("Comment_Type", this._comment_Type, value);

				this._comment_Type = value;
			}
		}
		

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
		

		private string _comment_Content;

		/// <summary>
		/// Comment_Content
		/// </summary>
		public string Comment_Content
		{
			get
			{
				return this._comment_Content;
			}
			set
			{
				this.PropChanged("Comment_Content", this._comment_Content, value);

				this._comment_Content = value;
			}
		}
		

		private int? _comment_Rank;

		/// <summary>
		/// 评星
		/// </summary>
		public int? Comment_Rank
		{
			get
			{
				return this._comment_Rank;
			}
			set
			{
				this.PropChanged("Comment_Rank", this._comment_Rank, value);

				this._comment_Rank = value;
			}
		}
		

		private string _ip_Address;

		/// <summary>
		/// Ip_Address
		/// </summary>
		public string Ip_Address
		{
			get
			{
				return this._ip_Address;
			}
			set
			{
				this.PropChanged("Ip_Address", this._ip_Address, value);

				this._ip_Address = value;
			}
		}
		

		private bool? _status;

		/// <summary>
		/// 是否被管理员批准显示;1是;0未批准显示
		/// </summary>
		public bool? Status
		{
			get
			{
				return this._status;
			}
			set
			{
				this.PropChanged("Status", this._status, value);

				this._status = value;
			}
		}
		

		private Guid? _relation_Id;

		/// <summary>
		/// 新闻或者商品的Id
		/// </summary>
		public Guid? Relation_Id
		{
			get
			{
				return this._relation_Id;
			}
			set
			{
				this.PropChanged("Relation_Id", this._relation_Id, value);

				this._relation_Id = value;
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
		

		private bool? _is_Feedback;

		/// <summary>
		/// 是否回复
		/// </summary>
		public bool? Is_Feedback
		{
			get
			{
				return this._is_Feedback;
			}
			set
			{
				this.PropChanged("Is_Feedback", this._is_Feedback, value);

				this._is_Feedback = value;
			}
		}
		

		#endregion

		#region 重载

		public override object PkValue
		{
			get
			{
				return this.Comment_Id; 
			}
		}

		public override string PkName
		{
			get
			{
				return "Comment_Id"; 
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
					
					_props.Add( "Comment_Id","Comment_Id");
					
					_props.Add( "Comment_Type","Comment_Type");
					
					_props.Add( "Member_Id","Member_Id");
					
					_props.Add( "User_Name","User_Name");
					
					_props.Add( "Comment_Content","Comment_Content");
					
					_props.Add( "Comment_Rank","Comment_Rank");
					
					_props.Add( "Ip_Address","Ip_Address");
					
					_props.Add( "Status","Status");
					
					_props.Add( "Relation_Id","Relation_Id");
					
					_props.Add( "Create_By","Create_By");
					
					_props.Add( "Create_Time","Create_Time");
					
					_props.Add( "Modify_By","Modify_By");
					
					_props.Add( "Modify_Time","Modify_Time");
					
					_props.Add( "Is_Feedback","Is_Feedback");
					
				}
				return _props;			 
			 }
	    }

		public override CharmMstComment GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("Comment_Id") && row["Comment_Id"] != null && row["Comment_Id"].ToString() != "")
			{
				this._comment_Id = new Guid(row["Comment_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Comment_Type") && row["Comment_Type"] != null && row["Comment_Type"].ToString() != "")
			{
				this._comment_Type = int.Parse(row["Comment_Type"].ToString());
			}
			if (row.Table.Columns.Contains("Member_Id") && row["Member_Id"] != null && row["Member_Id"].ToString() != "")
			{
				this._member_Id = new Guid(row["Member_Id"].ToString());
			}
			if (row.Table.Columns.Contains("User_Name") && row["User_Name"] != null)
			{
				this._user_Name = row["User_Name"].ToString();
			}
			if (row.Table.Columns.Contains("Comment_Content") && row["Comment_Content"] != null)
			{
				this._comment_Content = row["Comment_Content"].ToString();
			}
			if (row.Table.Columns.Contains("Comment_Rank") && row["Comment_Rank"] != null && row["Comment_Rank"].ToString() != "")
			{
				this._comment_Rank = int.Parse(row["Comment_Rank"].ToString());
			}
			if (row.Table.Columns.Contains("Ip_Address") && row["Ip_Address"] != null)
			{
				this._ip_Address = row["Ip_Address"].ToString();
			}
			if (row.Table.Columns.Contains("Status") && row["Status"] != null && row["Status"].ToString() != "")
			{
				if ((row["Status"].ToString() == "1") || (row["Status"].ToString().ToLower() == "true"))
				{
					this._status = true;
				}
				else
				{
					this._status = false;
				}
			}
			if (row.Table.Columns.Contains("Relation_Id") && row["Relation_Id"] != null && row["Relation_Id"].ToString() != "")
			{
				this._relation_Id = new Guid(row["Relation_Id"].ToString());
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
			if (row.Table.Columns.Contains("Is_Feedback") && row["Is_Feedback"] != null && row["Is_Feedback"].ToString() != "")
			{
				if ((row["Is_Feedback"].ToString() == "1") || (row["Is_Feedback"].ToString().ToLower() == "true"))
				{
					this._is_Feedback = true;
				}
				else
				{
					this._is_Feedback = false;
				}
			}

			return this;
		}

		public override CharmMstComment GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "comment_id" && !reader.IsDBNull(i))
{




_comment_Id = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "comment_type" && !reader.IsDBNull(i))
{









_comment_Type = reader.GetInt32(i);


 continue;
}

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

if (name.ToLower() == "comment_content" && !reader.IsDBNull(i))
{





_comment_Content = reader.GetString(i);






 continue;
}

if (name.ToLower() == "comment_rank" && !reader.IsDBNull(i))
{









_comment_Rank = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "ip_address" && !reader.IsDBNull(i))
{





_ip_Address = reader.GetString(i);






 continue;
}

if (name.ToLower() == "status" && !reader.IsDBNull(i))
{

_status = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "relation_id" && !reader.IsDBNull(i))
{




_relation_Id = reader.GetGuid(i);







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

if (name.ToLower() == "is_feedback" && !reader.IsDBNull(i))
{

_is_Feedback = reader.GetBoolean(i);










 continue;
}
               
}
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Mst_Comment";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Mst_Comment (
					Comment_Id,
					Comment_Type,
					Member_Id,
					User_Name,
					Comment_Content,
					Comment_Rank,
					Ip_Address,
					Status,
					Relation_Id,
					Create_By,
					Create_Time,
					Modify_By,
					Modify_Time,
					Is_Feedback)
				VALUES (
					@Comment_Id,
					@Comment_Type,
					@Member_Id,
					@User_Name,
					@Comment_Content,
					@Comment_Rank,
					@Ip_Address,
					@Status,
					@Relation_Id,
					@Create_By,
					@Create_Time,
					@Modify_By,
					@Modify_Time,
					@Is_Feedback)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@Comment_Id", this.Comment_Id},
				{"@Comment_Type", this.Comment_Type},
				{"@Member_Id", this.Member_Id},
				{"@User_Name", this.User_Name},
				{"@Comment_Content", this.Comment_Content},
				{"@Comment_Rank", this.Comment_Rank},
				{"@Ip_Address", this.Ip_Address},
				{"@Status", this.Status},
				{"@Relation_Id", this.Relation_Id},
				{"@Create_By", this.Create_By},
				{"@Create_Time", this.Create_Time},
				{"@Modify_By", this.Modify_By},
				{"@Modify_Time", this.Modify_Time},
				{"@Is_Feedback", this.Is_Feedback}};

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