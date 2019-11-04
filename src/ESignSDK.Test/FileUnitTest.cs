using System;
using System.IO;
using System.Security.Cryptography;
using ESignSDK.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESignSDK.Test
{
    [TestClass]
    public class FileUnitTest:BaseUnitTest
    {
        [TestMethod]
        public void FileGetTest()
        {
            var ret = _client.FileGet("85d43e03bf924e528d64a40e4bd9adce").Result;
            WriteJson(ret);


        }
        [TestMethod]
        public void MyTestMethod()
        {
            var filepath = Path.Combine(Environment.CurrentDirectory, "test.pdf");
            Console.WriteLine(filepath);
            Assert.IsTrue(File.Exists(filepath));
            var bytes = File.ReadAllBytes(filepath);
            var ret = _client.FileGetUploadUrl(new FileGetUploadUrlRequest()
            {
                ContentMd5 = Md5Utils.Md5Base64(bytes),
                FileName = "test.pdf",
                FileSize = bytes.LongLength
            }).Result;
            WriteJson(ret);
            var ret1 = _client.FileUpload(ret.Data.UploadUrl, bytes).Result;
            WriteJson(ret1);
        }
        [TestMethod]
        public void FileMd5Test()
        {
            var ret = Md5Utils.Md5Base64("0123456789");
            Assert.AreEqual("eB5eJF1ptWaXm4bijSPyxw==", ret);
        }
    }
}