using System;
using System.Collections.Generic;
using System.Data;
using Oct.Framework.DB.Base;

namespace Charm.Entity.Role
{
    [Serializable]
    public partial class Charm_CommonUserAction : BaseEntity<Charm_CommonUserAction>
    {
        #region	属性


        public string MenuName
        {
            get;
            set;
        }


        public string ActionCategoryName
        {
            get;
            set;
        }


        public string ActionName
        {
            get;
            set;
        }


        public string ActionUrl
        {
            get;
            set;
        }


        public bool IsLog
        {
            get;
            set;
        }


        public bool IsVisible
        {
            get;
            set;
        }


        public int Operation
        {
            get;
            set;
        }


        public int Sort
        {
            get;
            set;
        }


        public int msort
        {
            get;
            set;
        }


        #endregion

        #region 重载

        public override Charm_CommonUserAction GetEntityFromDataRow(DataRow row)
        {

            if (row.Table.Columns.Contains("MenuName") && row["MenuName"] != null)
            {
                this.MenuName = row["MenuName"].ToString();
            }
            if (row.Table.Columns.Contains("ActionCategoryName") && row["ActionCategoryName"] != null)
            {
                this.ActionCategoryName = row["ActionCategoryName"].ToString();
            }
            if (row.Table.Columns.Contains("ActionName") && row["ActionName"] != null)
            {
                this.ActionName = row["ActionName"].ToString();
            }
            if (row.Table.Columns.Contains("ActionUrl") && row["ActionUrl"] != null)
            {
                this.ActionUrl = row["ActionUrl"].ToString();
            }
            if (row.Table.Columns.Contains("IsLog") && row["IsLog"] != null && row["IsLog"].ToString() != "")
            {
                if ((row["IsLog"].ToString() == "1") || (row["IsLog"].ToString().ToLower() == "true"))
                {
                    this.IsLog = true;
                }
                else
                {
                    this.IsLog = false;
                }
            }
            if (row.Table.Columns.Contains("IsVisible") && row["IsVisible"] != null && row["IsVisible"].ToString() != "")
            {
                if ((row["IsVisible"].ToString() == "1") || (row["IsVisible"].ToString().ToLower() == "true"))
                {
                    this.IsVisible = true;
                }
                else
                {
                    this.IsVisible = false;
                }
            }
            if (row.Table.Columns.Contains("Operation") && row["Operation"] != null && row["Operation"].ToString() != "")
            {
                this.Operation = int.Parse(row["Operation"].ToString());
            }
            if (row.Table.Columns.Contains("Sort") && row["Sort"] != null && row["Sort"].ToString() != "")
            {
                this.Sort = int.Parse(row["Sort"].ToString());
            }
            if (row.Table.Columns.Contains("msort") && row["msort"] != null && row["msort"].ToString() != "")
            {
                this.msort = int.Parse(row["msort"].ToString());
            }

            return this;
        }

        public override Charm_CommonUserAction GetEntityFromDataReader(IDataReader reader)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var name = reader.GetName(i);

                if (name.ToLower() == "menuname" && !reader.IsDBNull(i))
                {





                    MenuName = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "actioncategoryname" && !reader.IsDBNull(i))
                {





                    ActionCategoryName = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "actionname" && !reader.IsDBNull(i))
                {





                    ActionName = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "actionurl" && !reader.IsDBNull(i))
                {





                    ActionUrl = reader.GetString(i);






                    continue;
                }

                if (name.ToLower() == "islog" && !reader.IsDBNull(i))
                {

                    IsLog = reader.GetBoolean(i);










                    continue;
                }

                if (name.ToLower() == "isvisible" && !reader.IsDBNull(i))
                {

                    IsVisible = reader.GetBoolean(i);










                    continue;
                }

                if (name.ToLower() == "operation" && !reader.IsDBNull(i))
                {









                    Operation = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "sort" && !reader.IsDBNull(i))
                {









                    Sort = reader.GetInt32(i);


                    continue;
                }

                if (name.ToLower() == "msort" && !reader.IsDBNull(i))
                {









                    msort = reader.GetInt32(i);


                    continue;
                }

            }
            return this;
        }

        public override string TableName
        {
            get
            {
                return "Charm_CommonUserAction";
            }
        }

        public override bool IsIdentityPk
        {
            get { return false; }
        }




        public override string PkName
        {
            get
            {
                return "";
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

                    _props.Add("MenuName", "MenuName");

                    _props.Add("ActionCategoryName", "ActionCategoryName");

                    _props.Add("ActionName", "ActionName");

                    _props.Add("ActionUrl", "ActionUrl");

                    _props.Add("IsLog", "IsLog");

                    _props.Add("IsVisible", "IsVisible");

                    _props.Add("Operation", "Operation");

                    _props.Add("Sort", "Sort");

                    _props.Add("msort", "msort");

                }
                return _props;
            }
        }

        public override string GetQuerySQL(string @where = "")
        {
            var sql = @"select distinct 
	m.MenuName,
	a.ActionCategoryName,
	a.ActionName,
	a.ActionUrl, 
	a.IsLog, 
	a.IsVisible, 
	a.Operation, 
	a.Sort,m.Sort as msort
from 
Charm_Common_UserRole ur
	inner join Charm_Common_RoleAction ra on ur.RoleId = ra.RoleId
	inner join Charm_Common_ActionInfo a on ra.ActionId = a.ActionId
	inner join Charm_Common_MenuInfo m on a.MenuId = m.MenuId
where m.IsEnable = 'true'
	and a.IsEnable = 'true'";

            if (!string.IsNullOrEmpty(@where))
                sql +=  @where;

            return sql;
        }

        #endregion
    }
}