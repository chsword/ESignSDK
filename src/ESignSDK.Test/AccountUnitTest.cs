using System;
using ESignSDK.Models;
using ESignSDK.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace ESignSDK.Test
{
    [TestClass]
    public class AccountUnitTest : BaseUnitTest
    {
        [TestMethod]
        public void AccessTokenTest()
        {
            var token = _client.AccessTokenAsync().Result;
            Console.WriteLine(token.Code);
            Console.WriteLine(token.Message);
            Console.WriteLine(token.Data.Token);
            Console.WriteLine(token.Data.ExpiresIn);
            Console.WriteLine(token.Data.RefreshToken);
        }

        [TestMethod]
        public void AccountGetTest()
        {
            var result = _client.AccountGet("851ffc96444e46928dceb327ae2e0c78").Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
            result = _client.AccountGetByThirdId("test2").Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }


        [TestMethod]
        public void CreateAndDeleteTest1()
        {
            var result = _client.AccountCreate(new AccountCreateRequest()
            {
                Email = "cctt@126.com",
                IdNumber = "test",
                Name = "444444",
                ThirdPartyUserId = "test4"
            }).Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
            var ret2 = _client.AccountDelete(result.Data.AccountId).Result;
            Console.WriteLine(JsonConvert.SerializeObject(ret2));
        }


        [TestMethod]
        public void CreateAndDeleteTest2()
        {
            var result = _client.AccountCreate(new AccountCreateRequest()
            {
                Email = "cctt@126.com",
                IdNumber = "test",
                Name = "444444",
                ThirdPartyUserId = "test4"
            }).Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
            var ret2 = _client.AccountDeleteByThirdId("test4").Result;
            Console.WriteLine(JsonConvert.SerializeObject(ret2));
        }

        [TestMethod]
        public void CreateUserTest()
        {
            var result = _client.AccountCreate(new AccountCreateRequest()
            {
                Email = "test@126.com",
                IdNumber = "test",
                Name = "test",
                ThirdPartyUserId = "test2"
            }).Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void ModifyUserTest()
        {
            var result = _client.AccountModify("851ffc96444e46928dceb327ae2e0c78", new ThirdPartyUser()
            {
                Email = "test@126.com",
                IdNumber = "test",
                Name = "test1",
            }).Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        [TestMethod]
        public void ModifyUserTest2()
        {
            var result = _client.AccountModifyByThirdId("test2", new ThirdPartyUser()
            {
                Email = "test@126.com",
                IdNumber = "test",
                Name = "test1",
            }).Result;
            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}