using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Role;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices
{
    public partial interface ICharmCommonUserRoleService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmCommonUserRole entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmCommonUserRole entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmCommonUserRole entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="userRoleId"></param>
        /// <returns></returns>
        bool Delete(Guid userRoleId);

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
        /// <param name="userRoleId"></param>
        /// <returns></returns>
        CharmCommonUserRole GetModel(Guid userRoleId);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmCommonUserRole> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmCommonUserRole> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmCommonUserRoleService : ICharmCommonUserRoleService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmCommonUserRole entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserRoleContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmCommonUserRole entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserRoleContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmCommonUserRole entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserRoleContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="userRoleId"></param>
        /// <returns></returns>
        public bool Delete(Guid userRoleId)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserRoleContext.Delete(userRoleId);
                
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
                context.CharmCommonUserRoleContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="userRoleId"></param>
        /// <returns></returns>
        public CharmCommonUserRole GetModel(Guid userRoleId)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonUserRoleContext.GetModel(userRoleId);
            }
        }

        public List<CharmCommonUserRole> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonUserRoleContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmCommonUserRole> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonUserRoleContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
