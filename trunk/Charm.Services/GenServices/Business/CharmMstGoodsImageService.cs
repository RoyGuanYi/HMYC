using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmMstGoodsImageService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmMstGoodsImage entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmMstGoodsImage entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmMstGoodsImage entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="goods_Image_Id"></param>
        /// <returns></returns>
        bool Delete(Guid goods_Image_Id);

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
        /// <param name="goods_Image_Id"></param>
        /// <returns></returns>
        CharmMstGoodsImage GetModel(Guid goods_Image_Id);

        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmMstGoodsImage> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmMstGoodsImage> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmMstGoodsImageService : ICharmMstGoodsImageService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmMstGoodsImage entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsImageContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmMstGoodsImage entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsImageContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmMstGoodsImage entity)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsImageContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="goods_Image_Id"></param>
        /// <returns></returns>
        public bool Delete(Guid goods_Image_Id)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsImageContext.Delete(goods_Image_Id);
                
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
                context.CharmMstGoodsImageContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="goods_Image_Id"></param>
        /// <returns></returns>
        public CharmMstGoodsImage GetModel(Guid goods_Image_Id)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstGoodsImageContext.GetModel(goods_Image_Id);
            }
        }

        public List<CharmMstGoodsImage> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstGoodsImageContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmMstGoodsImage> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmMstGoodsImageContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}
