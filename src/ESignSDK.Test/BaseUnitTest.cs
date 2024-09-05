using System;
using System.IO;
using ESignSDK.Responses;
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
            // read from user profile / secrets/.esign
            var path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "secrets/.esign");
            var configText = File.ReadAllText(path);
            Console.WriteLine(configText);
            //configText 类似 按行分的 key=value 所以读取后需要按行分割 并按Key赋值
            var configLines = configText.Split("\n");
            var config = new ESignOption();
            foreach (var line in configLines)
            {
                var kv = line.Split("=");
                if (kv.Length == 2)
                {
                    var key = kv[0].Trim();
                    var value = kv[1].Trim();
                    if (key == "BASE_URL")
                    {
                        config.BaseUrl = value;
                    }
                    else if (key == "API_ID")
                    {
                        config.AppId = value;
                    }
                    else if (key == "API_KEY")
                    {
                        config.AppKey = value;
                    }
                }
            }

            config.Debug = true;
            _client = new ESignSDKClient(config);
        }

        public void WriteJson(object obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj));
        }
    }
}