using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Role;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices
{
    public partial interface ICharm_CommonUserActionService
    {
        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<Charm_CommonUserAction> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<Charm_CommonUserAction> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);

        List<Charm_CommonUserAction> GetUserActions(string where, Dictionary<string, object> para, string order);

    }

    public partial class Charm_CommonUserActionService : ICharm_CommonUserActionService
    {

        public List<Charm_CommonUserAction> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.Charm_CommonUserActionContext.Query(@where, order, paras);
            }
        }

        public PageResult<Charm_CommonUserAction> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.Charm_CommonUserActionContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }


        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="where"></param>
        /// <param name="para"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public List<Charm_CommonUserAction> GetUserActions(string where, Dictionary<string, object> para, string order)
        {
            using (var context = new DbContext())
            {
                return context.Charm_CommonUserActionContext.Query(where, para, order);
            }
        }
    }
}
