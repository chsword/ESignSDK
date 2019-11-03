using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ESignSDK.Responses;

namespace ESignSDK
{
    internal class HttpUtils
    {
        public static async Task<ApiResult<T>> GetAsync<T>(string url) where T : class
        {

            using (var client = new HttpClient())
            {
                try
                {
                    using (var response = await client.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var str = await response.Content.ReadAsStringAsync();
                            return JsonUtils.Deserialize<T>(str);
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public static async Task<ApiResult<TResponse>> PostAsync<TResponse, TRequest>(string url,
            TRequest request) where TResponse : class
        {

            using (var client = new HttpClient())
            {
                try
                {
                    var body = JsonUtils.SerializeCamel(request);

                    using (HttpContent httpContent = new StringContent(body, Encoding.UTF8))
                    {
                        using (var response = await client.PostAsync(url, httpContent))
                        {
                            if (response.IsSuccessStatusCode)
                            {
                                var str = await response.Content.ReadAsStringAsync();
                                return JsonUtils.Deserialize<TResponse>(str);
                            }
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }

            return null;
        }
    }
}