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
	public partial class CharmArticle : BaseEntity<CharmArticle>
	{ 
		#region	属性
		

		private Guid _article_Id;

		/// <summary>
		/// Article_Id
		/// </summary>
		public Guid Article_Id
		{
			get
			{
				return this._article_Id;
			}
			set
			{
				this.PropChanged("Article_Id", this._article_Id, value);

				this._article_Id = value;
			}
		}
		

		private string _article_Title;

		/// <summary>
		/// Article_Title
		/// </summary>
		public string Article_Title
		{
			get
			{
				return this._article_Title;
			}
			set
			{
				this.PropChanged("Article_Title", this._article_Title, value);

				this._article_Title = value;
			}
		}
		

		private string _article_Content;

		/// <summary>
		/// Article_Content
		/// </summary>
		public string Article_Content
		{
			get
			{
				return this._article_Content;
			}
			set
			{
				this.PropChanged("Article_Content", this._article_Content, value);

				this._article_Content = value;
			}
		}
		

		private string _author;

		/// <summary>
		/// Author
		/// </summary>
		public string Author
		{
			get
			{
				return this._author;
			}
			set
			{
				this.PropChanged("Author", this._author, value);

				this._author = value;
			}
		}
		

		private string _keywords;

		/// <summary>
		/// Keywords
		/// </summary>
		public string Keywords
		{
			get
			{
				return this._keywords;
			}
			set
			{
				this.PropChanged("Keywords", this._keywords, value);

				this._keywords = value;
			}
		}
		

		private int? _article_Type;

		/// <summary>
		/// 文章类型 1,普通分类2,系统分类 3,网店信息 4, 帮助分类 5,网店帮助
		/// </summary>
		public int? Article_Type
		{
			get
			{
				return this._article_Type;
			}
			set
			{
				this.PropChanged("Article_Type", this._article_Type, value);

				this._article_Type = value;
			}
		}
		

		private bool? _is_Show;

		/// <summary>
		/// Is_Show
		/// </summary>
		public bool? Is_Show
		{
			get
			{
				return this._is_Show;
			}
			set
			{
				this.PropChanged("Is_Show", this._is_Show, value);

				this._is_Show = value;
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
				return this.Article_Id; 
			}
		}

		public override string PkName
		{
			get
			{
				return "Article_Id"; 
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
					
					_props.Add( "Article_Id","Article_Id");
					
					_props.Add( "Article_Title","Article_Title");
					
					_props.Add( "Article_Content","Article_Content");
					
					_props.Add( "Author","Author");
					
					_props.Add( "Keywords","Keywords");
					
					_props.Add( "Article_Type","Article_Type");
					
					_props.Add( "Is_Show","Is_Show");
					
					_props.Add( "Create_By","Create_By");
					
					_props.Add( "Create_Time","Create_Time");
					
					_props.Add( "Modify_By","Modify_By");
					
					_props.Add( "Modify_Time","Modify_Time");
					
				}
				return _props;			 
			 }
	    }

		public override CharmArticle GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("Article_Id") && row["Article_Id"] != null && row["Article_Id"].ToString() != "")
			{
				this._article_Id = new Guid(row["Article_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Article_Title") && row["Article_Title"] != null)
			{
				this._article_Title = row["Article_Title"].ToString();
			}
			if (row.Table.Columns.Contains("Article_Content") && row["Article_Content"] != null)
			{
				this._article_Content = row["Article_Content"].ToString();
			}
			if (row.Table.Columns.Contains("Author") && row["Author"] != null)
			{
				this._author = row["Author"].ToString();
			}
			if (row.Table.Columns.Contains("Keywords") && row["Keywords"] != null)
			{
				this._keywords = row["Keywords"].ToString();
			}
			if (row.Table.Columns.Contains("Article_Type") && row["Article_Type"] != null && row["Article_Type"].ToString() != "")
			{
				this._article_Type = int.Parse(row["Article_Type"].ToString());
			}
			if (row.Table.Columns.Contains("Is_Show") && row["Is_Show"] != null && row["Is_Show"].ToString() != "")
			{
				if ((row["Is_Show"].ToString() == "1") || (row["Is_Show"].ToString().ToLower() == "true"))
				{
					this._is_Show = true;
				}
				else
				{
					this._is_Show = false;
				}
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

		public override CharmArticle GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "article_id" && !reader.IsDBNull(i))
{




_article_Id = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "article_title" && !reader.IsDBNull(i))
{





_article_Title = reader.GetString(i);






 continue;
}

if (name.ToLower() == "article_content" && !reader.IsDBNull(i))
{





_article_Content = reader.GetString(i);






 continue;
}

if (name.ToLower() == "author" && !reader.IsDBNull(i))
{





_author = reader.GetString(i);






 continue;
}

if (name.ToLower() == "keywords" && !reader.IsDBNull(i))
{





_keywords = reader.GetString(i);






 continue;
}

if (name.ToLower() == "article_type" && !reader.IsDBNull(i))
{









_article_Type = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "is_show" && !reader.IsDBNull(i))
{

_is_Show = reader.GetBoolean(i);










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
				return "Charm_Article";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Article (
					Article_Id,
					Article_Title,
					Article_Content,
					Author,
					Keywords,
					Article_Type,
					Is_Show,
					Create_By,
					Create_Time,
					Modify_By,
					Modify_Time)
				VALUES (
					@Article_Id,
					@Article_Title,
					@Article_Content,
					@Author,
					@Keywords,
					@Article_Type,
					@Is_Show,
					@Create_By,
					@Create_Time,
					@Modify_By,
					@Modify_Time)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@Article_Id", this.Article_Id},
				{"@Article_Title", this.Article_Title},
				{"@Article_Content", this.Article_Content},
				{"@Author", this.Author},
				{"@Keywords", this.Keywords},
				{"@Article_Type", this.Article_Type},
				{"@Is_Show", this.Is_Show},
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