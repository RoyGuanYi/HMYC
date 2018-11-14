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
	public partial class CharmBusinessBrand : BaseEntity<CharmBusinessBrand>
	{ 
		#region	属性
		

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
		

		private string _brand_Logo;

		/// <summary>
		/// Brand_Logo
		/// </summary>
		public string Brand_Logo
		{
			get
			{
				return this._brand_Logo;
			}
			set
			{
				this.PropChanged("Brand_Logo", this._brand_Logo, value);

				this._brand_Logo = value;
			}
		}
		

		private string _brand_Desc;

		/// <summary>
		/// Brand_Desc
		/// </summary>
		public string Brand_Desc
		{
			get
			{
				return this._brand_Desc;
			}
			set
			{
				this.PropChanged("Brand_Desc", this._brand_Desc, value);

				this._brand_Desc = value;
			}
		}
		

		private string _site_Url;

		/// <summary>
		/// Site_Url
		/// </summary>
		public string Site_Url
		{
			get
			{
				return this._site_Url;
			}
			set
			{
				this.PropChanged("Site_Url", this._site_Url, value);

				this._site_Url = value;
			}
		}
		

		private string _site_Short_Url;

		/// <summary>
		/// Site_Short_Url
		/// </summary>
		public string Site_Short_Url
		{
			get
			{
				return this._site_Short_Url;
			}
			set
			{
				this.PropChanged("Site_Short_Url", this._site_Short_Url, value);

				this._site_Short_Url = value;
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
		

		private bool? _is_Hot;

		/// <summary>
		/// Is_Hot
		/// </summary>
		public bool? Is_Hot
		{
			get
			{
				return this._is_Hot;
			}
			set
			{
				this.PropChanged("Is_Hot", this._is_Hot, value);

				this._is_Hot = value;
			}
		}
		

		private int _brand_Code;

		/// <summary>
		/// 商家编号，唯一不能重复，跟在URL后的QUERYSTRING。
		/// </summary>
		public int Brand_Code
		{
			get
			{
				return this._brand_Code;
			}
			set
			{
				this.PropChanged("Brand_Code", this._brand_Code, value);

				this._brand_Code = value;
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
		

		private string _brand_Phone;

		/// <summary>
		/// 商家联系方式
		/// </summary>
		public string Brand_Phone
		{
			get
			{
				return this._brand_Phone;
			}
			set
			{
				this.PropChanged("Brand_Phone", this._brand_Phone, value);

				this._brand_Phone = value;
			}
		}


        private string _userAccount;
        /// <summary>
        /// 品牌账号
        /// </summary>
        public string UserAccount
        {
            get
            {
                return this._userAccount;
            }
            set
            {
                this.PropChanged("UserAccount", this._userAccount, value);

                this._userAccount = value;
            }
        }

        private string _userPassword;

        /// <summary>
        /// 商家密码
        /// </summary>
        public string UserPassword
        {
            get
            {
                return this._userPassword;
            }
            set
            {
                this.PropChanged("UserPassword", this._userPassword, value);

                this._userPassword = value;
            }
        }


        #endregion

        #region 重载

        public override object PkValue
		{
			get
			{
				return this.Brand_Id; 
			}
		}

		public override string PkName
		{
			get
			{
				return "Brand_Id"; 
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
					
					_props.Add( "Brand_Id","Brand_Id");
					
					_props.Add( "Brand_Name","Brand_Name");
					
					_props.Add( "Brand_Logo","Brand_Logo");
					
					_props.Add( "Brand_Desc","Brand_Desc");
					
					_props.Add( "Site_Url","Site_Url");
					
					_props.Add( "Site_Short_Url","Site_Short_Url");
					
					_props.Add( "Sort_Order","Sort_Order");
					
					_props.Add( "Is_Show","Is_Show");
					
					_props.Add( "Is_Hot","Is_Hot");
					
					_props.Add( "Brand_Code","Brand_Code");
					
					_props.Add( "Create_By","Create_By");
					
					_props.Add( "Create_Time","Create_Time");
					
					_props.Add( "Modify_By","Modify_By");
					
					_props.Add( "Modify_Time","Modify_Time");
					
					_props.Add( "Brand_Phone","Brand_Phone");

                    _props.Add("UserAccount", "UserAccount");

                    _props.Add("UserPassword", "UserPassword");

                }
				return _props;			 
			 }
	    }

		public override CharmBusinessBrand GetEntityFromDataRow(DataRow row)
		{
			
if (row.Table.Columns.Contains("Brand_Id") && row["Brand_Id"] != null && row["Brand_Id"].ToString() != "")
			{
				this._brand_Id = new Guid(row["Brand_Id"].ToString());
			}
			if (row.Table.Columns.Contains("Brand_Name") && row["Brand_Name"] != null)
			{
				this._brand_Name = row["Brand_Name"].ToString();
			}
			if (row.Table.Columns.Contains("Brand_Logo") && row["Brand_Logo"] != null)
			{
				this._brand_Logo = row["Brand_Logo"].ToString();
			}
			if (row.Table.Columns.Contains("Brand_Desc") && row["Brand_Desc"] != null)
			{
				this._brand_Desc = row["Brand_Desc"].ToString();
			}
			if (row.Table.Columns.Contains("Site_Url") && row["Site_Url"] != null)
			{
				this._site_Url = row["Site_Url"].ToString();
			}
			if (row.Table.Columns.Contains("Site_Short_Url") && row["Site_Short_Url"] != null)
			{
				this._site_Short_Url = row["Site_Short_Url"].ToString();
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
			if (row.Table.Columns.Contains("Is_Hot") && row["Is_Hot"] != null && row["Is_Hot"].ToString() != "")
			{
				if ((row["Is_Hot"].ToString() == "1") || (row["Is_Hot"].ToString().ToLower() == "true"))
				{
					this._is_Hot = true;
				}
				else
				{
					this._is_Hot = false;
				}
			}
			if (row.Table.Columns.Contains("Brand_Code") && row["Brand_Code"] != null && row["Brand_Code"].ToString() != "")
			{
				this._brand_Code = int.Parse(row["Brand_Code"].ToString());
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
			if (row.Table.Columns.Contains("Brand_Phone") && row["Brand_Phone"] != null)
			{
				this._brand_Phone = row["Brand_Phone"].ToString();
			}
            if (row.Table.Columns.Contains("UserAccount") && row["UserAccount"] != null)
            {
                this._userAccount = row["UserAccount"].ToString();
            }
            if (row.Table.Columns.Contains("UserPassword") && row["UserPassword"] != null)
            {
                this._userPassword = row["UserPassword"].ToString();
            }
            return this;
		}

		public override CharmBusinessBrand GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);
				
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

if (name.ToLower() == "brand_logo" && !reader.IsDBNull(i))
{





_brand_Logo = reader.GetString(i);






 continue;
}

if (name.ToLower() == "brand_desc" && !reader.IsDBNull(i))
{





_brand_Desc = reader.GetString(i);






 continue;
}

if (name.ToLower() == "site_url" && !reader.IsDBNull(i))
{





_site_Url = reader.GetString(i);






 continue;
}

if (name.ToLower() == "site_short_url" && !reader.IsDBNull(i))
{





_site_Short_Url = reader.GetString(i);






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

if (name.ToLower() == "is_hot" && !reader.IsDBNull(i))
{

_is_Hot = reader.GetBoolean(i);










 continue;
}

if (name.ToLower() == "brand_code" && !reader.IsDBNull(i))
{









_brand_Code = reader.GetInt32(i);


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

if (name.ToLower() == "brand_phone" && !reader.IsDBNull(i))
{





_brand_Phone = reader.GetString(i);






 continue;
}
                if (name.ToLower() == "useraccount" && !reader.IsDBNull(i))
                {





                    _userAccount = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "userpassword" && !reader.IsDBNull(i))
                {





                    _userPassword = reader.GetString(i);






                    continue;
                }
            }
            return this;
        }

		public override string TableName
		{
			get
			{
				return "Charm_Business_Brand";
			}
		}

		public override IOctDbCommand GetInsertCmd()
		{
			
var sql = @"
				INSERT INTO Charm_Business_Brand (
					Brand_Id,
					Brand_Name,
					Brand_Logo,
					Brand_Desc,
					Site_Url,
					Site_Short_Url,
					Sort_Order,
					Is_Show,
					Is_Hot,
					Brand_Code,
					Create_By,
					Create_Time,
					Modify_By,
					Modify_Time,
					Brand_Phone,
                    UserAccount,
                    UserPassword)
				VALUES (
					@Brand_Id,
					@Brand_Name,
					@Brand_Logo,
					@Brand_Desc,
					@Site_Url,
					@Site_Short_Url,
					@Sort_Order,
					@Is_Show,
					@Is_Hot,
					@Brand_Code,
					@Create_By,
					@Create_Time,
					@Modify_By,
					@Modify_Time,
					@Brand_Phone,
                    @UserAccount,
                    @UserPassword)";
			
			DbCommand cmd = new SqlCommand();
			var parameters = new Dictionary<string, object> {
				{"@Brand_Id", this.Brand_Id},
				{"@Brand_Name", this.Brand_Name},
				{"@Brand_Logo", this.Brand_Logo},
				{"@Brand_Desc", this.Brand_Desc},
				{"@Site_Url", this.Site_Url},
				{"@Site_Short_Url", this.Site_Short_Url},
				{"@Sort_Order", this.Sort_Order},
				{"@Is_Show", this.Is_Show},
				{"@Is_Hot", this.Is_Hot},
				{"@Brand_Code", this.Brand_Code},
				{"@Create_By", this.Create_By},
				{"@Create_Time", this.Create_Time},
				{"@Modify_By", this.Modify_By},
				{"@Modify_Time", this.Modify_Time},
				{"@Brand_Phone", this.Brand_Phone},
                {"@UserAccount", this.UserAccount},
                {"@UserPassword", this.UserPassword}};

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
				sql +=  @where;

			return sql;
		}

		#endregion
	}
}