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
	public partial class CharmMstGoodsImage : BaseEntity<CharmMstGoodsImage>
	{ 
		#region	属性
		

		private Guid _goods_Image_Id;

		/// <summary>
		/// Goods_Image_Id
		/// </summary>
		public Guid Goods_Image_Id
		{
			get
			{
				return this._goods_Image_Id;
			}
			set
			{
				this.PropChanged("Goods_Image_Id", this._goods_Image_Id, value);

				this._goods_Image_Id = value;
			}
		}
		

		private Guid? _goods_Id;

		/// <summary>
		/// Goods_Id
		/// </summary>
		public Guid? Goods_Id
		{
			get
			{
				return this._goods_Id;
			}
			set
			{
				this.PropChanged("Goods_Id", this._goods_Id, value);

				this._goods_Id = value;
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
		

		#endregion

		#region 重载

		public override object PkValue
		{
			get
			{
				return this.Goods_Image_Id; 
			}
		}

		public override string PkName
		{
			get
			{
				return "Goods_Image_Id"; 
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
					
					_props.Add( "Goods_Image_Id","Goods_Image_Id");
					
					_props.Add( "Goods_Id","Goods_Id");
					
					_props.Add( "Goods_Thumb_Img","Goods_Thumb_Img");
					
					_props.Add( "Goods_Real_Img","Goods_Real_Img");
					
					_props.Add( "Goods_Original_Img","Goods_Original_Img");
					
				}
				return _props;			 
			 }
	    }

		public override CharmMstGoodsImage GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("Goods_Image_Id") && row["Goods_Image_Id"] != null && row["Goods_Image_Id"].ToString() != "")
			{
				this._goods_Image_Id = new Guid(row["Goods_Image_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Goods_Id") && row["Goods_Id"] != null && row["Goods_Id"].ToString() != "")
			{
				this._goods_Id = new Guid(row["Goods_Id"].ToString());
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

			return this;
		}

		public override CharmMstGoodsImage GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
if (name.ToLower() == "goods_image_id" && !reader.IsDBNull(i))
{




_goods_Image_Id = reader.GetGuid(i);







 continue;
}

if (name.ToLower() == "goods_id" && !reader.IsDBNull(i))
{




_goods_Id = reader.GetGuid(i);







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
               
}
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Mst_Goods_Image";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Mst_Goods_Image (
					Goods_Image_Id,
					Goods_Id,
					Goods_Thumb_Img,
					Goods_Real_Img,
					Goods_Original_Img)
				VALUES (
					@Goods_Image_Id,
					@Goods_Id,
					@Goods_Thumb_Img,
					@Goods_Real_Img,
					@Goods_Original_Img)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@Goods_Image_Id", this.Goods_Image_Id},
				{"@Goods_Id", this.Goods_Id},
				{"@Goods_Thumb_Img", this.Goods_Thumb_Img},
				{"@Goods_Real_Img", this.Goods_Real_Img},
				{"@Goods_Original_Img", this.Goods_Original_Img}};

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