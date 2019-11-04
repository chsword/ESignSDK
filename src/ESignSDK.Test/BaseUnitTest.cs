using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace ESignSDK.Test
{
    public class BaseUnitTest
    {
        protected ESignSDKClient _client = null;
        [TestInitialize]
        public void Init()
        {
            _client = new ESignSDKClient(new ESignOption()
            {
                BaseUrl = "https://smlopenapi.esign.cn",
                AppId = "",
                AppKey = ""
            });
        }

        public void WriteJson(object obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj));
        }
    }
}