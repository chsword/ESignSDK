using System;
using ESignSDK.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace ESignSDK.Test
{
    [TestClass]
    public class OrganizationTest : BaseUnitTest
    {
        [TestMethod]
        public void OrganizationTest1()
        {
            var ret1 = _client.AccountCreate(new AccountCreateRequest()
            {
                Email = "cctt@126.com",
                IdNumber = "test",
                Name = "55555",
                ThirdPartyUserId = "test2"
            }).Result;
            Console.WriteLine(JsonConvert.SerializeObject(ret1));
            var ret2 = _client.OrganizationCreate(new OrganizationCreateRequest()
            {
                Creator = ret1.Data.AccountId,
                Name = "a1",
                IdType = CredOrgType.CRED_ORG_USCC,
                IdNumber = "921309",
                ThirdPartyUserId = "test_org_1"
            }).Result;
            ;
            WriteJson(ret2);
            var ret3 = _client.OrganizationModify(ret2.Data.OrgId, new ThirdPartyOrganization()
            {
                Name = "b2"
            }).Result;
            WriteJson(ret3);
            var ret4 = _client.OrganizationGet(ret3.Data.OrgId).Result;
            WriteJson(ret4);
            var ret5 = _client.OrganizationDelete(ret4.Data.OrgId).Result;
            WriteJson(ret5);
        }

        [TestMethod]
        public void OrganizationTest2()
        {
            var ret1 = _client.AccountCreate(new AccountCreateRequest()
            {
                Email = "cctt@126.com",
                IdNumber = "test",
                Name = "55555",
                ThirdPartyUserId = "test2"
            }).Result;
            Console.WriteLine(JsonConvert.SerializeObject(ret1));
            var ret2 = _client.OrganizationCreate(new OrganizationCreateRequest()
            {
                Creator = ret1.Data.AccountId,
                Name = "a1",
                IdType = CredOrgType.CRED_ORG_USCC,
                IdNumber = "921309",
                ThirdPartyUserId = "test_org_1"
            }).Result;
            ;
            WriteJson(ret2);
            var ret3 = _client.OrganizationModifyByThirdId("test_org_1", new ThirdPartyOrganization()
            {
                Name = "b2"
            }).Result;
            WriteJson(ret3);
            var ret4 = _client.OrganizationGetByThirdId("test_org_1").Result;
            WriteJson(ret4);
            var ret5 = _client.OrganizationDeleteByThirdId("test_org_1").Result;
            WriteJson(ret5);
        }
    }
}