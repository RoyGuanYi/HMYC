
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.MvcExt.Extisions
{
    public class ConfigHelper
    {
        /// <summary>
        ///  获取webconfig指定键的值
        /// </summary>
        /// <param name="key">指定键</param>
        /// <param name="defaultValue">当获取的值为空时返回该值</param>
        /// <returns></returns>
        public static string GetAppSettings(string key, string defaultValue = "")
        {
            var value = ConfigurationManager.AppSettings[key];//获取指定的配置信息
            return value == null ? defaultValue : value.ToString();
        }
        /// <summary>
        ///  获取webconfig指定键的值
        /// </summary>
        /// <param name="name">指定名称</param>
        /// <param name="defaultValue">当获取的值为空时返回该值</param>
        /// <returns></returns>
        public static string GetConnectionString(string name, string defaultValue = "")
        {
            //获取指定的配置信息
            var value = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return value == null ? defaultValue : value.ToString();
        }
        /// <summary>
        ///  获取App_Data中配置文件指定键的值
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static string GetAppDataAppSettings(string key, string defaultValue = "")
        {
            var map = new ExeConfigurationFileMap
            {
                ExeConfigFilename = AppDomain.CurrentDomain.BaseDirectory + "\\App_Data\\App.config"
            };
            var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            var value = config.AppSettings.Settings[key].Value;
            return value == null ? defaultValue : value.ToString();
        }
        /// <summary>
        /// 获取App_Data中数据连接字符串
        /// </summary>
        /// <param name="name">数据连接名字</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns></returns>
        public static string GetAppDataConnectionString(string name, string defaultValue = "")
        {
            var map = new ExeConfigurationFileMap
            {
                ExeConfigFilename = AppDomain.CurrentDomain.BaseDirectory + "\\App_Data\\App.config"
            };
            var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            var value = config.ConnectionStrings.ConnectionStrings[name].ConnectionString;
            return value == null ? defaultValue : value.ToString();
        }

    
    }
}
