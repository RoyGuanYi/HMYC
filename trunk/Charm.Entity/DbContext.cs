using Charm.Entity.Business;
using Charm.Entity.Role;
using Oct.Framework.DB.Core;
using Oct.Framework.DB.Implementation;
using Oct.Framework.DB.Interface;

namespace Charm.Entity
{
    public class DbContext:DBContextBase
    {
        public DbContext()
            : base()
        {

        }

        public DbContext(string connectionString)
            : base(connectionString)
        {

        }

        public DbContext(DBOperationType dbType)
            : base(dbType)
        {

        }
        //DBContext

        #region Role
        public IDBContext<CharmCommonActionInfo> CharmCommonActionInfoContext
        {
            get
            {
                return new SQLDBContext<CharmCommonActionInfo>(Session);
            }
        }


        public IDBContext<CharmCommonMenuInfo> CharmCommonMenuInfoContext
        {
            get
            {
                return new SQLDBContext<CharmCommonMenuInfo>(Session);
            }
        }


        public IDBContext<CharmCommonRoleAction> CharmCommonRoleActionContext
        {
            get
            {
                return new SQLDBContext<CharmCommonRoleAction>(Session);
            }
        }


        public IDBContext<CharmCommonRoleInfo> CharmCommonRoleInfoContext
        {
            get
            {
                return new SQLDBContext<CharmCommonRoleInfo>(Session);
            }
        }


        public IDBContext<CharmCommonUserInfo> CharmCommonUserInfoContext
        {
            get
            {
                return new SQLDBContext<CharmCommonUserInfo>(Session);
            }
        }


        public IDBContext<CharmCommonUserRole> CharmCommonUserRoleContext
        {
            get
            {
                return new SQLDBContext<CharmCommonUserRole>(Session);
            }
        }

        public IDBContext<Charm_CommonUserAction> Charm_CommonUserActionContext
        {
            get
            {
                return new SQLDBContext<Charm_CommonUserAction>(Session);
            }
        }
        #endregion

        public IDBContext<CharmArticle> CharmArticleContext
        {
            get
            {
                return new SQLDBContext<CharmArticle>(Session);
            }
        }


        public IDBContext<CharmBusinessBrand> CharmBusinessBrandContext
        {
            get
            {
                return new SQLDBContext<CharmBusinessBrand>(Session);
            }
        }


        public IDBContext<CharmMemberInfo> CharmMemberInfoContext
        {
            get
            {
                return new SQLDBContext<CharmMemberInfo>(Session);
            }
        }


        public IDBContext<CharmMstCategory> CharmMstCategoryContext
        {
            get
            {
                return new SQLDBContext<CharmMstCategory>(Session);
            }
        }


        public IDBContext<CharmMstComment> CharmMstCommentContext
        {
            get
            {
                return new SQLDBContext<CharmMstComment>(Session);
            }
        }


        public IDBContext<CharmMstFeedback> CharmMstFeedbackContext
        {
            get
            {
                return new SQLDBContext<CharmMstFeedback>(Session);
            }
        }


        public IDBContext<CharmMstGoods> CharmMstGoodsContext
        {
            get
            {
                return new SQLDBContext<CharmMstGoods>(Session);
            }
        }


        public IDBContext<CharmMstGoodsImage> CharmMstGoodsImageContext
        {
            get
            {
                return new SQLDBContext<CharmMstGoodsImage>(Session);
            }
        }
        public IDBContext<CharmGoodsInfoQuery> CharmGoodsInfoQueryContext
        {
            get
            {
                return new SQLDBContext<CharmGoodsInfoQuery>(Session);
            }
        }
    }
}
