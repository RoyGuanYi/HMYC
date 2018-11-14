using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Role;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices
{
    public partial interface ICharmCommonActionInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmCommonActionInfo entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmCommonActionInfo entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmCommonActionInfo entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="actionId"></param>
        /// <returns></returns>
        bool Delete(Guid actionId);

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
        /// <param name="actionId"></param>
        /// <returns></returns>
        CharmCommonActionInfo GetModel(Guid actionId);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmCommonActionInfo> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmCommonActionInfo> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmCommonActionInfoService : ICharmCommonActionInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmCommonActionInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonActionInfoContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmCommonActionInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonActionInfoContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmCommonActionInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonActionInfoContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="actionId"></param>
        /// <returns></returns>
        public bool Delete(Guid actionId)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonActionInfoContext.Delete(actionId);
                
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
                context.CharmCommonActionInfoContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="actionId"></param>
        /// <returns></returns>
        public CharmCommonActionInfo GetModel(Guid actionId)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonActionInfoContext.GetModel(actionId);
            }
        }

        public List<CharmCommonActionInfo> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonActionInfoContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmCommonActionInfo> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonActionInfoContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
