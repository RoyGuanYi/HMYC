using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Charm.Common
{
    public class RestServiceProxy
    {

        #region MD5加密

        /// <summary>
        /// 获取MD5加密后字符串
        /// </summary>
        /// <param name="sourceString"></param>
        /// <returns></returns>
        public static string Md5Encode(string sourceString)
        {
            return Md5Encode(sourceString, 32);
        }

        public static string Md5Encode(string sourceString, int digits)
        {
            return Md5Encode(sourceString, digits, true);
        }

        /// <summary>
        /// 获取获取MD5加密后字符串
        /// </summary>
        /// <param name="sourceString">源字符串</param>
        /// <param name="digits">加密位数(16或32)</param>
        /// <param name="isToUpper">是否大写</param>
        /// <returns></returns>
        public static string Md5Encode(string sourceString, int digits, bool isToUpper)
        {
            if (string.IsNullOrEmpty(sourceString))
                return string.Empty;
            var targetString = digits == 16
                                   ? System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(
                                       sourceString, "MD5").Substring(8, 16)
                                   : System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(
                                       sourceString, "MD5");
            if (targetString != null) return isToUpper ? targetString.ToUpper() : targetString.ToLower();
            return null;
        }

        #endregion

        /// <summary>
        /// 验证信息
        /// </summary>
        /// <returns></returns>
        public static string GetToken()
        {
            var accountId = "SCAMS";
            var password = "SCAMS123";
            var time = DateTime.Now.ToString("yyyyMMddHH");//2016051123
            return Md5Encode(String.Format("{0}{1}{2}", accountId, password, time));
        }

        public static List<T> Get<T>(string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var response = httpClient.GetAsync(endpoint).Result;

                return JsonConvert.DeserializeObject<List<T>>(response.Content.ReadAsStringAsync().Result);
            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="id"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public static Stream GetFile(string id, string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, endpoint + id))
                {
                    HttpResponseMessage responseTask = httpClient.SendAsync(request).Result;
                    Stream contentStream = responseTask.Content.ReadAsStreamAsync().Result;
                    return contentStream;
                }

            }
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="id"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public static Stream GetFile<T1>(T1 data, string endpoint)
        {            
            using (var httpClient = NewHttpClient())
            {
                var requestMessage = GetObjectPropertyValue(data);
                if (!string.IsNullOrEmpty(requestMessage))
                {
                    endpoint += "?" + requestMessage.Remove(0, 1);
                }
                using (var request = new HttpRequestMessage(HttpMethod.Get, endpoint))
                {
                    HttpResponseMessage responseTask = httpClient.SendAsync(request).Result;
                    Stream contentStream = responseTask.Content.ReadAsStreamAsync().Result;
                    return contentStream;
                }

            }
        }

        public static void DownloadFile(Uri url, string destination, AsyncCompletedEventHandler completeHandler, DownloadProgressChangedEventHandler progressHandler)
        {
            using (var webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += completeHandler;
                webClient.DownloadProgressChanged += progressHandler;
                webClient.DownloadFileAsync(url, destination);
            }
        }


        public static T Get<T>(int id, string endpoint)
        {            
            using (var httpClient = NewHttpClient())
            {
                var response = httpClient.GetAsync(endpoint + id).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
            }
        }
        public static T Get<T>(string id, string endpoint)
        {            
            T obj;
            using (var httpClient = NewHttpClient())
            {
                var response = httpClient.GetAsync(endpoint + id).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                obj = JsonConvert.DeserializeObject<T>(result);
                return obj;
            }
        }
        public static T GetOne<T>(string endpoint)
        {
            T obj;
            using (var httpClient = NewHttpClient())
            {
                var response = httpClient.GetAsync(endpoint).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                obj = JsonConvert.DeserializeObject<T>(result);
                return obj;
            }
        }

        public static T CheckWhetherInternet<T>(string endpoint)
        {
            T obj;
            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(endpoint).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                obj = JsonConvert.DeserializeObject<T>(result);
                return obj;
            }
        }
        /// <summary>
        /// general get restful service data 
        /// </summary>
        /// <typeparam name="T1">return data type</typeparam>
        /// <typeparam name="T2">input data type</typeparam>
        /// <param name="data">search condition</param>
        /// <param name="endpoint">service url</param>
        /// <returns></returns>
        public static T1 Get<T1, T2>(T2 data, string endpoint)
        {
           
            using (var httpClient = NewHttpClient())
            {
                var _endpoint = endpoint;

                var requestMessage = GetObjectPropertyValue(data);
                if (!string.IsNullOrEmpty(requestMessage))
                {
                    _endpoint += "?" + requestMessage.Remove(0, 1);
                }
      
                var response = httpClient.GetAsync(_endpoint).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                 
                    //throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<T1>(result);
            }
        }

        //public static T1 Get<T1, T2>(T2 requestdate, string module, string apimothed)
        //{
        //    string url = GlobalClientConfig.BaseURI + module + "/" + apimothed + "/";
        //    return RestServiceProxy.Get<T1, T2>(requestdate, url);
        //}

        public static List<T1> GetList<T1, T2>(T2 data, string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var _endpoint = endpoint;
                var requestMessage = GetObjectPropertyValue(data);
                if (!string.IsNullOrEmpty(requestMessage))
                {
                    _endpoint += "?" + requestMessage.Remove(0, 1);
                }
                var response = httpClient.GetAsync(_endpoint).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }
                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<T1>>(result);
            }
        }

        public static List<T1> GetList<T1>(string id, string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var response = httpClient.GetAsync(endpoint + id).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<T1>>(result);
            }
        }
        public static List<T1> GetList<T1>(string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var response = httpClient.GetAsync(endpoint).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<List<T1>>(result);
            }
        }

        public static string Post<T>(T data, string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var requestMessage = JsonConvert.SerializeObject(data);
                HttpContent contentPost = new StringContent(requestMessage, Encoding.UTF8, "application/json");
                var response = httpClient.PostAsync(endpoint, contentPost).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<string>(result);
            }
        }

        public static TRetrun Post<TRetrun, TPost>(TPost data, string endpoint)
        {
          
            using (var httpClient = NewHttpClient())
            {
                //var requestMessage = JsonHelper.JsonSerializer<TPost>(data);
                var requestMessage = JsonConvert.SerializeObject(data,new IsoDateTimeConverter());
                HttpContent contentPost = new StringContent(requestMessage, Encoding.UTF8, "application/json");
                var response = httpClient.PostAsync(endpoint, contentPost).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<TRetrun>(result);
            }
        }

        public static Dictionary<string, object> PostByDictionay<T>(T data, string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var requestMessage = JsonConvert.SerializeObject(data);
                HttpContent contentPost = new StringContent(requestMessage, Encoding.UTF8, "application/json");
                var response = httpClient.PostAsync(endpoint, contentPost).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("Invoke Server Service Error");
                }

                string result = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Dictionary<string, object>>(result);
            }
        }

        public static string GetObjectPropertyValue<T>(T t)
        {
            StringBuilder sb = new StringBuilder();
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property != null && t != null)
                {
                    object o = property.GetValue(t, null);
                    if (o != null)
                    {
                        sb.Append("&" + property.Name + "=" + o); ;
                    }
                }
            }
            return sb.ToString();
        }

        public static string Delete<T>(T data, string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var _endpoint = endpoint;
                var requestMessage = GetObjectPropertyValue(data);
                if (!string.IsNullOrEmpty(requestMessage))
                {
                    _endpoint += "?" + requestMessage.Remove(0, 1);
                }
                var result = httpClient.DeleteAsync(_endpoint).Result;
                //return result.Content.ReadAsStringAsync().Result;


                string res = result.Content.ReadAsStringAsync().Result;
                return res;
            }
        }

        public static string Delete(string id, string endpoint)
        {
            using (var httpClient = NewHttpClient())
            {
                var result = httpClient.DeleteAsync(endpoint + id).Result;

                return result.Content.ReadAsStringAsync().Result;
            }
        }

        protected static HttpClient NewHttpClient()
        {

            var handler = new HttpClientHandler() {AutomaticDecompression = DecompressionMethods.GZip};
            return new HttpClient(handler);
        }

    }
}
