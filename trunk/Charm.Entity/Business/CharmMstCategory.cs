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
	public partial class CharmMstCategory : BaseEntity<CharmMstCategory>
	{ 
		#region	属性
		

		private int _category_Id;

		/// <summary>
		/// Category_Id
		/// </summary>
		public int Category_Id
		{
			get
			{
				return this._category_Id;
			}
			set
			{
				this.PropChanged("Category_Id", this._category_Id, value);

				this._category_Id = value;
			}
		}
		

		private string _category_Name;

		/// <summary>
		/// Category_Name
		/// </summary>
		public string Category_Name
		{
			get
			{
				return this._category_Name;
			}
			set
			{
				this.PropChanged("Category_Name", this._category_Name, value);

				this._category_Name = value;
			}
		}
		

		private string _keywords;

		/// <summary>
		/// 搜索关键字，索引用。
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
		

		private string _category_Desc;

		/// <summary>
		/// Category_Desc
		/// </summary>
		public string Category_Desc
		{
			get
			{
				return this._category_Desc;
			}
			set
			{
				this.PropChanged("Category_Desc", this._category_Desc, value);

				this._category_Desc = value;
			}
		}
		

		private int? _parent_id;

		/// <summary>
		/// 父级ID
		/// </summary>
		public int? Parent_id
		{
			get
			{
				return this._parent_id;
			}
			set
			{
				this.PropChanged("Parent_id", this._parent_id, value);

				this._parent_id = value;
			}
		}
		

		private int? _sort_Order;

		/// <summary>
		/// 排序，数字越小越往前。
		/// </summary>
		public int? Sort_Order
		{
			get
			{
				return this._sort_Order;
			}
			set
			{
				this.PropChanged("Sort_Order", this._sort_Order, value);

				this._sort_Order = value;
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
		

		#endregion

		#region 重载

		public override object PkValue
		{
			get
			{
				return this.Category_Id; 
			}
		}

		public override string PkName
		{
			get
			{
				return "Category_Id"; 
			}
		}

		public override bool IsIdentityPk
		{
			get 
			{
				return true; 
			}
		}

		
		public override void SetIdentity(object v)
		{
			this.Category_Id = int.Parse(v.ToString());
		}
		

		private Dictionary<string, string> _props;

		public override Dictionary<string, string> Props
	    {
	        get {
				if(_props == null)
				{
					_props = new Dictionary<string, string>();
					
					_props.Add( "Category_Id","Category_Id");
					
					_props.Add( "Category_Name","Category_Name");
					
					_props.Add( "Keywords","Keywords");
					
					_props.Add( "Category_Desc","Category_Desc");
					
					_props.Add( "Parent_id","Parent_id");
					
					_props.Add( "Sort_Order","Sort_Order");
					
					_props.Add( "Is_Show","Is_Show");
					
				}
				return _props;			 
			 }
	    }

		public override CharmMstCategory GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("Category_Id") && row["Category_Id"] != null && row["Category_Id"].ToString() != "")
			{
				this._category_Id = int.Parse(row["Category_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Category_Name") && row["Category_Name"] != null)
			{
				this._category_Name = row["Category_Name"].ToString();
			}
			if (row.Table.Columns.Contains("Keywords") && row["Keywords"] != null)
			{
				this._keywords = row["Keywords"].ToString();
			}
			if (row.Table.Columns.Contains("Category_Desc") && row["Category_Desc"] != null)
			{
				this._category_Desc = row["Category_Desc"].ToString();
			}
			if (row.Table.Columns.Contains("Parent_id") && row["Parent_id"] != null && row["Parent_id"].ToString() != "")
			{
				this._parent_id = int.Parse(row["Parent_id"].ToString());
			}
			if (row.Table.Columns.Contains("Sort_Order") && row["Sort_Order"] != null && row["Sort_Order"].ToString() != "")
			{
				this._sort_Order = int.Parse(row["Sort_Order"].ToString());
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

			return this;
		}

		public override CharmMstCategory GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "category_id" && !reader.IsDBNull(i))
{









_category_Id = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "category_name" && !reader.IsDBNull(i))
{





_category_Name = reader.GetString(i);






 continue;
}

if (name.ToLower() == "keywords" && !reader.IsDBNull(i))
{





_keywords = reader.GetString(i);






 continue;
}

if (name.ToLower() == "category_desc" && !reader.IsDBNull(i))
{





_category_Desc = reader.GetString(i);






 continue;
}

if (name.ToLower() == "parent_id" && !reader.IsDBNull(i))
{









_parent_id = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "sort_order" && !reader.IsDBNull(i))
{









_sort_Order = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "is_show" && !reader.IsDBNull(i))
{

_is_Show = reader.GetBoolean(i);










 continue;
}
               
}
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Mst_Category";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Mst_Category (
					Category_Name,
					Keywords,
					Category_Desc,
					Parent_id,
					Sort_Order,
					Is_Show)
				VALUES (
					@Category_Name,
					@Keywords,
					@Category_Desc,
					@Parent_id,
					@Sort_Order,
					@Is_Show)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@Category_Name", this.Category_Name},
				{"@Keywords", this.Keywords},
				{"@Category_Desc", this.Category_Desc},
				{"@Parent_id", this.Parent_id},
				{"@Sort_Order", this.Sort_Order},
				{"@Is_Show", this.Is_Show}};

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