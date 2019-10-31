using System;
using System.IO;
using System.Text.Json;
using System.Threading.Channels;
using ESignSDK.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESignSDK.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {

        }
        [TestMethod]
        public void AccessTokenTest()
        {
            var client =new ESignSDKClient(new ESignOption()
            {
                BaseUrl = "https://smlopenapi.esign.cn",
                AppId= "",
                AppKey = ""
            });
            var token =client.AccessTokenAsync().Result;
            Console.WriteLine(token.Code);
            Console.WriteLine(token.Message);
            Console.WriteLine(token.Data.Token);
            Console.WriteLine(token.Data.ExpiresIn);
            Console.WriteLine(token.Data.RefreshToken);
        }

        [TestMethod]
        public void SerializeJsonTest()
        {
            var ret = JsonSerializer.Deserialize<ApiResult<AccessTokenResponse>>(
                "{\"code\":0,\"message\":\"成功\",\"data\":{\"expiresIn\":\"1572508647135\",\"token\":\"eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJnSWQiOiI4N2I4YmJhNGY2N2U0ZjRiODQ3Njc2M2FmNTRjZGYxYSIsImFwcElkIjoiNDQzODc4MTA4MyIsIm9JZCI6ImJiZDNlYTExZWY0ZDQyNmI4NTYzNDhmYjg1MDYxM2ZmIiwidGltZXN0YW1wIjoxNTcyNTAxNDQ3MTM0fQ.Kkl4kgvwW0XDGc31KlIcNOEahjqRp6WTWoPxILmAmuM\",\"refreshToken\":\"9bfd029803e824f4efb40a4bbd857dd8\"}}",
                new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                }
            );
            ret.Message = "成功";
            using var stream = new MemoryStream();
            var utf8JsonWriter = new Utf8JsonWriter(stream);
            var str = JsonSerializer.Serialize(ret, new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            Console.WriteLine(str);
            Assert.IsNotNull(ret);
        }
    }
}
