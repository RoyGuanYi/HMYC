using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmMstCommentService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmMstComment entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmMstComment entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmMstComment entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="comment_Id"></param>
        /// <returns></returns>
        bool Delete(Guid comment_Id);

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
        /// <param name="comment_Id"></param>
        /// <returns></returns>
        CharmMstComment GetModel(Guid comment_Id);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmMstComment> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmMstComment> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmMstCommentService : ICharmMstCommentService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmMstComment entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCommentContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmMstComment entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCommentContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmMstComment entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCommentContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="comment_Id"></param>
        /// <returns></returns>
        public bool Delete(Guid comment_Id)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCommentContext.Delete(comment_Id);
                
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
                context.CharmMstCommentContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="comment_Id"></param>
        /// <returns></returns>
        public CharmMstComment GetModel(Guid comment_Id)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstCommentContext.GetModel(comment_Id);
            }
        }

        public List<CharmMstComment> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstCommentContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmMstComment> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstCommentContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
