using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.MvcExt.Extisions
{
    /// <summary>
    /// 视图显示扩展类
    /// </summary>
    public static class ViewDisplay
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value">布尔类型</param>
        /// <returns></returns>
        public static string GetText(this bool value)
        {
            return value ? "是" : "否";
        }

        /// <summary>
        /// 日期类型
        /// </summary>
        /// <param name="value">日期类型</param>
        /// <param name="isShowTimeValue">是否显示时间值（默认开启）</param>
        /// <returns></returns>
        public static string GetText(this DateTime value, bool isShowTimeValue = true)
        {
            if (value == DateTime.MinValue)
                return string.Empty;
            else
                return value.ToString(isShowTimeValue ? "yyyy-MM-dd HH:mm:ss" : "yyyy-MM-dd");
        }

        /// <summary>
        /// 安全返回值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">可空值</param>
        /// <returns></returns>
        public static T SafeValue<T>(this T? value) where T : struct
        {
            return value ?? default(T);
        }
    }
}
