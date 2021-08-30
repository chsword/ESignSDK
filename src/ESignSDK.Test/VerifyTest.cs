using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace ESignSDK.Test
{
    [TestClass]
    public class VerifyTest:BaseUnitTest
    {
        [TestMethod]
        public void DocumentVerifyTest()
        {
            var flow = _client.SignFlowDocumentGet("").Result;
            Console.WriteLine(JsonConvert.SerializeObject(flow));
         
            var result = _client.DocumentsVerify(flow.Data.Docs.FirstOrDefault().FileId, "").Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
 
        }

    }
}