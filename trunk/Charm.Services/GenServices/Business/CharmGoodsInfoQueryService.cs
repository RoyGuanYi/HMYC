using Charm.Entity;
using Charm.Entity.Business;
using Oct.Framework.DB.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Services.GenServices.Business
{
    public partial interface ICharmGoodsInfoQueryService
    {
       
        /// <summary>
        /// 通过条件获取对象 参数键为@拼接的参数，值为参数值
        /// </summary>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras">参数键为@拼接的参数，值为参数值</param>
        /// <returns></returns>
        List<CharmGoodsInfoQuery> GetModels(string where = "", string order = "", params object[] paras);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="where"></param>
        /// <param name="order"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        PageResult<CharmGoodsInfoQuery> GetModels(int pageIndex, int pageSize, string where, string order, params object[] paras);

        


        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        bool Delete(Guid goods_id);

        bool Add(CharmMstGoods goods,List<CharmMstGoodsImage> imgList);

        bool Update(CharmMstGoods goods, List<CharmMstGoodsImage> imgList);

    }

    public partial class CharmGoodsInfoQueryService : ICharmGoodsInfoQueryService
    {
      
        public List<CharmGoodsInfoQuery> GetModels(string @where = "", string order = "", params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmGoodsInfoQueryContext.Query(@where, order, paras);
            }
        }

        public PageResult<CharmGoodsInfoQuery> GetModels(int pageIndex, int pageSize, string @where, string order, params object[] paras)
        {
            using (var context = new DbContext())
            {
                return context.CharmGoodsInfoQueryContext.QueryPage(@where, order, pageIndex, pageSize, paras);
            }
        }



        /// <summary>
        /// 根据主键删除
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        public bool Delete(Guid goodsId)
        {
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@goodIds", goodsId); 
            using (var context = new DbContext())
            {
                context.CharmMstGoodsContext.Delete(goodsId);
                context.CharmMstGoodsImageContext.Delete(" AND  Goods_Id=@goodIds", paras);
                return context.SaveChanges() > 0;
            }
        }

        public bool Add(CharmMstGoods goods, List<CharmMstGoodsImage> imgList)
        {
            using (var context = new DbContext())
            {
                context.CharmMstGoodsContext.Add(goods);
                if (imgList!=null&& imgList.Count>0)
                {
                    foreach (var item in imgList)
                    {
                        context.CharmMstGoodsImageContext.Add(item);
                    }
                }
                return context.SaveChanges() > 0;
            }
        }

        public bool Update(CharmMstGoods goods, List<CharmMstGoodsImage> imgList)
        {
            using (var context = new DbContext())
            {

                Dictionary<string, object> paras = new Dictionary<string, object>();
                paras.Add("@goodIds", goods.Goods_id);
                context.CharmMstGoodsImageContext.Delete(" AND Goods_Id=@goodIds", paras);
                context.CharmMstGoodsContext.Update(goods);
                if (imgList != null && imgList.Count > 0)
                {
                    foreach (var item in imgList)
                    {
                        context.CharmMstGoodsImageContext.Add(item);
                    }
                }
                return context.SaveChanges() > 0;
            }
        }
    }

}
