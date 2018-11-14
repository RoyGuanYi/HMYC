using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace Charm.Common.Enum
{
    public class EnumOperate
    {
        /// <summary>
        /// 获取枚举的描述信息
        /// </summary>
        /// <param name="e">传入枚举对象</param>
        /// <returns>得到对应描述信息</returns>
        public static String GetEnumDesc(System.Enum e)
        {
            var enumInfo = e.GetType().GetField(e.ToString());
            var enumAttributes = (DescriptionAttribute[])enumInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return enumAttributes.Length > 0 ? enumAttributes[0].Description : e.ToString();
        }

        /// <summary>
        /// 获取枚举的描述信息，泛型方法
        /// </summary>
        /// <typeparam name="T">任意枚举类型</typeparam>
        /// <param name="t">传入枚举泛型</param>
        /// <returns>得到对应描述</returns>
        public static string GetEnumDesc<T>(T t)
        {
            var enumInfo = t.GetType().GetField(t.ToString());
            if (enumInfo == null)
            {
                return null;
            }
            var enumAttributes = (DescriptionAttribute[])enumInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return enumAttributes.Length > 0 ? enumAttributes[0].Description : t.ToString();
        }

        /// <summary>
        /// 将指定枚举类型转换成List，用来绑定ListControl
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="selectFeild">默认选择的项的值</param>
        /// <returns></returns>
        public static IEnumerable<SelectListItem> ConvertEnumToListItems(Type enumType, string selectFeild)
        {
            if (enumType.IsEnum == false) { yield return null; }
            var typeDescription = typeof(DescriptionAttribute);
            var fields = enumType.GetFields();
            foreach (var field in fields.Where(field => !field.IsSpecialName))
            {
                var strValue = field.GetRawConstantValue().ToString();
                var arr = field.GetCustomAttributes(typeDescription, true);
                var strText = arr.Length > 0 ? ((DescriptionAttribute)arr[0]).Description : field.Name;

                var item = new SelectListItem { Text = strText, Value = strValue };

                if (strValue.Equals(selectFeild))
                    item.Selected = true;
                yield return item;
            }
        }

        /// <summary>
        /// 将指定枚举类型转换成List，用来绑定ListControl
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="selectFeild">默认选择的项的值</param>
        /// <returns></returns>
        public static List<SelectListItem> ConvertEnumToList(Type enumType, string selectFeild)
        {
            if (enumType.IsEnum == false) { return null; }
            var typeDescription = typeof(DescriptionAttribute);
            var fields = enumType.GetFields();
            var selectListItems = new List<SelectListItem>();
            foreach (var field in fields.Where(field => !field.IsSpecialName))
            {
                var strValue = field.GetRawConstantValue().ToString();
                var arr = field.GetCustomAttributes(typeDescription, true);
                var strText = arr.Length > 0 ? ((DescriptionAttribute)arr[0]).Description : field.Name;

                var item = new SelectListItem { Text = strText, Value = strValue };

                if (strValue.Equals(selectFeild))
                    item.Selected = true;
                selectListItems.Add(item);
            }
            return selectListItems;
        }

        /// <summary>
        /// 将指定枚举类型转换成List，用来绑定ListControl
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="selectFeild">默认选择的项的值</param>
        /// <param name="removeFeild">需要移除的值</param>
        /// <returns></returns>
        public static List<SelectListItem> ConvertEnumToList(Type enumType, string selectFeild, string removeFeild)
        {
            if (enumType.IsEnum == false) { return null; }
            var typeDescription = typeof(DescriptionAttribute);
            var fields = enumType.GetFields();
            var selectListItems = new List<SelectListItem>();
            foreach (var field in fields.Where(field => !field.IsSpecialName))
            {
                var strValue = field.GetRawConstantValue().ToString();
                if (strValue == removeFeild) continue;
                var arr = field.GetCustomAttributes(typeDescription, true);
                var strText = arr.Length > 0 ? ((DescriptionAttribute)arr[0]).Description : field.Name;

                var item = new SelectListItem { Text = strText, Value = strValue };

                if (strValue.Equals(selectFeild))
                    item.Selected = true;
                selectListItems.Add(item);
            }
            return selectListItems;
        }

        /// <summary>
        /// 将指定枚举类型转换成List，用来绑定ListControl
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="selectFeild">默认选择的项的值</param>
        /// <param name="removeFeilds">需要移除的值 集合</param>
        /// <returns></returns>
        public static List<SelectListItem> ConvertEnumToList(Type enumType, string selectFeild, string[] removeFeilds)
        {
            if (enumType.IsEnum == false) { return null; }
            var typeDescription = typeof(DescriptionAttribute);
            var fields = enumType.GetFields();
            var selectListItems = new List<SelectListItem>();
            foreach (var field in fields.Where(field => !field.IsSpecialName))
            {
                var strValue = field.GetRawConstantValue().ToString();
                if (removeFeilds.Contains(strValue)) continue;
                var arr = field.GetCustomAttributes(typeDescription, true);
                var strText = arr.Length > 0 ? ((DescriptionAttribute)arr[0]).Description : field.Name;

                var item = new SelectListItem { Text = strText, Value = strValue };

                if (strValue.Equals(selectFeild))
                    item.Selected = true;
                selectListItems.Add(item);
            }
            return selectListItems;
        }

        /// <summary>
        /// 将指定枚举类型转换成List，用来绑定ListControl
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        /// <param name="selectFeildlist">默认选择的项的值</param>
        /// <returns></returns>
        public static IEnumerable<SelectListItem> ConvertEnumToListItems(Type enumType, List<string> selectFeildlist)
        {
            if (enumType.IsEnum == false) { yield return null; }
            var typeDescription = typeof(DescriptionAttribute);
            var fields = enumType.GetFields();
            foreach (var field in fields.Where(field => !field.IsSpecialName))
            {
                var strValue = field.GetRawConstantValue().ToString();
                var arr = field.GetCustomAttributes(typeDescription, true);
                var strText = arr.Length > 0 ? ((DescriptionAttribute)arr[0]).Description : field.Name;

                var item = new SelectListItem { Text = strText, Value = strValue };
                if (selectFeildlist.Contains(strValue))
                {
                    item.Selected = true;
                }
                yield return item;
            }
        }
    }
}
