﻿using System;
using System.Collections.Generic;
using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmBusinessBrandService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Add(CharmBusinessBrand entity);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Modify(CharmBusinessBrand entity);

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(CharmBusinessBrand entity);

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="brand_Id"></param>
        /// <returns></returns>
        bool Delete(Guid brand_Id);

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
        /// <param name="brand_Id"></param>
        /// <returns></returns>
        CharmBusinessBrand GetModel(Guid brand_Id);


        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmBusinessBrand> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmBusinessBrand> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);
    }

    public partial class CharmBusinessBrandService : ICharmBusinessBrandService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(CharmBusinessBrand entity)
        {
            using (var context = new DbContext())
            {
                context.CharmBusinessBrandContext.Add(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Modify(CharmBusinessBrand entity)
        {
            using (var context = new DbContext())
            {
                context.CharmBusinessBrandContext.Update(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据一个实体对象删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(CharmBusinessBrand entity)
        {
            using (var context = new DbContext())
            {
                context.CharmBusinessBrandContext.Delete(entity);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="brand_Id"></param>
        /// <returns></returns>
        public bool Delete(Guid brand_Id)
        {
            using (var context = new DbContext())
            {
                context.CharmBusinessBrandContext.Delete(brand_Id);
                
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
                context.CharmBusinessBrandContext.Delete(@where, paras);
                
                return context.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// 通过主键获取一个对象
        /// </summary>
        /// <param name="brand_Id"></param>
        /// <returns></returns>
        public CharmBusinessBrand GetModel(Guid brand_Id)
        {
            using (var context = new DbContext())
            {
                return context.CharmBusinessBrandContext.GetModel(brand_Id);
            }
        }

        public List<CharmBusinessBrand> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmBusinessBrandContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmBusinessBrand> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmBusinessBrandContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }
    }
}