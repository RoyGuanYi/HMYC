using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charm.Common.Models.Common
{
    /// <summary>
    /// 客户端配置文件
    /// </summary>
    public class GlobalClientConfig
    {
        /// <summary>
        /// Check network status
        /// </summary>
        static string _baseURI = "";
        public static string BaseURI
        {
            get
            {
                if (string.IsNullOrEmpty(_baseURI))
                {
                    _baseURI = ConfigurationManager.AppSettings["BaseURI"].ToString();
                }
                return _baseURI;
            }
        }
    }
}
