using System;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public ESignSDKClient Client { get; set; }

        public async Task<ApiResult<T>> DeleteAsync<T>(string url, bool authed = true)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    if (authed)
                    {
                        Authed(client);
                    }

                    using (var response = await client.DeleteAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var str = await response.Content.ReadAsStringAsync();
                            return JsonUtils.Deserialize<T>(str);
                        }

                        return ApiResult<T>.Error(response.ReasonPhrase);
                    }
                }
                catch
                {
                    return null;
                }
            }
        }

        public async Task<ApiResult<T>> GetAsync<T>(string url, bool authed = true)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    if (authed)
                    {
                        Authed(client);
                    }

                    using (var response = await client.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var str = await response.Content.ReadAsStringAsync();
                            return JsonUtils.Deserialize<T>(str);
                        }

                        return ApiResult<T>.Error(response.ReasonPhrase);
                    }
                }
                catch (Exception ex)
                {
                    return ApiResult<T>.Error(ex);
                }
            }
        }

        public async Task<ApiResult<TResponse>> PostAsync<TResponse, TRequest>(
            string url,
            TRequest request,
            bool authed = true
        )
        {
            using (var client = new HttpClient())
            {
                if (authed)
                {
                    Authed(client);
                }

                try
                {
                    client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    var body = JsonUtils.SerializeCamel(request);

                    using (HttpContent httpContent = new StringContent(body, Encoding.UTF8, "application/json"))
                    {
                        using (var response = await client.PostAsync(url, httpContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var str = await response.Content.ReadAsStringAsync();
                                return JsonUtils.Deserialize<TResponse>(str);
                            }

                            return ApiResult<TResponse>.Error(response.ReasonPhrase);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ApiResult<TResponse>.Error(ex);
                }
            }
        }

        public async Task<ApiResult<TResponse>> PutAsync<
            TResponse, TRequest>(
            string url,
            TRequest request,
            bool authed = true
        ) where TResponse : class
        {
            using (var client = new HttpClient())
            {
                if (authed)
                {
                    Authed(client);
                }

                try
                {
                    client.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
                    // client.DefaultRequestHeaders.
                    var body = JsonUtils.SerializeCamel(request);

                    using (HttpContent httpContent = new StringContent(body, Encoding.UTF8, "application/json"))
                    {
                        using (var response = await client.PutAsync(url, httpContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var str = await response.Content.ReadAsStringAsync();
                                return JsonUtils.Deserialize<TResponse>(str);
                            }

                            return ApiResult<TResponse>.Error(response.ReasonPhrase);
                        }
                    }
                }
                catch (Exception ex)
                {
                    return ApiResult<TResponse>.Error(ex);
                }
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

        private void Authed(HttpClient client)
        {
            client.DefaultRequestHeaders.Add(
                "X-Tsign-Open-App-Id",
                Client.Option.AppId);
            if (Client?.Token?.Token == null)
            {
                var result = Client.AccessTokenAsync().Result;
                if (result.Code != ReturnTypeCode.Success)
                {
                    throw new Exception("Access Token fail");
                }
            }

            client.DefaultRequestHeaders.Add(
                "X-Tsign-Open-Token",
                Client.Token.Token);
        }
    }
}