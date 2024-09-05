using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESignSDK.Models;
using ESignSDK.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESignSDK.Test
{
    [TestClass]
    public class FlowTest : BaseUnitTest
    {
        string flowId = "e3817020187e445194a7e5c56765a2dd";

        string accountId = "a9c24ec246d2414fa5bfd56b8534ac02";
        private string fileId = "6703017e7d0c44a588778076af3e92c0";
        [TestMethod]
        public async Task GetTest()
        {
            var ret = await _client.SignFlowGet(flowId);
            WriteJson(ret);
            Console.WriteLine("-------");
            foreach (var o in ret.Data.ExtensionData)
            {
                Console.WriteLine(o.Key);
                Console.WriteLine(o.Value);
            }
        }
        [TestMethod]
        public void AddDocument()
        {
            var ret = _client.SignFlowDocumentCreate(flowId,new SignFlowDocumentCreateRequest()
            {
                Docs=new SignFlowDocumentWithSetting[]
                {
                    new SignFlowDocumentWithSetting()
                    {
                        FileId = fileId,
                        FileName = "ererere"
                    }, 
                }
            }).Result;
            WriteJson(ret);
        }
        [TestMethod]
        public void GetDocument()
        {
            var ret = _client.SignFlowDocumentGet(flowId).Result;
            WriteJson(ret);
        }
        [TestMethod]
        public void GetSignFlowSignersTest()
        {
          
            var ret = _client.SignFlowSignersGet(flowId).Result;
            WriteJson(ret);

        }

        [TestMethod]
        public void Start()
        {
            var ret1 = _client.SignFlowStart(flowId).Result;
            WriteJson(ret1);
        }

        [TestMethod]
        public void SignAuth()
        {
            var ret1 = _client.SignAuthOn(accountId).Result;
            WriteJson(ret1);
        }

        [TestMethod]
        public void Sign1()
        {
            var template = _client.TemplatesGet("f99af68af6f8462fba25a9c7826cca9c").Result;
            var component = template.Data.StructComponents.First(c => c.Key == "甲方-签署区");

         
            var ret = _client.AccountSealGet(accountId).Result;
            var seal = ret.Data.Seals.FirstOrDefault();
       
            var ret1 = _client.SignFlowFieldAutoSign(flowId,new SignFlowFieldAutoSignRequest()
            {
                Signfields=new List<SignFieldAutoSign>()
                {
                    new SignFieldAutoSign()
                    {
                        AuthorizedAccountId=accountId,
                        FileId = fileId,
                        Order=1,
                        SignType=1,
                        ThirdOrderNo="xxx",
                        SealId=seal.SealId,
                        PosBean = new SignFieldPosBean()
                        {
                            PosPage = component.Context.Pos.Page.ToString(),
                            PosX = component.Context.Pos.X,
                            PosY = component.Context.Pos.Y,
                        }
                    }
                }
            }).Result;
            WriteJson(ret1);
        }
        [TestMethod]
        public void SignFlowArchive()
        {

            var ret1 = _client.SignFlowArchive(flowId).Result;
            WriteJson(ret1);
        }
    }

    /*
     *{"data":[
     * {"downloadUrl":"","fileName":"Letter to Changde.pdf--637117595144908372"},
     * {"downloadUrl":"","fileId":"902137e73f42438ea56dbe3418d71a82","fileName":"Letter to Changde.pdf-1125612-637117595147435542"},
     * {"downloadUrl":"","fileId":"25d903c6e3154699b2329ab65d34e930","fileName":"Letter to Changde.pdf-222222-637117595149752443"},
     * {"downloadUrl":"","fileId":"270f6b7788e04e869eb779c15be840a8","fileName":"Letter to Changde.pdf-333333-637117595152255552"}],"code":0,"message":null}
     *{"data":["1952f2934a7b462fb83a159f9c179bf4","ae2119f93bba405f8eeff5c7751ffb97"],"code":0,"message":null}
     */
}