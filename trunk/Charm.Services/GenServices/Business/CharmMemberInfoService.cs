using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmMemberInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmMemberInfo entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmMemberInfo entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmMemberInfo entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="member_Id"></param>
        /// <returns></returns>
        bool Delete(Guid member_Id);

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
        /// <param name="member_Id"></param>
        /// <returns></returns>
        CharmMemberInfo GetModel(Guid member_Id);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmMemberInfo> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmMemberInfo> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmMemberInfoService : ICharmMemberInfoService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmMemberInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMemberInfoContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmMemberInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMemberInfoContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmMemberInfo entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMemberInfoContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="member_Id"></param>
        /// <returns></returns>
        public bool Delete(Guid member_Id)
        {
            using (var context = new DbContext())
            {
                context.CharmMemberInfoContext.Delete(member_Id);
                
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
                context.CharmMemberInfoContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="member_Id"></param>
        /// <returns></returns>
        public CharmMemberInfo GetModel(Guid member_Id)
        {
            using (var context = new DbContext())
            {
                return context.CharmMemberInfoContext.GetModel(member_Id);
            }
        }

        public List<CharmMemberInfo> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMemberInfoContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmMemberInfo> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMemberInfoContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
