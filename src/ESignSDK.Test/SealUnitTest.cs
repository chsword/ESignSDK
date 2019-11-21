using ESignSDK.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ESignSDK.Test
{
    [TestClass]
    public class SealUnitTest : BaseUnitTest
    {
        [TestMethod]
        public void SealAccount()
        {
            var ret = _client.AccountSealCreate("851ffc96444e46928dceb327ae2e0c78",
                new AccountSealCreateRequest()
                {
                    Alias = "我的印章 "
                }).Result;
            WriteJson(ret);
        }

        [TestMethod]
        public void SealGet()
        {
            var ret = _client.AccountSealGet("851ffc96444e46928dceb327ae2e0c78", 0, 10).Result;
            WriteJson(ret);
        }

        [TestMethod]
        public void SealOrg()
        {
            var ret2 = _client.OrganizationCreate(new OrganizationCreateRequest()
            {
                Creator = "851ffc96444e46928dceb327ae2e0c78",
                Name = "测试三里屯供销总社有限责任公司",
                IdType = CredOrgType.CRED_ORG_USCC,
                IdNumber = "91310000132276535F",
                ThirdPartyUserId = "test_org_2"
            }).Result;
            WriteJson(ret2);
            var ret = _client.OrganizationSealCreate(ret2.Data.OrgId,
                new OrganizationSealCreateRequest()
                {
                    Alias = "测试1", Htext = "合同专用章", Qtext = "91310000132276535F"
                }).Result;
            WriteJson(ret);
            var ret5 = _client.OrganizationDelete(ret2.Data.OrgId).Result;
        }
    }
}