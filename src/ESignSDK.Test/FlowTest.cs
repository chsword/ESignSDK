using System;
using System.Collections.Generic;
using System.Linq;
using ESignSDK.Models;
using ESignSDK.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESignSDK.Test
{
    [TestClass]
    public class FlowTest : BaseUnitTest
    {
        string flowId = "ae2119f93bba405f8eeff5c7751ffb97";

        string accountId = "a9c24ec246d2414fa5bfd56b8534ac02";
        private string fileId = "6703017e7d0c44a588778076af3e92c0";
        [TestMethod]
        public void GetTest()
        {
            var ret = _client.SignFlowGet(flowId).Result;
            WriteJson(ret);
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
     *{"data":[{"downloadUrl":"https://esignoss.esign.cn/1111564182/77eb44e1-f029-4ee5-a0ab-54c3af89ddaa/esign_doc_dcaab56068af4ad5afa86c5fdd2205217633201794455585740.pdf.pdf?Expires=1576137514&OSSAccessKeyId=LTAIdvHfiVrzDKbE&Signature=7ajSpy7Ln/KnNZFRTZXt/SmWhg8%3D","fileId":"6703017e7d0c44a588778076af3e92c0","fileName":"Letter to Changde.pdf-邹健-637117595144908372"},{"downloadUrl":"https://esignoss.esign.cn/1111564182/4d9188cf-45b3-493b-950a-6f8050cc9890/esign_doc_ec081567b5e7481a87a09217ee7c9a607212521236459371477.pdf.pdf?Expires=1576137514&OSSAccessKeyId=LTAIdvHfiVrzDKbE&Signature=Qf80SsbgFmr3qzEByF9CMzptn7A%3D","fileId":"902137e73f42438ea56dbe3418d71a82","fileName":"Letter to Changde.pdf-1125612-637117595147435542"},{"downloadUrl":"https://esignoss.esign.cn/1111564182/daa0cf44-afab-4063-af72-77a5f9b23ef5/esign_doc_abca81d0288f475688f29956f7dcbc5c6836103321269884242.pdf.pdf?Expires=1576137515&OSSAccessKeyId=LTAIdvHfiVrzDKbE&Signature=nb06MEkjsMcUw8EaXf8RYJHO1hg%3D","fileId":"25d903c6e3154699b2329ab65d34e930","fileName":"Letter to Changde.pdf-222222-637117595149752443"},{"downloadUrl":"https://esignoss.esign.cn/1111564182/6de054c5-5a03-40c7-b073-568d4438d3b2/esign_doc_893635ed03594dea8c64fa2401b612ad2639064932081899645.pdf.pdf?Expires=1576137515&OSSAccessKeyId=LTAIdvHfiVrzDKbE&Signature=BzCKrEZu2Gi/gFfEtrhNewhJ9L4%3D","fileId":"270f6b7788e04e869eb779c15be840a8","fileName":"Letter to Changde.pdf-333333-637117595152255552"}],"code":0,"message":null}
     *{"data":["1952f2934a7b462fb83a159f9c179bf4","ae2119f93bba405f8eeff5c7751ffb97"],"code":0,"message":null}
     */
}