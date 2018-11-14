using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmMstGoodsService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmMstGoods entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmMstGoods entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmMstGoods entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        bool Delete(Guid goods_id);

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
        /// <param name="goods_id"></param>
        /// <returns></returns>
        CharmMstGoods GetModel(Guid goods_id);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmMstGoods> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmMstGoods> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmMstGoodsService : ICharmMstGoodsService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmMstGoods entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmMstGoods entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmMstGoods entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        public bool Delete(Guid goods_id)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsContext.Delete(goods_id);
                
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
                context.CharmMstGoodsContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        public CharmMstGoods GetModel(Guid goods_id)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstGoodsContext.GetModel(goods_id);
            }
        }

        public List<CharmMstGoods> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstGoodsContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmMstGoods> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstGoodsContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
