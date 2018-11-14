using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmMstCategoryService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmMstCategory entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmMstCategory entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmMstCategory entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="category_Id"></param>
        /// <returns></returns>
        bool Delete(int category_Id);

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
        /// <param name="category_Id"></param>
        /// <returns></returns>
        CharmMstCategory GetModel(int category_Id);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmMstCategory> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmMstCategory> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmMstCategoryService : ICharmMstCategoryService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmMstCategory entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCategoryContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmMstCategory entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCategoryContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmMstCategory entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCategoryContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="category_Id"></param>
        /// <returns></returns>
        public bool Delete(int category_Id)
        {
            using (var context = new DbContext())
            {
                context.CharmMstCategoryContext.Delete(category_Id);
                
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
                context.CharmMstCategoryContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="category_Id"></param>
        /// <returns></returns>
        public CharmMstCategory GetModel(int category_Id)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstCategoryContext.GetModel(category_Id);
            }
        }

        public List<CharmMstCategory> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
             {
                return context.CharmMstCategoryContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmMstCategory> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstCategoryContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
