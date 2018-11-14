using Oct.Framework.DB.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Entity.Business
{
    [Serializable]
    public partial class CharmGoodsInfoQuery : BaseEntity<CharmGoodsInfoQuery>
    {
        #region	属性


        public Guid Goods_id
        {
            get;
            set;
        }


        public string Goods_Name
        {
            get;
            set;
        }


        public int Click_Count
        {
            get;
            set;
        }


        public decimal Market_Price
        {
            get;
            set;
        }


        public decimal Shop_Price
        {
            get;
            set;
        }


        public string Goods_Keywords
        {
            get;
            set;
        }


        public string Goods_Brief
        {
            get;
            set;
        }


        public string Goods_Desc
        {
            get;
            set;
        }


        public string Goods_Thumb_Img
        {
            get;
            set;
        }


        public string Goods_Real_Img
        {
            get;
            set;
        }


        public string Goods_Original_Img
        {
            get;
            set;
        }


        public bool Is_Real_Goods
        {
            get;
            set;
        }


        public bool Is_OnSale
        {
            get;
            set;
        }


        public int Sort_Order
        {
            get;
            set;
        }


        public string Create_By
        {
            get;
            set;
        }


        public DateTime Create_Time
        {
            get;
            set;
        }


        public string Modify_By
        {
            get;
            set;
        }


        public DateTime Modify_Time
        {
            get;
            set;
        }


        public string Modify_By_Admin
        {
            get;
            set;
        }


        public DateTime Modify_Time_Admin
        {
            get;
            set;
        }


        public int Category_Id
        {
            get;
            set;
        }


        public Guid Brand_Id
        {
            get;
            set;
        }


        public int Collection_Count
        {
            get;
            set;
        }


        public string Brand_Name
        {
            get;
            set;
        }


        public string Category_Name
        {
            get;
            set;
        }


        public string Brand_Logo
        {
            get;
            set;
        }

        #endregion

        #region 重载

        public override CharmGoodsInfoQuery GetEntityFromDataRow(DataRow row)
        {

            if (row.Table.Columns.Contains("Goods_id") && row["Goods_id"] != null && row["Goods_id"].ToString() != "")
            {
                this.Goods_id = new Guid(row["Goods_id"].ToString());
            }
            if (row.Table.Columns.Contains("Goods_Name") && row["Goods_Name"] != null)
            {
                this.Goods_Name = row["Goods_Name"].ToString();
            }
            if (row.Table.Columns.Contains("Click_Count") && row["Click_Count"] != null && row["Click_Count"].ToString() != "")
            {
                this.Click_Count = int.Parse(row["Click_Count"].ToString());
            }
            if (row.Table.Columns.Contains("Market_Price") && row["Market_Price"] != null && row["Market_Price"].ToString() != "")
            {
                this.Market_Price = decimal.Parse(row["Market_Price"].ToString());
            }
            if (row.Table.Columns.Contains("Shop_Price") && row["Shop_Price"] != null && row["Shop_Price"].ToString() != "")
            {
                this.Shop_Price = decimal.Parse(row["Shop_Price"].ToString());
            }
            if (row.Table.Columns.Contains("Goods_Keywords") && row["Goods_Keywords"] != null)
            {
                this.Goods_Keywords = row["Goods_Keywords"].ToString();
            }
            if (row.Table.Columns.Contains("Goods_Brief") && row["Goods_Brief"] != null)
            {
                this.Goods_Brief = row["Goods_Brief"].ToString();
            }
            if (row.Table.Columns.Contains("Goods_Desc") && row["Goods_Desc"] != null)
            {
                this.Goods_Desc = row["Goods_Desc"].ToString();
            }
            if (row.Table.Columns.Contains("Goods_Thumb_Img") && row["Goods_Thumb_Img"] != null)
            {
                this.Goods_Thumb_Img = row["Goods_Thumb_Img"].ToString();
            }
            if (row.Table.Columns.Contains("Goods_Real_Img") && row["Goods_Real_Img"] != null)
            {
                this.Goods_Real_Img = row["Goods_Real_Img"].ToString();
            }
            if (row.Table.Columns.Contains("Goods_Original_Img") && row["Goods_Original_Img"] != null)
            {
                this.Goods_Original_Img = row["Goods_Original_Img"].ToString();
            }
            if (row.Table.Columns.Contains("Is_Real_Goods") && row["Is_Real_Goods"] != null && row["Is_Real_Goods"].ToString() != "")
            {
                if ((row["Is_Real_Goods"].ToString() == "1") || (row["Is_Real_Goods"].ToString().ToLower() == "true"))
                {
                    this.Is_Real_Goods = true;
                }
                else
                {
                    this.Is_Real_Goods = false;
                }
            }
            if (row.Table.Columns.Contains("Is_OnSale") && row["Is_OnSale"] != null && row["Is_OnSale"].ToString() != "")
            {
                if ((row["Is_OnSale"].ToString() == "1") || (row["Is_OnSale"].ToString().ToLower() == "true"))
                {
                    this.Is_OnSale = true;
                }
                else
                {
                    this.Is_OnSale = false;
                }
            }
            if (row.Table.Columns.Contains("Sort_Order") && row["Sort_Order"] != null && row["Sort_Order"].ToString() != "")
            {
                this.Sort_Order = int.Parse(row["Sort_Order"].ToString());
            }
            if (row.Table.Columns.Contains("Create_By") && row["Create_By"] != null)
            {
                this.Create_By = row["Create_By"].ToString();
            }
            if (row.Table.Columns.Contains("Create_Time") && row["Create_Time"] != null && row["Create_Time"].ToString() != "")
            {
                this.Create_Time = DateTime.Parse(row["Create_Time"].ToString());
            }
            if (row.Table.Columns.Contains("Modify_By") && row["Modify_By"] != null)
            {
                this.Modify_By = row["Modify_By"].ToString();
            }
            if (row.Table.Columns.Contains("Modify_Time") && row["Modify_Time"] != null && row["Modify_Time"].ToString() != "")
            {
                this.Modify_Time = DateTime.Parse(row["Modify_Time"].ToString());
            }
            if (row.Table.Columns.Contains("Modify_By_Admin") && row["Modify_By_Admin"] != null)
            {
                this.Modify_By_Admin = row["Modify_By_Admin"].ToString();
            }
            if (row.Table.Columns.Contains("Modify_Time_Admin") && row["Modify_Time_Admin"] != null && row["Modify_Time_Admin"].ToString() != "")
            {
                this.Modify_Time_Admin = DateTime.Parse(row["Modify_Time_Admin"].ToString());
            }
            if (row.Table.Columns.Contains("Category_Id") && row["Category_Id"] != null && row["Category_Id"].ToString() != "")
            {
                this.Category_Id = int.Parse(row["Category_Id"].ToString());
            }
            if (row.Table.Columns.Contains("Brand_Id") && row["Brand_Id"] != null && row["Brand_Id"].ToString() != "")
            {
                this.Brand_Id = new Guid(row["Brand_Id"].ToString());
            }
            if (row.Table.Columns.Contains("Collection_Count") && row["Collection_Count"] != null && row["Collection_Count"].ToString() != "")
            {
                this.Collection_Count = int.Parse(row["Collection_Count"].ToString());
            }
            if (row.Table.Columns.Contains("Brand_Name") && row["Brand_Name"] != null)
            {
                this.Brand_Name = row["Brand_Name"].ToString();
            }
            if (row.Table.Columns.Contains("Category_Name") && row["Category_Name"] != null)
            {
                this.Category_Name = row["Category_Name"].ToString();
            }

            return this;
        }

        public override CharmGoodsInfoQuery GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);

                if (name.ToLower() == "goods_id" && !reader.IsDBNull(i))
                {




                    Goods_id = reader.GetGuid(i);







                    continue;
                }

                if (name.ToLower() == "goods_name" && !reader.IsDBNull(i))
                {





                    Goods_Name = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "click_count" && !reader.IsDBNull(i))
                {









                    Click_Count = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "market_price" && !reader.IsDBNull(i))
                {






                    Market_Price = reader.GetDecimal(i);





                    continue;
                }

                if (name.ToLower() == "shop_price" && !reader.IsDBNull(i))
                {






                    Shop_Price = reader.GetDecimal(i);





                    continue;
                }

                if (name.ToLower() == "goods_keywords" && !reader.IsDBNull(i))
                {





                    Goods_Keywords = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "goods_brief" && !reader.IsDBNull(i))
                {





                    Goods_Brief = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "goods_desc" && !reader.IsDBNull(i))
                {





                    Goods_Desc = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "goods_thumb_img" && !reader.IsDBNull(i))
                {





                    Goods_Thumb_Img = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "goods_real_img" && !reader.IsDBNull(i))
                {





                    Goods_Real_Img = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "goods_original_img" && !reader.IsDBNull(i))
                {





                    Goods_Original_Img = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "is_real_goods" && !reader.IsDBNull(i))
                {

                    Is_Real_Goods = reader.GetBoolean(i);










                    continue;
                }

                if (name.ToLower() == "is_onsale" && !reader.IsDBNull(i))
                {

                    Is_OnSale = reader.GetBoolean(i);










                    continue;
                }

                if (name.ToLower() == "sort_order" && !reader.IsDBNull(i))
                {









                    Sort_Order = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "create_by" && !reader.IsDBNull(i))
                {





                    Create_By = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "create_time" && !reader.IsDBNull(i))
                {



                    Create_Time = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "modify_by" && !reader.IsDBNull(i))
                {





                    Modify_By = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "modify_time" && !reader.IsDBNull(i))
                {



                    Modify_Time = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "modify_by_admin" && !reader.IsDBNull(i))
                {





                    Modify_By_Admin = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "modify_time_admin" && !reader.IsDBNull(i))
                {



                    Modify_Time_Admin = reader.GetDateTime(i);








                    continue;
                }

                if (name.ToLower() == "category_id" && !reader.IsDBNull(i))
                {









                    Category_Id = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "brand_id" && !reader.IsDBNull(i))
                {




                    Brand_Id = reader.GetGuid(i);







                    continue;
                }

                if (name.ToLower() == "collection_count" && !reader.IsDBNull(i))
                {









                    Collection_Count = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "brand_name" && !reader.IsDBNull(i))
                {





                    Brand_Name = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "category_name" && !reader.IsDBNull(i))
                {





                    Category_Name = reader.GetString(i);






                    continue;
                }
                if (name.ToLower() == "brand_logo" && !reader.IsDBNull(i))
                {





                    Brand_Logo = reader.GetString(i);






                    continue;
                }
            }
            return this;
        }

        public override string TableName
        {
            get
            {
                return "CharmGoodsInfoQuery";
            }
        }

        public override bool IsIdentityPk
        {
            get { return false; }
        }





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

        private Dictionary<string, string> _props;

        public override Dictionary<string, string> Props
        {
            get
            {
                if (_props == null)
                {
                    _props = new Dictionary<string, string>();

                    _props.Add("Goods_id", "Goods_id");

                    _props.Add("Goods_Name", "Goods_Name");

                    _props.Add("Click_Count", "Click_Count");

                    _props.Add("Market_Price", "Market_Price");

                    _props.Add("Shop_Price", "Shop_Price");

                    _props.Add("Goods_Keywords", "Goods_Keywords");

                    _props.Add("Goods_Brief", "Goods_Brief");

                    _props.Add("Goods_Desc", "Goods_Desc");

                    _props.Add("Goods_Thumb_Img", "Goods_Thumb_Img");

                    _props.Add("Goods_Real_Img", "Goods_Real_Img");

                    _props.Add("Goods_Original_Img", "Goods_Original_Img");

                    _props.Add("Is_Real_Goods", "Is_Real_Goods");

                    _props.Add("Is_OnSale", "Is_OnSale");

                    _props.Add("Sort_Order", "Sort_Order");

                    _props.Add("Create_By", "Create_By");

                    _props.Add("Create_Time", "Create_Time");

                    _props.Add("Modify_By", "Modify_By");

                    _props.Add("Modify_Time", "Modify_Time");

                    _props.Add("Modify_By_Admin", "Modify_By_Admin");

                    _props.Add("Modify_Time_Admin", "Modify_Time_Admin");

                    _props.Add("Category_Id", "Category_Id");

                    _props.Add("Brand_Id", "Brand_Id");

                    _props.Add("Collection_Count", "Collection_Count");

                    _props.Add("Brand_Name", "Brand_Name");

                    _props.Add("Category_Name", "Category_Name");

                    _props.Add("Brand_Logo", "Brand_Logo");
                }
                return _props;
            }
        }

        public override string GetQuerySQL(string @where = "")
        {
            var sql = @"select good.*,brand.Brand_Name,category.Category_Name,brand.Brand_Logo from Charm_Mst_Goods good 
inner join Charm_Business_Brand brand on good.Brand_Id=brand.Brand_Id
inner join Charm_Mst_Category category on good.Category_Id=category.Category_Id where 1=1 and category.Is_Show=1 and brand.Is_Show=1  ";

            if (!string.IsNullOrEmpty(@where))
                sql +=  @where;

            return sql;
        }

        #endregion
    }

}
