using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Role;
using Oct.Framework.DB.Core;

namespace Charm.Services
{
    public partial interface ICharmCommonRoleActionService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmCommonRoleAction entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmCommonRoleAction entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmCommonRoleAction entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="roleActionId"></param>
        /// <returns></returns>
        bool Delete(Guid roleActionId);

        /// <summary>
        /// 根据条件删除 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        bool Delete(string where, IDictionary<string, object> paras);

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="roleActionId"></param>
        /// <returns></returns>
        CharmCommonRoleAction GetModel(Guid roleActionId);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmCommonRoleAction> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmCommonRoleAction> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmCommonRoleActionService : ICharmCommonRoleActionService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmCommonRoleAction entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonRoleActionContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmCommonRoleAction entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonRoleActionContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmCommonRoleAction entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonRoleActionContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="roleActionId"></param>
        /// <returns></returns>
        public bool Delete(Guid roleActionId)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonRoleActionContext.Delete(roleActionId);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据条件删除 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        public bool Delete(string @where, IDictionary<string, object> paras)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonRoleActionContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="roleActionId"></param>
        /// <returns></returns>
        public CharmCommonRoleAction GetModel(Guid roleActionId)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonRoleActionContext.GetModel(roleActionId);
            }
        }

        public List<CharmCommonRoleAction> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonRoleActionContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmCommonRoleAction> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonRoleActionContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
