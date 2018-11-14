using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Role;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices
{
    public partial interface ICharmCommonMenuInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmCommonMenuInfo entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmCommonMenuInfo entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmCommonMenuInfo entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        bool Delete(Guid menuId);

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
        /// <param name="menuId"></param>
        /// <returns></returns>
        CharmCommonMenuInfo GetModel(Guid menuId);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmCommonMenuInfo> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmCommonMenuInfo> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmCommonMenuInfoService : ICharmCommonMenuInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmCommonMenuInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonMenuInfoContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmCommonMenuInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonMenuInfoContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmCommonMenuInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonMenuInfoContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public bool Delete(Guid menuId)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonMenuInfoContext.Delete(menuId);
                
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
                context.CharmCommonMenuInfoContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        public CharmCommonMenuInfo GetModel(Guid menuId)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonMenuInfoContext.GetModel(menuId);
            }
        }

        public List<CharmCommonMenuInfo> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonMenuInfoContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmCommonMenuInfo> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonMenuInfoContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
