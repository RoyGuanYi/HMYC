using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Role;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices
{
    public partial interface ICharmCommonUserInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmCommonUserInfo entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmCommonUserInfo entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmCommonUserInfo entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool Delete(Guid userId);

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
        /// <param name="userId"></param>
        /// <returns></returns>
        CharmCommonUserInfo GetModel(Guid userId);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmCommonUserInfo> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmCommonUserInfo> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmCommonUserInfoService : ICharmCommonUserInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmCommonUserInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserInfoContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmCommonUserInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserInfoContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmCommonUserInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserInfoContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Delete(Guid userId)
        {
            using (var context = new DbContext())
            {
                context.CharmCommonUserInfoContext.Delete(userId);
                
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
                context.CharmCommonUserInfoContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public CharmCommonUserInfo GetModel(Guid userId)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonUserInfoContext.GetModel(userId);
            }
        }

        public List<CharmCommonUserInfo> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonUserInfoContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmCommonUserInfo> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmCommonUserInfoContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
