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
	public partial class CharmMstFeedback : BaseEntity<CharmMstFeedback>
	{ 
		#region	属性
		

		private Guid _feedback_Id;

		/// <summary>
		/// Feedback_Id
		/// </summary>
		public Guid Feedback_Id
		{
			get
			{
				return this._feedback_Id;
			}
			set
			{
				this.PropChanged("Feedback_Id", this._feedback_Id, value);

				this._feedback_Id = value;
			}
		}
		

		private Guid _brand_Id;

		/// <summary>
		/// Brand_Id
		/// </summary>
		public Guid Brand_Id
		{
			get
			{
				return this._brand_Id;
			}
			set
			{
				this.PropChanged("Brand_Id", this._brand_Id, value);

				this._brand_Id = value;
			}
		}
		

		private string _brand_Name;

		/// <summary>
		/// Brand_Name
		/// </summary>
		public string Brand_Name
		{
			get
			{
				return this._brand_Name;
			}
			set
			{
				this.PropChanged("Brand_Name", this._brand_Name, value);

				this._brand_Name = value;
			}
		}
		

		private string _feedback_Content;

		/// <summary>
		/// Feedback_Content
		/// </summary>
		public string Feedback_Content
		{
			get
			{
				return this._feedback_Content;
			}
			set
			{
				this.PropChanged("Feedback_Content", this._feedback_Content, value);

				this._feedback_Content = value;
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
		

		private Guid? _comment_Id;

		/// <summary>
		/// 回复的哪条评论
		/// </summary>
		public Guid? Comment_Id
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
		

		#endregion

		#region 重载

		public override object PkValue
		{
			get
			{
				return this.Feedback_Id; 
			}
		}

		public override string PkName
		{
			get
			{
				return "Feedback_Id"; 
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
					
					_props.Add( "Feedback_Id","Feedback_Id");
					
					_props.Add( "Brand_Id","Brand_Id");
					
					_props.Add( "Brand_Name","Brand_Name");
					
					_props.Add( "Feedback_Content","Feedback_Content");
					
					_props.Add( "Status","Status");
					
					_props.Add( "Comment_Id","Comment_Id");
					
					_props.Add( "Create_By","Create_By");
					
					_props.Add( "Create_Time","Create_Time");
					
					_props.Add( "Modify_By","Modify_By");
					
					_props.Add( "Modify_Time","Modify_Time");
					
				}
				return _props;			 
			 }
	    }

		public override CharmMstFeedback GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("Feedback_Id") && row["Feedback_Id"] != null && row["Feedback_Id"].ToString() != "")
			{
				this._feedback_Id = new Guid(row["Feedback_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Brand_Id") && row["Brand_Id"] != null && row["Brand_Id"].ToString() != "")
			{
				this._brand_Id = new Guid(row["Brand_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Brand_Name") && row["Brand_Name"] != null)
			{
				this._brand_Name = row["Brand_Name"].ToString();
			}
			if (row.Table.Columns.Contains("Feedback_Content") && row["Feedback_Content"] != null)
			{
				this._feedback_Content = row["Feedback_Content"].ToString();
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
			if (row.Table.Columns.Contains("Comment_Id") && row["Comment_Id"] != null && row["Comment_Id"].ToString() != "")
			{
				this._comment_Id = new Guid(row["Comment_Id"].ToString());
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

			return this;
		}

		public override CharmMstFeedback GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "feedback_id" && !reader.IsDBNull(i))
{




_feedback_Id = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "brand_id" && !reader.IsDBNull(i))
{




_brand_Id = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "brand_name" && !reader.IsDBNull(i))
{





_brand_Name = reader.GetString(i);






 continue;
}

if (name.ToLower() == "feedback_content" && !reader.IsDBNull(i))
{





_feedback_Content = reader.GetString(i);






 continue;
}

if (name.ToLower() == "status" && !reader.IsDBNull(i))
{

_status = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "comment_id" && !reader.IsDBNull(i))
{




_comment_Id = reader.GetGuid(i);







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
               
}
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Mst_Feedback";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Mst_Feedback (
					Feedback_Id,
					Brand_Id,
					Brand_Name,
					Feedback_Content,
					Status,
					Comment_Id,
					Create_By,
					Create_Time,
					Modify_By,
					Modify_Time)
				VALUES (
					@Feedback_Id,
					@Brand_Id,
					@Brand_Name,
					@Feedback_Content,
					@Status,
					@Comment_Id,
					@Create_By,
					@Create_Time,
					@Modify_By,
					@Modify_Time)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@Feedback_Id", this.Feedback_Id},
				{"@Brand_Id", this.Brand_Id},
				{"@Brand_Name", this.Brand_Name},
				{"@Feedback_Content", this.Feedback_Content},
				{"@Status", this.Status},
				{"@Comment_Id", this.Comment_Id},
				{"@Create_By", this.Create_By},
				{"@Create_Time", this.Create_Time},
				{"@Modify_By", this.Modify_By},
				{"@Modify_Time", this.Modify_Time}};

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