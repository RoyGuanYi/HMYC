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
	public partial class CharmMstGoods : BaseEntity<CharmMstGoods>
	{ 
		#region	属性
		

		private Guid _goods_id;

		/// <summary>
		/// Goods_id
		/// </summary>
		public Guid Goods_id
		{
			get
			{
				return this._goods_id;
			}
			set
			{
				this.PropChanged("Goods_id", this._goods_id, value);

				this._goods_id = value;
			}
		}
		

		private string _goods_Name;

		/// <summary>
		/// Goods_Name
		/// </summary>
		public string Goods_Name
		{
			get
			{
				return this._goods_Name;
			}
			set
			{
				this.PropChanged("Goods_Name", this._goods_Name, value);

				this._goods_Name = value;
			}
		}
		

		private int? _click_Count;

		/// <summary>
		/// 商品被点击的次数
		/// </summary>
		public int? Click_Count
		{
			get
			{
				return this._click_Count;
			}
			set
			{
				this.PropChanged("Click_Count", this._click_Count, value);

				this._click_Count = value;
			}
		}
		

		private decimal _market_Price;

		/// <summary>
		/// Market_Price
		/// </summary>
		public decimal Market_Price
		{
			get
			{
				return this._market_Price;
			}
			set
			{
				this.PropChanged("Market_Price", this._market_Price, value);

				this._market_Price = value;
			}
		}
		

		private decimal _shop_Price;

		/// <summary>
		/// Shop_Price
		/// </summary>
		public decimal Shop_Price
		{
			get
			{
				return this._shop_Price;
			}
			set
			{
				this.PropChanged("Shop_Price", this._shop_Price, value);

				this._shop_Price = value;
			}
		}
		

		private string _goods_Keywords;

		/// <summary>
		/// 商品关键字，走索引查询用。
		/// </summary>
		public string Goods_Keywords
		{
			get
			{
				return this._goods_Keywords;
			}
			set
			{
				this.PropChanged("Goods_Keywords", this._goods_Keywords, value);

				this._goods_Keywords = value;
			}
		}
		

		private string _goods_Brief;

		/// <summary>
		/// 商品简介
		/// </summary>
		public string Goods_Brief
		{
			get
			{
				return this._goods_Brief;
			}
			set
			{
				this.PropChanged("Goods_Brief", this._goods_Brief, value);

				this._goods_Brief = value;
			}
		}
		

		private string _goods_Desc;

		/// <summary>
		/// 商品详细介绍
		/// </summary>
		public string Goods_Desc
		{
			get
			{
				return this._goods_Desc;
			}
			set
			{
				this.PropChanged("Goods_Desc", this._goods_Desc, value);

				this._goods_Desc = value;
			}
		}
		

		private string _goods_Thumb_Img;

		/// <summary>
		/// 缩略图
		/// </summary>
		public string Goods_Thumb_Img
		{
			get
			{
				return this._goods_Thumb_Img;
			}
			set
			{
				this.PropChanged("Goods_Thumb_Img", this._goods_Thumb_Img, value);

				this._goods_Thumb_Img = value;
			}
		}
		

		private string _goods_Real_Img;

		/// <summary>
		/// 实际图片大小
		/// </summary>
		public string Goods_Real_Img
		{
			get
			{
				return this._goods_Real_Img;
			}
			set
			{
				this.PropChanged("Goods_Real_Img", this._goods_Real_Img, value);

				this._goods_Real_Img = value;
			}
		}
		

		private string _goods_Original_Img;

		/// <summary>
		/// 商家上传图片
		/// </summary>
		public string Goods_Original_Img
		{
			get
			{
				return this._goods_Original_Img;
			}
			set
			{
				this.PropChanged("Goods_Original_Img", this._goods_Original_Img, value);

				this._goods_Original_Img = value;
			}
		}
		

		private bool? _is_Real_Goods;

		/// <summary>
		/// 是否是实物，1，是；0，否；比如虚拟卡就为0，不是实物
		/// </summary>
		public bool? Is_Real_Goods
		{
			get
			{
				return this._is_Real_Goods;
			}
			set
			{
				this.PropChanged("Is_Real_Goods", this._is_Real_Goods, value);

				this._is_Real_Goods = value;
			}
		}
		

		private bool? _is_OnSale;

		/// <summary>
		/// 是否开放销售
		/// </summary>
		public bool? Is_OnSale
		{
			get
			{
				return this._is_OnSale;
			}
			set
			{
				this.PropChanged("Is_OnSale", this._is_OnSale, value);

				this._is_OnSale = value;
			}
		}
		

		private int? _sort_Order;

		/// <summary>
		/// Sort_Order
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
		

		private string _modify_By_Admin;

		/// <summary>
		/// Modify_By_Admin
		/// </summary>
		public string Modify_By_Admin
		{
			get
			{
				return this._modify_By_Admin;
			}
			set
			{
				this.PropChanged("Modify_By_Admin", this._modify_By_Admin, value);

				this._modify_By_Admin = value;
			}
		}
		

		private DateTime? _modify_Time_Admin;

		/// <summary>
		/// Modify_Time_Admin
		/// </summary>
		public DateTime? Modify_Time_Admin
		{
			get
			{
				return this._modify_Time_Admin;
			}
			set
			{
				this.PropChanged("Modify_Time_Admin", this._modify_Time_Admin, value);

				this._modify_Time_Admin = value;
			}
		}
		

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
		

		private Guid _brand_Id;

		/// <summary>
		/// 商家ID
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
		

		private int? _collection_Count;

		/// <summary>
		/// 商品被用户收藏的次数
		/// </summary>
		public int? Collection_Count
		{
			get
			{
				return this._collection_Count;
			}
			set
			{
				this.PropChanged("Collection_Count", this._collection_Count, value);

				this._collection_Count = value;
			}
		}
		

		#endregion

		#region 重载

		public override object PkValue
		{
			get
			{
				return this.Goods_id; 
			}
		}

		public override string PkName
		{
			get
			{
				return "Goods_id"; 
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
					
					_props.Add( "Goods_id","Goods_id");
					
					_props.Add( "Goods_Name","Goods_Name");
					
					_props.Add( "Click_Count","Click_Count");
					
					_props.Add( "Market_Price","Market_Price");
					
					_props.Add( "Shop_Price","Shop_Price");
					
					_props.Add( "Goods_Keywords","Goods_Keywords");
					
					_props.Add( "Goods_Brief","Goods_Brief");
					
					_props.Add( "Goods_Desc","Goods_Desc");
					
					_props.Add( "Goods_Thumb_Img","Goods_Thumb_Img");
					
					_props.Add( "Goods_Real_Img","Goods_Real_Img");
					
					_props.Add( "Goods_Original_Img","Goods_Original_Img");
					
					_props.Add( "Is_Real_Goods","Is_Real_Goods");
					
					_props.Add( "Is_OnSale","Is_OnSale");
					
					_props.Add( "Sort_Order","Sort_Order");
					
					_props.Add( "Create_By","Create_By");
					
					_props.Add( "Create_Time","Create_Time");
					
					_props.Add( "Modify_By","Modify_By");
					
					_props.Add( "Modify_Time","Modify_Time");
					
					_props.Add( "Modify_By_Admin","Modify_By_Admin");
					
					_props.Add( "Modify_Time_Admin","Modify_Time_Admin");
					
					_props.Add( "Category_Id","Category_Id");
					
					_props.Add( "Brand_Id","Brand_Id");
					
					_props.Add( "Collection_Count","Collection_Count");
					
				}
				return _props;			 
			 }
	    }

		public override CharmMstGoods GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("Goods_id") && row["Goods_id"] != null && row["Goods_id"].ToString() != "")
			{
				this._goods_id = new Guid(row["Goods_id"].ToString());
			}
			if (row.Table.Columns.Contains("Goods_Name") && row["Goods_Name"] != null)
			{
				this._goods_Name = row["Goods_Name"].ToString();
			}
			if (row.Table.Columns.Contains("Click_Count") && row["Click_Count"] != null && row["Click_Count"].ToString() != "")
			{
				this._click_Count = int.Parse(row["Click_Count"].ToString());
			}
			if (row.Table.Columns.Contains("Market_Price") && row["Market_Price"] != null && row["Market_Price"].ToString() != "")
			{
				this._market_Price = decimal.Parse(row["Market_Price"].ToString());
			}
			if (row.Table.Columns.Contains("Shop_Price") && row["Shop_Price"] != null && row["Shop_Price"].ToString() != "")
			{
				this._shop_Price = decimal.Parse(row["Shop_Price"].ToString());
			}
			if (row.Table.Columns.Contains("Goods_Keywords") && row["Goods_Keywords"] != null)
			{
				this._goods_Keywords = row["Goods_Keywords"].ToString();
			}
			if (row.Table.Columns.Contains("Goods_Brief") && row["Goods_Brief"] != null)
			{
				this._goods_Brief = row["Goods_Brief"].ToString();
			}
			if (row.Table.Columns.Contains("Goods_Desc") && row["Goods_Desc"] != null)
			{
				this._goods_Desc = row["Goods_Desc"].ToString();
			}
			if (row.Table.Columns.Contains("Goods_Thumb_Img") && row["Goods_Thumb_Img"] != null)
			{
				this._goods_Thumb_Img = row["Goods_Thumb_Img"].ToString();
			}
			if (row.Table.Columns.Contains("Goods_Real_Img") && row["Goods_Real_Img"] != null)
			{
				this._goods_Real_Img = row["Goods_Real_Img"].ToString();
			}
			if (row.Table.Columns.Contains("Goods_Original_Img") && row["Goods_Original_Img"] != null)
			{
				this._goods_Original_Img = row["Goods_Original_Img"].ToString();
			}
			if (row.Table.Columns.Contains("Is_Real_Goods") && row["Is_Real_Goods"] != null && row["Is_Real_Goods"].ToString() != "")
			{
				if ((row["Is_Real_Goods"].ToString() == "1") || (row["Is_Real_Goods"].ToString().ToLower() == "true"))
				{
					this._is_Real_Goods = true;
				}
				else
				{
					this._is_Real_Goods = false;
				}
			}
			if (row.Table.Columns.Contains("Is_OnSale") && row["Is_OnSale"] != null && row["Is_OnSale"].ToString() != "")
			{
				if ((row["Is_OnSale"].ToString() == "1") || (row["Is_OnSale"].ToString().ToLower() == "true"))
				{
					this._is_OnSale = true;
				}
				else
				{
					this._is_OnSale = false;
				}
			}
			if (row.Table.Columns.Contains("Sort_Order") && row["Sort_Order"] != null && row["Sort_Order"].ToString() != "")
			{
				this._sort_Order = int.Parse(row["Sort_Order"].ToString());
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
			if (row.Table.Columns.Contains("Modify_By_Admin") && row["Modify_By_Admin"] != null)
			{
				this._modify_By_Admin = row["Modify_By_Admin"].ToString();
			}
			if (row.Table.Columns.Contains("Modify_Time_Admin") && row["Modify_Time_Admin"] != null && row["Modify_Time_Admin"].ToString() != "")
			{
				this._modify_Time_Admin = DateTime.Parse(row["Modify_Time_Admin"].ToString());
			}
			if (row.Table.Columns.Contains("Category_Id") && row["Category_Id"] != null && row["Category_Id"].ToString() != "")
			{
				this._category_Id = int.Parse(row["Category_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Brand_Id") && row["Brand_Id"] != null && row["Brand_Id"].ToString() != "")
			{
				this._brand_Id = new Guid(row["Brand_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Collection_Count") && row["Collection_Count"] != null && row["Collection_Count"].ToString() != "")
			{
				this._collection_Count = int.Parse(row["Collection_Count"].ToString());
			}

			return this;
		}

		public override CharmMstGoods GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "goods_id" && !reader.IsDBNull(i))
{




_goods_id = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "goods_name" && !reader.IsDBNull(i))
{





_goods_Name = reader.GetString(i);






 continue;
}

if (name.ToLower() == "click_count" && !reader.IsDBNull(i))
{









_click_Count = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "market_price" && !reader.IsDBNull(i))
{






_market_Price = reader.GetDecimal(i);





 continue;
}

if (name.ToLower() == "shop_price" && !reader.IsDBNull(i))
{






_shop_Price = reader.GetDecimal(i);





 continue;
}

if (name.ToLower() == "goods_keywords" && !reader.IsDBNull(i))
{





_goods_Keywords = reader.GetString(i);






 continue;
}

if (name.ToLower() == "goods_brief" && !reader.IsDBNull(i))
{





_goods_Brief = reader.GetString(i);






 continue;
}

if (name.ToLower() == "goods_desc" && !reader.IsDBNull(i))
{





_goods_Desc = reader.GetString(i);






 continue;
}

if (name.ToLower() == "goods_thumb_img" && !reader.IsDBNull(i))
{





_goods_Thumb_Img = reader.GetString(i);






 continue;
}

if (name.ToLower() == "goods_real_img" && !reader.IsDBNull(i))
{





_goods_Real_Img = reader.GetString(i);






 continue;
}

if (name.ToLower() == "goods_original_img" && !reader.IsDBNull(i))
{





_goods_Original_Img = reader.GetString(i);






 continue;
}

if (name.ToLower() == "is_real_goods" && !reader.IsDBNull(i))
{

_is_Real_Goods = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "is_onsale" && !reader.IsDBNull(i))
{

_is_OnSale = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "sort_order" && !reader.IsDBNull(i))
{









_sort_Order = reader.GetInt32(i);


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

if (name.ToLower() == "modify_by_admin" && !reader.IsDBNull(i))
{





_modify_By_Admin = reader.GetString(i);






 continue;
}

if (name.ToLower() == "modify_time_admin" && !reader.IsDBNull(i))
{



_modify_Time_Admin = reader.GetDateTime(i);








 continue;
}

if (name.ToLower() == "category_id" && !reader.IsDBNull(i))
{









_category_Id = reader.GetInt32(i);


 continue;
}

if (name.ToLower() == "brand_id" && !reader.IsDBNull(i))
{




_brand_Id = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "collection_count" && !reader.IsDBNull(i))
{









_collection_Count = reader.GetInt32(i);


 continue;
}
               
}
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Mst_Goods";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Mst_Goods (
					Goods_id,
					Goods_Name,
					Click_Count,
					Market_Price,
					Shop_Price,
					Goods_Keywords,
					Goods_Brief,
					Goods_Desc,
					Goods_Thumb_Img,
					Goods_Real_Img,
					Goods_Original_Img,
					Is_Real_Goods,
					Is_OnSale,
					Sort_Order,
					Create_By,
					Create_Time,
					Modify_By,
					Modify_Time,
					Modify_By_Admin,
					Modify_Time_Admin,
					Category_Id,
					Brand_Id,
					Collection_Count)
				VALUES (
					@Goods_id,
					@Goods_Name,
					@Click_Count,
					@Market_Price,
					@Shop_Price,
					@Goods_Keywords,
					@Goods_Brief,
					@Goods_Desc,
					@Goods_Thumb_Img,
					@Goods_Real_Img,
					@Goods_Original_Img,
					@Is_Real_Goods,
					@Is_OnSale,
					@Sort_Order,
					@Create_By,
					@Create_Time,
					@Modify_By,
					@Modify_Time,
					@Modify_By_Admin,
					@Modify_Time_Admin,
					@Category_Id,
					@Brand_Id,
					@Collection_Count)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@Goods_id", this.Goods_id},
				{"@Goods_Name", this.Goods_Name},
				{"@Click_Count", this.Click_Count},
				{"@Market_Price", this.Market_Price},
				{"@Shop_Price", this.Shop_Price},
				{"@Goods_Keywords", this.Goods_Keywords},
				{"@Goods_Brief", this.Goods_Brief},
				{"@Goods_Desc", this.Goods_Desc},
				{"@Goods_Thumb_Img", this.Goods_Thumb_Img},
				{"@Goods_Real_Img", this.Goods_Real_Img},
				{"@Goods_Original_Img", this.Goods_Original_Img},
				{"@Is_Real_Goods", this.Is_Real_Goods},
				{"@Is_OnSale", this.Is_OnSale},
				{"@Sort_Order", this.Sort_Order},
				{"@Create_By", this.Create_By},
				{"@Create_Time", this.Create_Time},
				{"@Modify_By", this.Modify_By},
				{"@Modify_Time", this.Modify_Time},
				{"@Modify_By_Admin", this.Modify_By_Admin},
				{"@Modify_Time_Admin", this.Modify_Time_Admin},
				{"@Category_Id", this.Category_Id},
				{"@Brand_Id", this.Brand_Id},
				{"@Collection_Count", this.Collection_Count}};

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