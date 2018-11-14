using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmArticleService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmArticle entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmArticle entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmArticle entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="article_Id"></param>
        /// <returns></returns>
        bool Delete(Guid article_Id);

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
        /// <param name="article_Id"></param>
        /// <returns></returns>
        CharmArticle GetModel(Guid article_Id);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmArticle> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmArticle> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmArticleService : ICharmArticleService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmArticle entity)
        {
            using (var context = new DbContext())
            {
                context.CharmArticleContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmArticle entity)
        {
            using (var context = new DbContext())
            {
                context.CharmArticleContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmArticle entity)
        {
            using (var context = new DbContext())
            {
                context.CharmArticleContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="article_Id"></param>
        /// <returns></returns>
        public bool Delete(Guid article_Id)
        {
            using (var context = new DbContext())
            {
                context.CharmArticleContext.Delete(article_Id);
                
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
                context.CharmArticleContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="article_Id"></param>
        /// <returns></returns>
        public CharmArticle GetModel(Guid article_Id)
        {
            using (var context = new DbContext())
            {
                return context.CharmArticleContext.GetModel(article_Id);
            }
        }

        public List<CharmArticle> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmArticleContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmArticle> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmArticleContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
