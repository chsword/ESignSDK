using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ESignSDK.Responses;

namespace ESignSDK
{
    internal class HttpUtils
    {
        public HttpUtils(ESignSDKClient client)
        {
            Client = client;
        }

        private int _timeout = 100000;
        public ESignSDKClient Client { get; set; }

        private void Signature(HttpWebRequest request, string url, string bodyString)
        {
            if (string.IsNullOrWhiteSpace(bodyString))
            {
                bodyString = "{}";
            }

            var appId = Client.Option.AppId;
            var contentMd5 = Md5Utils.Md5Base64(bodyString);
            var dt = DateTime.Now;
            var httpMethod = request.Method;

            request.Headers.Add("X-Tsign-Open-App-Id", appId);
            request.Headers.Add("X-Tsign-Open-Auth-Mode", HttpHeaderConstant.Signature);
            request.Headers.Add(HttpRequestHeader.Accept, HttpHeaderConstant.Accept);
            request.Headers.Add(HttpRequestHeader.ContentType, HttpHeaderConstant.ContentTypeJson);
            request.Headers.Add("X-Tsign-Open-Ca-Timestamp", GetTimestamp(dt));

            request.Headers.Add(HttpRequestHeader.ContentMd5, contentMd5);

            var stringToSign = new StringBuilder();
            stringToSign.Append($"{httpMethod.ToUpper()}\n");
            stringToSign.Append($"{HttpHeaderConstant.Accept}\n");
            stringToSign.Append($"{contentMd5}\n");
            stringToSign.Append($"{HttpHeaderConstant.ContentTypeJson}\n");
            stringToSign.Append($"{HttpHeaderConstant.Date}\n");
            stringToSign.Append(url.Replace(Client.Option.BaseUrl, ""));
            var signnature = DoSignatureBase64(stringToSign.ToString());
            request.Headers.Add("X-Tsign-Open-Ca-Signature", signnature);
        }

       
        string DoSignatureBase64(string message)
        {
            using (var provider = new HMACSHA256(Encoding.UTF8.GetBytes(Client.Option.AppKey)))
            {
                byte[] retVal = provider.ComputeHash(Encoding.UTF8.GetBytes(message));
                return Convert.ToBase64String(retVal);
            }
        }

        string GetTimestamp(DateTime dt)
        {
            var startTime = new DateTime(1970, 1, 1, 8, 0, 0, 0);
            long t = (dt.Ticks - startTime.Ticks) / 10000; //除10000调整为13位        
            return t.ToString();
        }

        public HttpWebRequest GetWebRequest(string url, string method)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            //req.ServicePoint.Expect100Continue = false;
            req.Method = method;
            req.KeepAlive = true;
            req.UserAgent = "ESign by Zou";
            req.Timeout = this._timeout;
            return req;
        }

        public static string GetResponseAsString(HttpWebResponse rsp, Encoding encoding)
        {
            Stream stream = null;
            StreamReader reader = null;

            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
            finally
            {
                // 释放资源
                if (reader != null) reader.Close();
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }

        public async Task<ApiResult<T>> GetAsync<T>(string url)
        {
            var method = "GET";
            try
            {
                var client = GetWebRequest(url, method);
                Signature(client, url, "");
                HttpWebResponse response = (HttpWebResponse)await client.GetResponseAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var str = GetResponseAsString(response, Encoding.UTF8);
                    return JsonUtils.Deserialize<T>(str);
                }
                return ApiResult<T>.Error(response.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                return ApiResult<T>.Error(ex.ToString());
            }
        }



        public async Task<ApiResult<TResponse>> PostAsync<TResponse, TRequest>(
            string url,
            TRequest request
        )
        {

            var method = "POST";
            try
            {
                var body = JsonUtils.SerializeCamel(request);
                var client = GetWebRequest(url, method);
                Signature(client, url, body);
                byte[] postData = Encoding.UTF8.GetBytes(body);
                Stream reqStream = client.GetRequestStream();
                await reqStream.WriteAsync(postData, 0, postData.Length);
                reqStream.Close();
                HttpWebResponse response = (HttpWebResponse)await client.GetResponseAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var str = GetResponseAsString(response, Encoding.UTF8);
                    return JsonUtils.Deserialize<TResponse>(str);
                }
                return ApiResult<TResponse>.Error(response.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                return ApiResult<TResponse>.Error(ex.ToString());
            }

            
        }

        public async Task<ApiResult<TResponse>> PutAsync<
            TResponse, TRequest>(
            string url,
            TRequest request
        ) where TResponse : class
        {
            var method = "PUT";
            try
            {
                var body = JsonUtils.SerializeCamel(request);
                var client = GetWebRequest(url, method);
                Signature(client, url, body);
                byte[] postData = Encoding.UTF8.GetBytes(body);
                Stream reqStream = client.GetRequestStream();
                await reqStream.WriteAsync(postData, 0, postData.Length);
                reqStream.Close();
                HttpWebResponse response = (HttpWebResponse)await client.GetResponseAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var str = GetResponseAsString(response, Encoding.UTF8);
                    return JsonUtils.Deserialize<TResponse>(str);
                }
                return ApiResult<TResponse>.Error(response.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                return ApiResult<TResponse>.Error(ex.ToString());
            }
        }

        public async Task<ApiResult<object>> PutFileAsync(
            string url, byte[] bytes
        )
        {
            using (var client = new HttpClient())
            {
                try
                {
                    using (HttpContent httpContent = new ByteArrayContent(bytes))
                    {
                        //httpContent.Headers.Add("Content-MD5", Md5Utils.Md5Base64(bytes));
                        httpContent.Headers.ContentMD5 = Md5Utils.Md5(bytes);
                        httpContent.Headers.ContentLength = bytes.LongLength;
                        httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream");
                        using (var response = await client.PutAsync(url, httpContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var str = await response.Content.ReadAsStringAsync();
                                Console.WriteLine(str);
                                return new ApiResult();
                            }

                            return ApiResult.Error(response.ReasonPhrase);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ApiResult.Error(ex);
                }
            }
        }

        public async Task<ApiResult<T>> DeleteAsync<T>(string url)
        {
            var method = "DELETE";
            try
            {
                var request = GetWebRequest(url, method);
                Signature(request, url, "");
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var str = GetResponseAsString(response, Encoding.UTF8);
                    return JsonUtils.Deserialize<T>(str);
                }
                return ApiResult<T>.Error(response.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                return ApiResult<T>.Error(ex.ToString());
            }
        }

        //private void Authed(HttpClient client)
        //{
        //    client.DefaultRequestHeaders.Add(
        //        "X-Tsign-Open-App-Id",
        //        Client.Option.AppId);
        //    if (Client?.Token?.Token == null)
        //    {
        //        var result = Client.AccessTokenAsync().Result;
        //        if (result.Code != ReturnTypeCode.Success)
        //        {
        //            throw new Exception("Access Token fail");
        //        }
        //    }

        //    client.DefaultRequestHeaders.Add(
        //        "X-Tsign-Open-Token",
        //        Client.Token.Token);
        //}
    }
}