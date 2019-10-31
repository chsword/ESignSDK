using System.Text;
using System.Text.Json;
using ESignSDK.Responses;

namespace ESignSDK
{
    internal class JsonUtils
    {
        public static ApiResult<T> Deserialize<T>(string str) where T : class
        {
            var jsonUtf8 = Encoding.UTF8.GetBytes(str);
            var reader = new Utf8JsonReader(jsonUtf8, true, default);
            var result = JsonSerializer.Deserialize<ApiResult<T>>(ref reader,
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
            return result;
        }
        //public static ApiResult<T> Deserialize<T>(string str) where T : class
        //{
        //    var jsonUtf8 = Encoding.UTF8.GetBytes(str);
        //    var reader = new Utf(jsonUtf8, true, default);
        //    var result = JsonSerializer.Serialize(ref reader,
        //        new JsonSerializerOptions()
        //        {
        //            PropertyNameCaseInsensitive = true
        //        });
        //    return result;
        //}
    }
}