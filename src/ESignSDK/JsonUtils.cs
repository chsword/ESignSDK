
using ESignSDK.Responses;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ESignSDK
{
    internal class JsonUtils
    {
        public static ApiResult<T> Deserialize<T>(string str) where T : class
        {

            return JsonConvert.DeserializeObject<ApiResult<T>>(str);
        }

        public static string SerializeCamel(object obj)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }
    }
}