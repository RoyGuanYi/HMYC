using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Charm.Common
{
    /// <summary>
    /// 通用方法
    /// </summary>
    public class CommonMethod
    {
       
    }

    /// <summary>
    /// MD5加密辅助类
    /// </summary>
    public class Md5Encode
    {
        public static string Encode(string str)
        {
            byte[] byteInput = UTF8Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider objMd5 = new MD5CryptoServiceProvider();
            byte[] byteOutput = objMd5.ComputeHash(byteInput);
            return BitConverter.ToString(byteOutput).Replace("-", "");
        }

        public static string EncodeHex(string str)
        {
            StringBuilder s = new StringBuilder();
            foreach (byte b in Md5ComputeHash(str))
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        private static byte[] Md5ComputeHash(string strvalue)
        {
            byte[] byteInput = Encoding.UTF8.GetBytes(strvalue);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            return md5.ComputeHash(byteInput);
        }
    }
}
